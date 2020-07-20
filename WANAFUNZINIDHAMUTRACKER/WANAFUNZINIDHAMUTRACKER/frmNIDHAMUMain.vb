Imports System
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.OleDb
Imports System.ComponentModel

Public Class frmNIDHAMUMain

    ' This is the connection to the local MS Access database.
    ' The database is needed in both the Debug and Release folders.
    'At Public Class level, you only need one connection for all procedures in the form. You will only be opening and closing them whenever you want to fetch records from the database


    'This is roaming database connection

    Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")


    'Another way of roaming database connection

    'Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\DBSTUDENTSNIDHAMU.mdb;Persist Security Info=False;")



    'Also define the datasets and dataadapters at public class level so that they can be accessed by other procedures
    Dim dst1 As New DataSet
    Dim dst2 As New DataSet
    Dim dstotherdetails As New DataSet
    Dim dstForCategoriesCombo As New DataSet
    Dim dstForOffenseTypesCombo As New DataSet
    Dim dstCLASS As New DataSet
    Dim dstStream As New DataSet
    Dim dstDormitories As New DataSet


    Dim dtadpt1 As OleDb.OleDbDataAdapter
    Dim dtadpt2 As OleDb.OleDbDataAdapter
    Dim dtadptOtherDetails As OleDb.OleDbDataAdapter
    Dim dtadptForCategoriesCombo As OleDb.OleDbDataAdapter
    Dim dtadptForOffenseTypesCombo As OleDb.OleDbDataAdapter
    Dim dtadptCLASS As OleDb.OleDbDataAdapter
    Dim dtadptStream As OleDb.OleDbDataAdapter
    Dim dtadptDormitories As OleDb.OleDbDataAdapter

    Private Sub frmNIDHAMUMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            'fetch data for the combobox 'ADMNO'

            'clear the previous record before fetching new record and bind it to the combobox 'ComboADNO'
            dst1.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadpt1 = New OleDb.OleDbDataAdapter("SELECT DISTINCT ADMISSIONNUMBER From tblSTUDENTSNIDHAMU", conn)


            'To increment the ID field. Purposely placed here before this table is filled for the first time in this form module.

            'First datagridview ' DataGridViewFirstStudentDetails'   

            With dst2.Tables.Add("tblSTUDENTSNIDHAMU")
                .Columns.Add("ID", System.Type.GetType("System.Int32"))
                .Columns("ID").AutoIncrement = True
                .Columns("ID").AutoIncrementSeed = -1
                .Columns("ID").AutoIncrementStep = -1

            End With



            'second datagridview 'datagridviewStudentsOtherDetails'

            ' With dstotherdetails.Tables.Add("tblSTUDENTSNIDHAMU")
            '.Columns.Add("ID", System.Type.GetType("System.Int32"))
            '.Columns("ID").AutoIncrement = True
            '.Columns("ID").AutoIncrementSeed = -1
            '.Columns("ID").AutoIncrementStep = -1

            'End With



            ' Use the data adapter to fill data in the dataset
            dtadpt1.Fill(dst1, "tblSTUDENTSNIDHAMU") 'For combobox ADMNO




            'fetch data for the offense Types combobox on the datagridview

            'clear the previous record before fetching new record and bind it to the combobox on the datagridview
            dstForOffenseTypesCombo.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptForOffenseTypesCombo = New OleDb.OleDbDataAdapter("SELECT DISTINCT ID, OFFENSETYPE From tblOFFENSESTYPES", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptForOffenseTypesCombo.Fill(dstForOffenseTypesCombo, "tblOFFENSESTYPES") 'For combobox on the datagridview




            'fetch data for the offense categories combobox on datagridview

            'clear the previous record before fetching new record and bind it to the combobox on the datagridview
            dstForCategoriesCombo.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptForCategoriesCombo = New OleDb.OleDbDataAdapter("SELECT DISTINCT ID, COFFENSECATEGORY From tblOFFENSESCATEGORIES", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptForCategoriesCombo.Fill(dstForCategoriesCombo, "tblOFFENSESCATEGORIES") 'For combobox on the datagridview




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



            'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx


            'fetch data for the Dormitory combobox on the datagridview

            'clear the previous record before fetching new record and bind it to the combobox on the datagridview
            dstDormitories.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptDormitories = New OleDb.OleDbDataAdapter("SELECT DISTINCT ID, DORMITORY From tblDORMITORY", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptDormitories.Fill(dstDormitories, "tblDORMITORY") 'For combobox on the datagridview

            conn.Close()


            'Fill the combobox 'ComboADMNO'

            ComboADMNO.DataSource = dst1.Tables("tblSTUDENTSNIDHAMU")
            ComboADMNO.DisplayMember = "ADMISSIONNUMBER"
            ComboADMNO.ValueMember = "ADMISSIONNUMBER"





            'create a comboboxcolumn for OffenseTypes on the datagridview

            Dim ComboOffenseType As New DataGridViewComboBoxColumn()
            ComboOffenseType.DataSource = dstForOffenseTypesCombo.Tables("tblOFFENSESTYPES")
            ComboOffenseType.Name = "ComboOffenseType"
            ComboOffenseType.ValueMember = "OFFENSETYPE"
            ComboOffenseType.DisplayMember = "OFFENSETYPE"
            ComboOffenseType.DataPropertyName = "TYPEOFOFFENSE" 'Bind to field on the child's table

            ComboOffenseType.HeaderText = "OFFENSE TYPE"
            ComboOffenseType.DefaultCellStyle.Format = "d"

            DataGridViewFirstStudentDetails.Columns.Add(ComboOffenseType)

            DataGridViewFirstStudentDetails.EditMode = DataGridViewEditMode.EditOnEnter
            'prevents having to click the ComboBox twice





            'create a comboboxcolumn for OffenseCategories on the datagridview

            Dim comboOffenseCatgry As New DataGridViewComboBoxColumn()
            comboOffenseCatgry.DataSource = dstForCategoriesCombo.Tables("tblOFFENSESCATEGORIES")
            comboOffenseCatgry.Name = "comboOffenseCatgry"
            comboOffenseCatgry.ValueMember = "COFFENSECATEGORY"
            comboOffenseCatgry.DisplayMember = "COFFENSECATEGORY"
            comboOffenseCatgry.DataPropertyName = "OFFENSECATEGORY" 'Bind to field on the child's table

            comboOffenseCatgry.HeaderText = "OFFENCES COMMITTED"
            comboOffenseCatgry.DefaultCellStyle.Format = "d"

            DataGridViewFirstStudentDetails.Columns.Add(comboOffenseCatgry)

            DataGridViewFirstStudentDetails.Columns("comboOffenseCatgry").Width = 200

            DataGridViewFirstStudentDetails.EditMode = DataGridViewEditMode.EditOnEnter
            'prevents having to click the ComboBox twice






            'create a comboboxcolumn for Class on the datagridview

            Dim ComboCLASS As New DataGridViewComboBoxColumn()
            ComboCLASS.DataSource = dstCLASS.Tables("tblCLASSSTREAM")
            ComboCLASS.Name = "ComboCLASS"
            ComboCLASS.ValueMember = "CCLASS"
            ComboCLASS.DisplayMember = "CCLASS"
            ComboCLASS.DataPropertyName = "CLASS" 'Bind to field on the child's table

            ComboCLASS.HeaderText = "CLASS"
            ComboCLASS.DefaultCellStyle.Format = "d"

            DataGridViewFirstStudentDetails.Columns.Add(ComboCLASS)

            DataGridViewFirstStudentDetails.EditMode = DataGridViewEditMode.EditOnEnter
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

            DataGridViewFirstStudentDetails.Columns.Add(ComboSTREAM)

            DataGridViewFirstStudentDetails.EditMode = DataGridViewEditMode.EditOnEnter
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

            DataGridViewFirstStudentDetails.Columns.Add(ComboDormitory)

            DataGridViewFirstStudentDetails.EditMode = DataGridViewEditMode.EditOnEnter
            'prevents having to click the ComboBox twice






            'create a comboboxcolumn for family Situation on the datagridview

            Dim ComboFAMILYSITUATION As New DataGridViewComboBoxColumn()
            ' ComboFAMILYSITUATION.DataSource = dst.Tables("tblCLASSSEX")
            ComboFAMILYSITUATION.Name = "ComboFAMILYSITUATION"
            'ComboFAMILYSITUATION.ValueMember = "ID"
            'ComboFAMILYSITUATION.DisplayMember = "SEX"


            ComboFAMILYSITUATION.Items.AddRange("BOTH PARENTS ALIVE", "TOTAL ORPHAN", "PARTIAL ORPHAN", "SINGLE PARENT", "PARENTS DIVORCED", "PARENTS SEPARATED", "LIVING WITH WELLWISHER/RELATIVE")
            ComboFAMILYSITUATION.DataPropertyName = "FAMILYSITUATION"


            ComboFAMILYSITUATION.HeaderText = "FAMILY SITUATION"
            ComboFAMILYSITUATION.DefaultCellStyle.Format = "d"

            ComboFAMILYSITUATION.Width = 220

            DataGridViewFirstStudentDetails.Columns.Add(ComboFAMILYSITUATION)

            DataGridViewFirstStudentDetails.EditMode = DataGridViewEditMode.EditOnEnter
            'prevents having to click the ComboBox twice



            'create a comboboxcolumn for the term on the datagridview

            Dim ComboTERM As New DataGridViewComboBoxColumn()
            ComboTERM.Name = "ComboTERM"

            ComboTERM.Items.AddRange("TERM 1", "TERM 2", "TERM 3")
            ComboTERM.DataPropertyName = "TERM"


            ComboTERM.HeaderText = "TERM"
            ComboTERM.DefaultCellStyle.Format = "d"

            ComboTERM.Width = 80

            DataGridViewFirstStudentDetails.Columns.Add(ComboTERM)

            DataGridViewFirstStudentDetails.EditMode = DataGridViewEditMode.EditOnEnter
            'prevents having to click the ComboBox twice



            'Re-order the datagridview Combobox columns that are created in the load event:
            DataGridViewFirstStudentDetails.Columns("ComboTERM").DisplayIndex = 2
            DataGridViewFirstStudentDetails.Columns("ComboOffenseType").DisplayIndex = 20
            DataGridViewFirstStudentDetails.Columns("comboOffenseCatgry").DisplayIndex = 21
            DataGridViewFirstStudentDetails.Columns("comboCLASS").DisplayIndex = 5
            DataGridViewFirstStudentDetails.Columns("comboSTREAM").DisplayIndex = 6
            DataGridViewFirstStudentDetails.Columns("ComboDormitory").DisplayIndex = 7
            DataGridViewFirstStudentDetails.Columns("ComboFAMILYSITUATION").DisplayIndex = 39

            'Hide the ID, CURRENTMARKS, CURRENTPOINTS columns
            DataGridViewFirstStudentDetails.Columns("ID").Visible = False
            DataGridViewFirstStudentDetails.Columns("CURRENTMARKS").Visible = False
            DataGridViewFirstStudentDetails.Columns("CURRENTPOINTS").Visible = False
            DataGridViewFirstStudentDetails.Columns("KCPEPOINTS").Visible = False


            ' DataGridViewFirstStudentDetails.Columns("comboOffenseCatgry").DefaultCellStyle.BackColor = Color.White

            'show instructions in txtNameToSearch text box

            txtNameToSearch.Text = "Enter name to search here"
            txtNameToSearch.ForeColor = Color.Red

            txtNameToSearch.Font = New Font(txtNameToSearch.Font.FontFamily, 10, FontStyle.Bold)




            'Set column widths
            DataGridViewFirstStudentDetails.Columns("ADMISSIONNUMBER").Width = 60
            DataGridViewFirstStudentDetails.Columns("NAMEOFSTUDENT").Width = 150
            DataGridViewFirstStudentDetails.Columns("DATEOFOCCURENCE").Width = 90
            DataGridViewFirstStudentDetails.Columns("OFFENSECOMMITED").Width = 130
            DataGridViewFirstStudentDetails.Columns("GENDER").Width = 60
            DataGridViewFirstStudentDetails.Columns("FORMERSCHOOL").Width = 150
            DataGridViewFirstStudentDetails.Columns("KCPEMARKS").Width = 50
            DataGridViewFirstStudentDetails.Columns("KCPEGRADE").Width = 50
            DataGridViewFirstStudentDetails.Columns("CURRENTMARKS").Width = 50
            DataGridViewFirstStudentDetails.Columns("CURRENTPOINTS").Width = 50
            DataGridViewFirstStudentDetails.Columns("CURRENTGRADE").Width = 50
            DataGridViewFirstStudentDetails.Columns("STUDENTVAP").Width = 50
            DataGridViewFirstStudentDetails.Columns("CLASSPOSITION").Width = 50
            DataGridViewFirstStudentDetails.Columns("STREAMPOSITION").Width = 50
            DataGridViewFirstStudentDetails.Columns("FEESBALANCE").Width = 60
            DataGridViewFirstStudentDetails.Columns("FEEPAYER").Width = 110
            DataGridViewFirstStudentDetails.Columns("NAMEOFPARENT").Width = 110
            DataGridViewFirstStudentDetails.Columns("PARENTPHONENUMBER").Width = 80
            DataGridViewFirstStudentDetails.Columns("RESIDENCEESTATE").Width = 120
            DataGridViewFirstStudentDetails.Columns("EXPECTEDDATEOFRETURN").Width = 90
            DataGridViewFirstStudentDetails.Columns("ACTUALDATEOFRETURN").Width = 90
            DataGridViewFirstStudentDetails.Columns("DIDSTUDENTRETURN").Width = 80
            DataGridViewFirstStudentDetails.Columns("TYPEOFPUNISHMENT").Width = 110
            DataGridViewFirstStudentDetails.Columns("DIDPUNSHMENT").Width = 90
            DataGridViewFirstStudentDetails.Columns("PUNSHMENTSTATE").Width = 110
            DataGridViewFirstStudentDetails.Columns("DATECOMPLETEDPUNSHMENT").Width = 110
            DataGridViewFirstStudentDetails.Columns("PUNSHEDBY").Width = 100
            DataGridViewFirstStudentDetails.Columns("GUIDED").Width = 70
            DataGridViewFirstStudentDetails.Columns("GUIDEDDATE").Width = 100
            DataGridViewFirstStudentDetails.Columns("DISCONTINUED").Width = 100
            DataGridViewFirstStudentDetails.Columns("RESPONSIBILITY").Width = 150


            'Set column headings to shorter names
            DataGridViewFirstStudentDetails.Columns("DATEOFOCCURENCE").HeaderText = "DATE OF OCCURENCE"
            DataGridViewFirstStudentDetails.Columns("ADMISSIONNUMBER").HeaderText = "ADMNO"
            DataGridViewFirstStudentDetails.Columns("NAMEOFSTUDENT").HeaderText = "STUDENT NAME"
            DataGridViewFirstStudentDetails.Columns("OFFENSECOMMITED").HeaderText = "OFFENCES NARATION"
            DataGridViewFirstStudentDetails.Columns("FORMERSCHOOL").HeaderText = "FORMER SCHOOL"
            DataGridViewFirstStudentDetails.Columns("DATEOFADMISSION").HeaderText = "DATE OF ADMISSION"
            DataGridViewFirstStudentDetails.Columns("KCPEMARKS").HeaderText = "KCPE MARKS"
            DataGridViewFirstStudentDetails.Columns("KCPEGRADE").HeaderText = "KCPE GRADE"
            DataGridViewFirstStudentDetails.Columns("CURRENTMARKS").HeaderText = "CURR. MARKS"
            DataGridViewFirstStudentDetails.Columns("CURRENTPOINTS").HeaderText = "CURR. POINTS"
            DataGridViewFirstStudentDetails.Columns("CURRENTGRADE").HeaderText = "CURR. GRADE"
            DataGridViewFirstStudentDetails.Columns("STUDENTVAP").HeaderText = "STDNT VAP"
            DataGridViewFirstStudentDetails.Columns("CLASSPOSITION").HeaderText = "CLASS POS"
            DataGridViewFirstStudentDetails.Columns("STREAMPOSITION").HeaderText = "STRM POS"
            DataGridViewFirstStudentDetails.Columns("FEESBALANCE").HeaderText = "FEES BALANCE"
            DataGridViewFirstStudentDetails.Columns("FEEPAYER").HeaderText = "FEE PAYER"
            DataGridViewFirstStudentDetails.Columns("NAMEOFPARENT").HeaderText = "NAME OF PARENT"
            DataGridViewFirstStudentDetails.Columns("PARENTPHONENUMBER").HeaderText = "PARENT'S PHONE #"
            DataGridViewFirstStudentDetails.Columns("RESIDENCEESTATE").HeaderText = "RESIDENCE/ESTATE"
            DataGridViewFirstStudentDetails.Columns("EXPECTEDDATEOFRETURN").HeaderText = "EXPECTED RETURNDATE"
            DataGridViewFirstStudentDetails.Columns("ACTUALDATEOFRETURN").HeaderText = "ACTUAL RETURNDATE"
            DataGridViewFirstStudentDetails.Columns("DIDSTUDENTRETURN").HeaderText = "RETURNED?"
            DataGridViewFirstStudentDetails.Columns("TYPEOFPUNISHMENT").HeaderText = "PUNISHMENT GIVEN"
            DataGridViewFirstStudentDetails.Columns("DIDPUNSHMENT").HeaderText = "DID PUNISHMENT?"
            DataGridViewFirstStudentDetails.Columns("PUNSHMENTSTATE").HeaderText = "PUNISHMENT STATE"
            DataGridViewFirstStudentDetails.Columns("DATECOMPLETEDPUNSHMENT").HeaderText = "DATE COMPLETED PUNISHMENT"
            DataGridViewFirstStudentDetails.Columns("PUNSHEDBY").HeaderText = "PUNISHED BY"
            DataGridViewFirstStudentDetails.Columns("GUIDED").HeaderText = "GUIDED?"
            DataGridViewFirstStudentDetails.Columns("GUIDEDDATE").HeaderText = "GUIDED DATE"
            DataGridViewFirstStudentDetails.Columns("DISCONTINUED").HeaderText = "DISCONTINUED?"
            DataGridViewFirstStudentDetails.Columns("RESPONSIBILITY").HeaderText = "RESPONSIBILITY HELD"



            'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx



            'Transfer the information below to the text boxes


            'Automatically populate repetetive data into the textboxes

            txtADMISSIONNUMBER.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("ADMISSIONNUMBER").Value.ToString
            txtNAMEOFSTUDENT.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("NAMEOFSTUDENT").Value.ToString
            txtGENDER.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("GENDER").Value.ToString
            txtKCPEMARKS.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("KCPEMARKS").Value
            txtKCPEGRADE.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("KCPEGRADE").Value.ToString
            txtFORMERSCHOOL.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("FORMERSCHOOL").Value.ToString
            txtDATEOFADMISSION.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("DATEOFADMISSION").Value.ToString



            'Make the above columns invisible on the datagridview

            DataGridViewFirstStudentDetails.Columns("ADMISSIONNUMBER").Visible = False
            DataGridViewFirstStudentDetails.Columns("NAMEOFSTUDENT").Visible = False
            DataGridViewFirstStudentDetails.Columns("GENDER").Visible = False
            DataGridViewFirstStudentDetails.Columns("KCPEMARKS").Visible = False
            DataGridViewFirstStudentDetails.Columns("KCPEGRADE").Visible = False
            DataGridViewFirstStudentDetails.Columns("FORMERSCHOOL").Visible = False
            DataGridViewFirstStudentDetails.Columns("DATEOFADMISSION").Visible = False






            'lllllllllllllllllllllllllllllllllllllllllllllllll

            'If OFFENSECATEGORY is DISCIPLINED, then tblSTUDENTSNIDHAMU.DATEOFOCCURENCE = tblNEWSTUDENTS.DATEOFADMISSION

            'If conn.State = ConnectionState.Open Then conn.Close()

            'conn.Open()


            'Dim dstDateOccur As New DataSet()
            'Dim dstDateAdm As New DataSet()


            'Dim dtadptDateOccur As OleDb.OleDbDataAdapter
            'Dim dtadptDateAdm As OleDb.OleDbDataAdapter

            'Dim IntCntDateOccur As Integer
            'Dim IntCntDateAdm As Integer

            'This sub procedure takes a long time to complete(It is a long operation) Therefore:

            ' Set cursor as hourglass for waiting to prevent the user doing something else before the operation completes

            ' Cursor.Current = Cursors.WaitCursor

            ' Application.DoEvents()

            ' Execute your code here

            'fetch data 
            'clear the previous record before fetching new record 

            'dstDateOccur.Clear()
            'dstDateAdm.Clear()

            'Set the data adapter and fetch data from the database using select query
            'dtadptDateOccur = New OleDb.OleDbDataAdapter("SELECT ID, DATEOFOCCURENCE, OFFENSECATEGORY From tblSTUDENTSNIDHAMU ORDER BY ADMISSIONNUMBER ASC", conn)
            'dtadptDateAdm = New OleDb.OleDbDataAdapter("SELECT ID, DATEOFOCCURENCE From tblNEWSTUDENTS ORDER BY ADMISSIONNUMBER ASC", conn)


            ' Use the data adapter to fill data in the dataset
            'dtadptDateOccur.Fill(dstDateOccur, "tblSTUDENTSNIDHAMU")
            'dtadptDateAdm.Fill(dstDateAdm, "tblNEWSTUDENTS")


            'close connection after filling the datasets
            'conn.Close()



            'If IntCntDateOccur <> -1 And IntCntDateAdm <> -1 Then



            'Dim cbDatesOccur As New OleDb.OleDbCommandBuilder(dtadptDateOccur)


            'cbDatesOccur.ConflictOption = ConflictOption.OverwriteChanges


            'IntCntDateOccur = 0
            'IntCntDateAdm = 0


            'If dstDateAdm.Tables("tblNEWSTUDENTS").Rows.Count > 0 And dstDateOccur.Tables("tblSTUDENTSNIDHAMU").Rows.Count > 0 Then

            'For IntCntDateOccur = 0 To dstDateOccur.Tables("tblSTUDENTSNIDHAMU").Rows.Count - 1
            'For IntCntDateAdm = 0 To dstDateAdm.Tables("tblNEWSTUDENTS").Rows.Count - 1

            'If dstDateOccur.Tables("tblSTUDENTSNIDHAMU").Rows(IntCntDateOccur).Item("OFFENSECATEGORY") = "DISCIPLINED" Then
            'dstDateOccur.Tables("tblSTUDENTSNIDHAMU").Rows(IntCntDateOccur).Item("DATEOFOCCURENCE") = dstDateAdm.Tables("tblNEWSTUDENTS").Rows(IntCntDateAdm).Item("DATEOFOCCURENCE")
            'End If
            'Next IntCntDateAdm
            'Next IntCntDateOccur

            'End If
            'End If




            'save data in the database table

            'dtadptDateOccur.Update(dstDateOccur, "tblSTUDENTSNIDHAMU")


            ' Set cursor as default arrow to return it to the normal state from the hourglass.
            'Cursor.Current = Cursors.Default





            Me.Show()
            Me.WindowState = FormWindowState.Maximized


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        Try

                If conn.State = ConnectionState.Open Then conn.Close()

                conn.Open()



            'For single user updating, just use the command builder to overwrite the changes. This approach is called 'Last in Win"

            Dim cb2 As New OleDb.OleDbCommandBuilder(dtadpt2)

            cb2.ConflictOption = ConflictOption.OverwriteChanges


            dtadpt2.Update(dst2, "tblSTUDENTSNIDHAMU")



            'NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN

            'Updating in a multiple user environment, use this 'Optimistic approach though not yet completed.

            '  Dim updateCommand As New OleDb.OleDbCommand("Update tblSTUDENTSNIDHAMU Set [ADMISSIONNUMBER]=@ADMISSIONNUMBER, [TYPEOFOFFENSE]= @TYPEOFOFFENSE, [OFFENSECATEGORY] =@OFFENSECATEGORY, [NAMEOFSTUDENT] =@NAMEOFSTUDENT WHERE [ID]= @ID", conn) ' and [ADMISSIONNUMBER] =@ADMISSIONNUMBER and [GENDER] =@GENDER and [Field 6] =" &
            '  "@Field6 and  [Field 7] =@Field7 and  [Field 8] =@Field8 and  [Field 9] =@Field9 and  [Field 10] =@Field10 and  [Field 11] =@Field11 and  [Field 12] = " &
            '  "@Field12 and  [Field 13] =@Field13 and  [Field 14] =@Field14 and  [Field 15] =@Field15 and  [Field 16] =@Field16 and  [Field 17] =@Field17", conn)

            ' updateCommand.Parameters.Add("@ADMISSIONNUMBER", OleDb.OleDbType.VarChar, 15, "ADMISSIONNUMBER")
            ' updateCommand.Parameters.Add("@DATEOFOCCURENCE", OleDb.OleDbType.VarChar, 50, "DATEOFOCCURENCE")
            ' updateCommand.Parameters.Add("@Field3", OleDb.OleDbType.VarChar, 50, "Field 3")


            ' updateCommand.Parameters.Add("@TYPEOFOFFENSE", OleDb.OleDbType.VarChar, 70, "TYPEOFOFFENSE")

            ' updateCommand.Parameters.Add("@OFFENSECATEGORY", OleDb.OleDbType.VarChar, 70, "OFFENSECATEGORY")

            ' updateCommand.Parameters.Add("@NAMEOFSTUDENT", OleDb.OleDbType.VarChar, 40, "NAMEOFSTUDENT")

            'updateCommand.Parameters.Add("@ID", OleDb.OleDbType.VarChar, 70, "ID")



            ' dtadpt2.UpdateCommand = updateCommand
            ' ....DataTable1 Changes...
            ' dtadpt2.Update(dst2, "tblSTUDENTSNIDHAMU")


            'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx

            ' Dim cb2 As New OleDb.OleDbCommandBuilder(dtadpt2)

            ' dtadpt2.Update(dst2, "tblSTUDENTSNIDHAMU")


            MsgBox("Record(s) Successfully Saved!", MsgBoxStyle.OkOnly, "")

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ComboADMNO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboADMNO.SelectedIndexChanged

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()

            'clear the previous record before fetching new record and bind it to the datagridview
            dst2.Clear()


            Dim SQLstudnts As String

            SQLstudnts = "Select ID, DATEOFOCCURENCE, TERM, NAMEOFSTUDENT, ADMISSIONNUMBER, GENDER, CLASS, STREAM, DORMITORIES, FORMERSCHOOL, DATEOFADMISSION, KCPEMARKS, KCPEGRADE, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASSPOSITION, STREAMPOSITION, OFFENSECOMMITED,"

            SQLstudnts &= " FEESBALANCE, FEEPAYER, TYPEOFOFFENSE, OFFENSECATEGORY, EXPECTEDDATEOFRETURN, DIDSTUDENTRETURN, ACTUALDATEOFRETURN, STATEOFAFFAIRS, TYPEOFPUNISHMENT, DIDPUNSHMENT, PUNSHMENTSTATE, DATECOMPLETEDPUNSHMENT, "

            SQLstudnts &= "PUNSHEDBY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER, COUNTY, SUBCOUNTY, RESIDENCEESTATE, GUIDED, GUIDEDDATE, DISCONTINUED, RESPONSIBILITY, REMARKS, KCPEPOINTS, ACADEMICYEAR FROM tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER = '" & ComboADMNO.Text & "' ORDER BY DATEOFOCCURENCE ASC"


            'Set the data adapter and fetch the records from the database using the select query
            dtadpt2 = New OleDb.OleDbDataAdapter(SQLstudnts, conn)



            'Below query for handling null values in Access database

            '  SQLstudnts &= "IIF(ISNULL(NAMEOFSTUDENT),0,NAMEOFSTUDENT) As NAMEOFSTUDENT, "

            ' SQLstudnts &= "IIF(ISNULL(ADMISSIONNUMBER),0,ADMISSIONNUMBER) As ADMISSIONNUMBER,"

            ' SQLstudnts &= "IIF(ISNULL(GENDER),0,GENDER) As GENDER,"

            'SQLstudnts &= "IIf(ISNULL(Class), 0, Class) As Class,"
            ' SQLstudnts &= "Class,"

            ' SQLstudnts &= "IIf(ISNULL(STREAM), 0, STREAM) As STREAM,"
            ' SQLstudnts &= "STREAM,"

            ' SQLstudnts &= "IIF(ISNULL(OFFENSECOMMITED),0,OFFENSECOMMITED) As OFFENSECOMMITED,"

            ' SQLstudnts &= "IIf(ISNULL(TYPEOFOFFENSE), 0, TYPEOFOFFENSE) As TYPEOFOFFENSE,"

            ' SQLstudnts &= "TYPEOFOFFENSE,"

            'SQLstudnts &= "IIf(ISNULL(OFFENSECATEGORY), 0, OFFENSECATEGORY) As OFFENSECATEGORY,"
            ' SQLstudnts &= "OFFENSECATEGORY,"


            'SQLstudnts &= "IIF(ISNULL(FORMERSCHOOL),0,FORMERSCHOOL) As FORMERSCHOOL,"

            ' SQLstudnts &= "IIF(ISNULL(FEESBALANCE),0,FEESBALANCE) As FEESBALANCE,"

            ' SQLstudnts &= "IIF(ISNULL(FEEPAYER),0,FEEPAYER) As FEEPAYER,"


            ' SQLstudnts &= "IIF(ISNULL(EXPECTEDDATEOFRETURN),0,EXPECTEDDATEOFRETURN) As EXPECTEDDATEOFRETURN,"

            ' SQLstudnts &= "IIF(ISNULL(ACTUALDATEOFRETURN),0,ACTUALDATEOFRETURN) As ACTUALDATEOFRETURN,"

            'SQLstudnts &= "IIF(ISNULL(DIDSTUDENTRETURN),0,DIDSTUDENTRETURN) As DIDSTUDENTRETURN,"

            ' SQLstudnts &= "DIDSTUDENTRETURN,"

            ' SQLstudnts &= "IIF(ISNULL(STATEOFAFFAIRS),0,STATEOFAFFAIRS) As STATEOFAFFAIRS,"



            'SQLstudnts &= "IIF(ISNULL(DIDPUNSHMENT),0,DIDPUNSHMENT) As DIDPUNSHMENT,"

            ' SQLstudnts &= "DIDPUNSHMENT,"



            ' SQLstudnts &= "IIF(ISNULL(PUNSHMENTSTATE),0,PUNSHMENTSTATE) As PUNSHMENTSTATE,"


            ' SQLstudnts &= "IIF(ISNULL(DATECOMPLETEDPUNSHMENT),0,DATECOMPLETEDPUNSHMENT) As DATECOMPLETEDPUNSHMENT,"

            ' SQLstudnts &= "IIF(ISNULL(PUNSHEDBY),0,PUNSHEDBY) As PUNSHEDBY,"


            'SQLstudnts &= "IIF(ISNULL(STUDENTPHOTO),0,STUDENTPHOTO) As STUDENTPHOTO,"

            ' SQLstudnts &= "STUDENTPHOTO,"


            ' SQLstudnts &= "IIF(ISNULL(FAMILYSITUATION),0,FAMILYSITUATION) As FAMILYSITUATION,"
            'SQLstudnts &= "FAMILYSITUATION,"


            'SQLstudnts &= "IIF(ISNULL(NAMEOFPARENT),0,NAMEOFPARENT) As NAMEOFPARENT,"




            'SQLstudnts &= "IIF(ISNULL(PARENTPHONENUMBER),0,PARENTPHONENUMBER) As PARENTPHONENUMBER,"

            ' SQLstudnts &= "IIF(ISNULL(COUNTY),0,COUNTY) As COUNTY,"

            'SQLstudnts &= "IIF(ISNULL(SUBCOUNTY),0,SUBCOUNTY) As SUBCOUNTY,"

            'SQLstudnts &= "IIF(ISNULL(RESIDENCEESTATE),0,RESIDENCEESTATE) As RESIDENCEESTATE,"

            ' SQLstudnts &= "IIF(ISNULL(KCPEMARKS),0,KCPEMARKS) As KCPEMARKS,"

            '  SQLstudnts &= "IIF(ISNULL(KCPEGRADE),0,KCPEGRADE) As KCPEGRADE,"

            '  SQLstudnts &= "IIF(ISNULL(CURRENTMARKS),0,CURRENTMARKS) As CURRENTMARKS,"

            '  SQLstudnts &= "IIF(ISNULL(CURRENTGRADE),0,CURRENTGRADE) As CURRENTGRADE,"

            ' SQLstudnts &= "IIF(ISNULL(STUDENTVAP),0,STUDENTVAP) As STUDENTVAP,"

            ' SQLstudnts &= "IIF(ISNULL(CLASSPOSITION),0,CLASSPOSITION) As CLASSPOSITION,"

            ' SQLstudnts &= "IIF(ISNULL(STREAMPOSITION),0,STREAMPOSITION) As STREAMPOSITION,"

            'SQLstudnts &= "IIF(ISNULL(REMARKS),0,REMARKS) As REMARKS FROM tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER = '" & ComboADMNO.Text & "'"


            'Set the data adapter and fetch the records from the database using the select query
            'dtadpt2 = New OleDb.OleDbDataAdapter(SQLstudnts, conn)





            ' Use the data adapter to fill data in the dataset
            dtadpt2.Fill(dst2, "tblSTUDENTSNIDHAMU") 'Record source for first datagridview  'DataGridViewFirstStudentDetails'


            'Close the database after filling the datasets
            conn.Close()


            'bind the datagridview to the datasets 'dst2' 
            DataGridViewFirstStudentDetails.DataSource = dst2.Tables("tblSTUDENTSNIDHAMU")






            'Transfer the information below to the text boxes


            'Automatically populate repetetive data into the textboxes

            txtADMISSIONNUMBER.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("ADMISSIONNUMBER").Value.ToString
            txtNAMEOFSTUDENT.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("NAMEOFSTUDENT").Value.ToString
            txtGENDER.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("GENDER").Value.ToString
            txtKCPEMARKS.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("KCPEMARKS").Value
            txtKCPEGRADE.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("KCPEGRADE").Value.ToString
            txtFORMERSCHOOL.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("FORMERSCHOOL").Value.ToString
            txtDATEOFADMISSION.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("DATEOFADMISSION").Value.ToString



            'Make the above columns invisible on the datagridview

            DataGridViewFirstStudentDetails.Columns("ADMISSIONNUMBER").Visible = False
            DataGridViewFirstStudentDetails.Columns("NAMEOFSTUDENT").Visible = False
            DataGridViewFirstStudentDetails.Columns("GENDER").Visible = False
            DataGridViewFirstStudentDetails.Columns("KCPEMARKS").Visible = False
            DataGridViewFirstStudentDetails.Columns("KCPEGRADE").Visible = False
            DataGridViewFirstStudentDetails.Columns("FORMERSCHOOL").Visible = False
            DataGridViewFirstStudentDetails.Columns("DATEOFADMISSION").Visible = False







            ' Change the DataGridViewFirstStudentDetails AlternatingRowsDefaultCellStyle colours to Azure

            DataGridViewFirstStudentDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure


            Dim cb2 As New OleDb.OleDbCommandBuilder(dtadpt2)



            ' DataGridViewFirstStudentDetails.AutoResizeColumns()


            ' DataGridViewFirstStudentDetails.AutoResizeRows()



            'Hide the child's table datagridview columns: TypeOfOffense, OffenseCategory, Class, Stream to pave way for the respective combobox columns to be seen

            DataGridViewFirstStudentDetails.Columns("OFFENSECATEGORY").Visible = False
            DataGridViewFirstStudentDetails.Columns("TYPEOFOFFENSE").Visible = False
            DataGridViewFirstStudentDetails.Columns("STREAM").Visible = False
            DataGridViewFirstStudentDetails.Columns("CLASS").Visible = False
            DataGridViewFirstStudentDetails.Columns("DORMITORIES").Visible = False
            DataGridViewFirstStudentDetails.Columns("FAMILYSITUATION").Visible = False
            DataGridViewFirstStudentDetails.Columns("TERM").Visible = False


            'Work on the datagridview columns, formatting, widths sizes, locking, reordering etc

            ' After a student has been selected, re-order the datagridview controls appropriately:


            'DataGridViewFirstStudentDetails.Columns("comboOffenseCatgry").ReadOnly = True

            ' DataGridViewFirstStudentDetails.Columns("comboOffenseCatgry").DefaultCellStyle.ForeColor = Color.Black


            'Adjust column widths

            DataGridViewFirstStudentDetails.Columns("REMARKS").Width = 700
            DataGridViewFirstStudentDetails.Columns("TERM").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells




            'Lock non-editable columns

            ' DataGridViewFirstStudentDetails.Columns("NAMEOFSTUDENT").ReadOnly = True
            ' DataGridViewFirstStudentDetails.Columns("ADMISSIONNUMBER").ReadOnly = True
            ' DataGridViewFirstStudentDetails.Columns("GENDER").ReadOnly = True
            '  DataGridViewFirstStudentDetails.Columns("ID").ReadOnly = True




            'Now get the photo/picture saved in the database into the picture box control on a different form

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()

            'Before fetching a student photo from the database table 'tblSTUDENTSNIDHAMU', first handle the null photo situation so that it does not display
            'another student's photo in the picture box on the form by making that picture box invisible.

            Dim dstNullPhoto As New DataSet
            Dim dtadptNullPhoto As OleDb.OleDbDataAdapter


            'If null photo, make the picture box invisible

            'Fetch data first

            'clear the previous record before fetching new record 
            dstNullPhoto.Clear()


            'Set the data adapter and fetch data fro the database using select query
            dtadptNullPhoto = New OleDb.OleDbDataAdapter("SELECT STUDENTPHOTO FROM tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER ='" & ComboADMNO.Text & "'", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptNullPhoto.Fill(dstNullPhoto, "tblSTUDENTSNIDHAMU")


            If IsDBNull(dstNullPhoto.Tables("tblSTUDENTSNIDHAMU").Rows(0).Item("STUDENTPHOTO")) = True Then
                Me.PictureBoxStudentPhoto.Visible = False

                ' MessageBox.Show("Photo Missing for this Student.", "Missing Photo")

                'LblNullPhoto.ForeColor = Color.Red
                ' LblNullPhoto.Text = "Photo Missing"


            Else


                Dim command As New OleDbCommand("SELECT STUDENTPHOTO FROM tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER ='" & ComboADMNO.Text & "'", conn)
                command.Parameters.AddWithValue("@ADMISSIONNUMBER", ComboADMNO.Text)
                Dim pictureData As Byte() = DirectCast(command.ExecuteScalar(), Byte())

                conn.Close()
                command.Dispose()

                Dim stream As New IO.MemoryStream(pictureData)

                Me.PictureBoxStudentPhoto.Image = Image.FromStream(stream) 'See in this PictureBoxStudentPhoto you're showing the Image.
                '' NOTE: don't dispose stream!!

                Me.PictureBoxStudentPhoto.Visible = True
                'LblNullPhoto.Visible = False

            End If



            'KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK



            'Now fectch data to count the no. of mistakes of a student and show them in a message box as you fetch a student's record

            Dim dstOffensesCountByStudent As New DataSet
            Dim dtadptOffensesCountByStudent As OleDb.OleDbDataAdapter
            Dim CURRENTSTUDENTNOOFMISTAKES As Integer
            Dim dstDisciplined As New DataSet
            Dim dtadptDisciplined As OleDb.OleDbDataAdapter



            Dim dstPastOffensesCountByStudent As New DataSet
            Dim dtadptPastOffensesCountByStudent As OleDb.OleDbDataAdapter
            Dim PastSTUDENTNOOFMISTAKES As Integer

            Dim TOTALSTUDENTNOOFMISTAKES As Integer

            Dim JINALAMWANAFUNZI As String
            Dim NAMBARIYAUSAJILI As String


            'fetch data from the tblSTUDENTSNIDHAMU table

            'Current year's count of offences
            'clear the previous record before fetching new record 
            dstOffensesCountByStudent.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptOffensesCountByStudent = New OleDb.OleDbDataAdapter("SELECT NAMEOFSTUDENT, ADMISSIONNUMBER, COUNT(OFFENSECATEGORY) as CURRENTSTUDENTOFFENSECOUNT From tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER ='" & ComboADMNO.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' GROUP BY NAMEOFSTUDENT, ADMISSIONNUMBER", conn)

            dtadptOffensesCountByStudent.Fill(dstOffensesCountByStudent, "tblSTUDENTSNIDHAMU")
            ' Use the data adapter to fill data in the dataset




            ' Past years count of offences
            'clear the previous record before fetching new record 
            dstPastOffensesCountByStudent.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptPastOffensesCountByStudent = New OleDb.OleDbDataAdapter("SELECT NAMEOFSTUDENT, ADMISSIONNUMBER, COUNT(OFFENSECATEGORY) as PASTSTUDENTOFFENSECOUNT From tblSTUDENTSNIDHAMUArchive WHERE ADMISSIONNUMBER ='" & ComboADMNO.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' GROUP BY NAMEOFSTUDENT, ADMISSIONNUMBER", conn)

            dtadptPastOffensesCountByStudent.Fill(dstPastOffensesCountByStudent, "tblSTUDENTSNIDHAMUArchive")
            ' Use the data adapter to fill data in the dataset



            dstDisciplined.Clear()

            'Set the data adapter and fetch data from the database using select query
            dtadptDisciplined = New OleDb.OleDbDataAdapter("SELECT OFFENSECATEGORY From tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER ='" & ComboADMNO.Text & "' AND OFFENSECATEGORY = 'DISCIPLINED'", conn)

            dtadptDisciplined.Fill(dstDisciplined, "tblSTUDENTSNIDHAMU")
            ' Use the data adapter to fill data in the dataset



            ' conn.Close()



            JINALAMWANAFUNZI = dstOffensesCountByStudent.Tables("tblSTUDENTSNIDHAMU").Rows(0).Item("NAMEOFSTUDENT").ToString
            NAMBARIYAUSAJILI = dstOffensesCountByStudent.Tables("tblSTUDENTSNIDHAMU").Rows(0).Item("ADMISSIONNUMBER").ToString



            '  If dstDisciplined.Tables("tblSTUDENTSNIDHAMU").Rows(0).Item("OFFENSECATEGORY") = "DISCIPLINED" Then

            'MessageBox.Show(JINALAMWANAFUNZI & "," & " " & "ADMNO: " & NAMBARIYAUSAJILI & "  has so far committed:  " & Val(PastSTUDENTNOOFMISTAKES) & "  Offense(s) since joined this school.", "Number Of Offenses Committed", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' End If





            If dstOffensesCountByStudent.Tables("tblSTUDENTSNIDHAMU").Rows.Count > 0 Then

                CURRENTSTUDENTNOOFMISTAKES = dstOffensesCountByStudent.Tables("tblSTUDENTSNIDHAMU").Rows(0).Item("CURRENTSTUDENTOFFENSECOUNT")

            Else

                CURRENTSTUDENTNOOFMISTAKES = 0

            End If


            If dstPastOffensesCountByStudent.Tables("tblSTUDENTSNIDHAMUArchive").Rows.Count > 0 Then

                PastSTUDENTNOOFMISTAKES = dstPastOffensesCountByStudent.Tables("tblSTUDENTSNIDHAMUArchive").Rows(0).Item("PASTSTUDENTOFFENSECOUNT")

            Else
                PastSTUDENTNOOFMISTAKES = 0

            End If



            TOTALSTUDENTNOOFMISTAKES = Val(CURRENTSTUDENTNOOFMISTAKES) + Val(PastSTUDENTNOOFMISTAKES)


            MessageBox.Show(JINALAMWANAFUNZI & "," & " " & "ADMNO: " & NAMBARIYAUSAJILI & "  has so far committed:  " & TOTALSTUDENTNOOFMISTAKES & "  Offense(s) since joined this school.", "Number Of Offenses Committed", MessageBoxButtons.OK, MessageBoxIcon.Information)





            'If no current offences then highlight past offences

            '  If IsDBNull(dstOffensesCountByStudent.Tables("tblSTUDENTSNIDHAMU").Rows(0).Item("CURRENTSTUDENTNOOFMISTAKES")) = True Then

            ' MessageBox.Show(JINALAMWANAFUNZI & "'s" & " " & "Current year's offences are: " & CURRENTSTUDENTNOOFMISTAKES & "  and past years' offences are:  " & PastSTUDENTNOOFMISTAKES & ".", "Number Of Offenses Committed", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' End If




        Catch ex As Exception
            ' Label1.ForeColor = Color.Red
            ' Label1.Text = "The Given ADMISSIONNUMBER has not been found in the database"
            Return




            ' Catch ex As Exception

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

    Private Sub txtOFFENSECOMMITED_TextChanged(sender As Object, e As EventArgs) Handles txtOFFENSECOMMITED.TextChanged

        Try
            'To type some text in the textbox and it is concurrently sent to the datagridview Offensecommited column either use:

            Dim i As Integer = DataGridViewFirstStudentDetails.CurrentRow.Index
            DataGridViewFirstStudentDetails.Rows(i).Cells("OFFENSECOMMITED").Value = txtOFFENSECOMMITED.Text

            'OR

            'DataGridViewFirstStudentDetails.CurrentRow.Cells("OFFENSECOMMITED").Value = txtOFFENSECOMMITED.Text



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub txtOFFENSECOMMITED_DoubleClick(sender As Object, e As EventArgs) Handles txtOFFENSECOMMITED.DoubleClick
        Try
            'Clear the textbox
            ' txtOFFENSECOMMITED.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub frmNIDHAMUMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Try


            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()



            'This saves data in the entire database table tblSTUDENTSNIDHAMU

            'For single user updating, just use the command builder to overwrite the changes. This approach is called 'Last in Win"

            Dim cb2 As New OleDb.OleDbCommandBuilder(dtadpt2)

            cb2.ConflictOption = ConflictOption.OverwriteChanges


            dtadpt2.Update(dst2, "tblSTUDENTSNIDHAMU")


            conn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub DataGridViewFirstStudentDetails_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridViewFirstStudentDetails.CellBeginEdit
        Try

            'Automatically populate repetetive data

            DataGridViewFirstStudentDetails.CurrentRow.Cells("ADMISSIONNUMBER").Value = DataGridViewFirstStudentDetails.Rows(0).Cells("ADMISSIONNUMBER").Value.ToString

            DataGridViewFirstStudentDetails.CurrentRow.Cells("NAMEOFSTUDENT").Value = DataGridViewFirstStudentDetails.Rows(0).Cells("NAMEOFSTUDENT").Value.ToString
            DataGridViewFirstStudentDetails.CurrentRow.Cells("GENDER").Value = DataGridViewFirstStudentDetails.Rows(0).Cells("GENDER").Value.ToString

            DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEMARKS").Value = DataGridViewFirstStudentDetails.Rows(0).Cells("KCPEMARKS").Value
            DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = DataGridViewFirstStudentDetails.Rows(0).Cells("KCPEGRADE").Value.ToString
            DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = DataGridViewFirstStudentDetails.Rows(0).Cells("KCPEPOINTS").Value
            ' DataGridViewFirstStudentDetails.CurrentRow.Cells("STUDENTVAP").Value = DataGridViewFirstStudentDetails.Rows(0).Cells("STUDENTVAP").Value
            DataGridViewFirstStudentDetails.CurrentRow.Cells("FORMERSCHOOL").Value = DataGridViewFirstStudentDetails.Rows(0).Cells("FORMERSCHOOL").Value.ToString
            DataGridViewFirstStudentDetails.CurrentRow.Cells("DATEOFADMISSION").Value = DataGridViewFirstStudentDetails.Rows(0).Cells("DATEOFADMISSION").Value
            DataGridViewFirstStudentDetails.CurrentRow.Cells("CLASS").Value = DataGridViewFirstStudentDetails.Rows(0).Cells("CLASS").Value.ToString
            DataGridViewFirstStudentDetails.CurrentRow.Cells("STREAM").Value = DataGridViewFirstStudentDetails.Rows(0).Cells("STREAM").Value.ToString
            DataGridViewFirstStudentDetails.CurrentRow.Cells("DORMITORIES").Value = DataGridViewFirstStudentDetails.Rows(0).Cells("DORMITORIES").Value.ToString


            If DataGridViewFirstStudentDetails.CurrentRow.IsNewRow Then
                'Assign 'ACADEMICYEAR field' current year
                DataGridViewFirstStudentDetails.CurrentRow.Cells("ACADEMICYEAR").Value = Date.Now.Year

            End If

            DataGridViewFirstStudentDetails.CurrentRow.Cells("ACADEMICYEAR").ReadOnly = True


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub DataGridViewFirstStudentDetails_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewFirstStudentDetails.CellValueChanged
        ' Try
        '  If DataGridViewFirstStudentDetails.CurrentRow.Cells("CHKDIDSTUDENTRETURN").Value = True Then
        ' DataGridViewFirstStudentDetails.CurrentRow.Cells("STATEOFAFFAIRS").Value = "Student Returned To School"

        'DataGridViewFirstStudentDetails.Columns("STATEOFAFFAIRS").DefaultCellStyle.ForeColor = Color.Blue

        ' ElseIf DataGridViewFirstStudentDetails.CurrentRow.Cells("CHKDIDSTUDENTRETURN").Value = False Then
        ' DataGridViewFirstStudentDetails.CurrentRow.Cells("STATEOFAFFAIRS").Value = "Student Not Yet Back To School"

        'DataGridViewFirstStudentDetails.Columns("STATEOFAFFAIRS").DefaultCellStyle.ForeColor = Color.Red

        ' End If




        ' If DataGridViewFirstStudentDetails.CurrentRow.Cells("CKSTUDENTDIDPUNISHMENT").Value = True Then
        'DataGridViewFirstStudentDetails.CurrentRow.Cells("PUNSHMENTSTATE").Value = "Student Did Punishment"

        'DataGridViewFirstStudentDetails.Columns("PUNSHMENTSTATE").DefaultCellStyle.ForeColor = Color.Blue

        'ElseIf DataGridViewFirstStudentDetails.CurrentRow.Cells("CKSTUDENTDIDPUNISHMENT").Value = False Then
        'DataGridViewFirstStudentDetails.CurrentRow.Cells("PUNSHMENTSTATE").Value = "Student Not Done Punishment"

        'DataGridViewFirstStudentDetails.Columns("PUNSHMENTSTATE").DefaultCellStyle.ForeColor = Color.Red

        ' End If



        ' Catch ex As Exception
        'MessageBox.Show(ex.Message)
        ' End Try
    End Sub


    Private Sub DataGridViewFirstStudentDetails_MouseMove(sender As Object, e As MouseEventArgs) Handles DataGridViewFirstStudentDetails.MouseMove
        Try




        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub DataGridViewFirstStudentDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewFirstStudentDetails.CellClick
        Try
            'When you click the cell content, it should be displayed in the textbox either use:

            Dim i As Integer = DataGridViewFirstStudentDetails.CurrentRow.Index
            txtOFFENSECOMMITED.Text = DataGridViewFirstStudentDetails.Rows(i).Cells("OFFENSECOMMITED").Value.ToString

            'OR

            ' txtOFFENSECOMMITED.Text = DataGridViewFirstStudentDetails.CurrentRow.Cells("OFFENSECOMMITED").Value.ToString


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnOpenStatisticalAnalysis_Click(sender As Object, e As EventArgs) Handles BtnOpenStatisticalAnalysis.Click
        Try

            frmStatisticalAnalysis.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub DataGridViewFirstStudentDetails_MouseLeave(sender As Object, e As EventArgs) Handles DataGridViewFirstStudentDetails.MouseLeave
        Try

            'For single user updating, just use the command builder to overwrite the changes. This approach is called 'Last in Win"

            ' Dim cb2 As New OleDb.OleDbCommandBuilder(dtadpt2)
            'cb2.ConflictOption = ConflictOption.OverwriteChanges


            ' dtadpt2.Update(dst2, "tblSTUDENTSNIDHAMU")


            ' MsgBox("Record(s) Successfully Saved!", MsgBoxStyle.OkOnly, "")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub BtnSearchByName_Click(sender As Object, e As EventArgs) Handles BtnSearchByName.Click
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()

            Dim dstNameToSearch As New DataSet()
            Dim dtadptNameToSearch

            'clear the previous record before fetching new record and bind it to the datagridview
            dstNameToSearch.Clear()


            'Set the data adapter and fetch data fro the database using select query

            '% wild card works in ACE connection

            dtadptNameToSearch = New OleDb.OleDbDataAdapter("Select DISTINCT NAMEOFSTUDENT, ADMISSIONNUMBER FROM tblSTUDENTSNIDHAMU WHERE NAMEOFSTUDENT LIKE '%" & txtNameToSearch.Text & "%' ORDER BY NAMEOFSTUDENT ASC", conn)

            '* wild card works in jet 4.0 connection

            ' dtadptNameToSearch = New OleDb.OleDbDataAdapter("Select DISTINCT NAMEOFSTUDENT, ADMISSIONNUMBER FROM tblSTUDENTSNIDHAMU WHERE NAMEOFSTUDENT LIKE '*" & txtNameToSearch.Text & "*' ORDER BY NAMEOFSTUDENT ASC", conn)


            ' Use the data adapter to fill data in the dataset
            dtadptNameToSearch.Fill(dstNameToSearch, "tblSTUDENTSNIDHAMU")


            'Close the connection after filling the dataset
            conn.Close()

            'Fill the datagridview with data from the dataset

            dgvSearchName.DataSource = dstNameToSearch.Tables("tblSTUDENTSNIDHAMU")


            'Column headers

            dgvSearchName.Columns("NAMEOFSTUDENT").HeaderText = "STUDENT NAME"
            dgvSearchName.Columns("ADMISSIONNUMBER").HeaderText = "ADMISSION NO."



            'Width
            dgvSearchName.Columns("NAMEOFSTUDENT").Width = 180
            dgvSearchName.Columns("ADMISSIONNUMBER").Width = 120



            'Lock non editable fields
            dgvSearchName.Columns("NAMEOFSTUDENT").ReadOnly = True
            dgvSearchName.Columns("ADMISSIONNUMBER").ReadOnly = True



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub dgvSearchName_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchName.CellDoubleClick
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()

            'clear the previous record before fetching new record and bind it to the datagridview
            dst2.Clear()


            Dim SQLstudnts As String

            SQLstudnts = "Select ID, DATEOFOCCURENCE, TERM, NAMEOFSTUDENT, ADMISSIONNUMBER, GENDER, CLASS, STREAM, DORMITORIES, FORMERSCHOOL, DATEOFADMISSION, KCPEMARKS, KCPEGRADE, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASSPOSITION, STREAMPOSITION, OFFENSECOMMITED,"

            SQLstudnts &= " FEESBALANCE, FEEPAYER, TYPEOFOFFENSE, OFFENSECATEGORY, EXPECTEDDATEOFRETURN, DIDSTUDENTRETURN, ACTUALDATEOFRETURN, STATEOFAFFAIRS, TYPEOFPUNISHMENT, DIDPUNSHMENT, PUNSHMENTSTATE, DATECOMPLETEDPUNSHMENT, "

            SQLstudnts &= "PUNSHEDBY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER, COUNTY, SUBCOUNTY, RESIDENCEESTATE, GUIDED, GUIDEDDATE, DISCONTINUED, RESPONSIBILITY, REMARKS, KCPEPOINTS, ACADEMICYEAR FROM tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER = '" & dgvSearchName.CurrentRow.Cells("ADMISSIONNUMBER").Value & "' ORDER BY DATEOFOCCURENCE ASC"


            'Set the data adapter and fetch the records from the database using the select query
            dtadpt2 = New OleDb.OleDbDataAdapter(SQLstudnts, conn)



            'Below query for handling null values in Access database

            '  SQLstudnts &= "IIF(ISNULL(NAMEOFSTUDENT),0,NAMEOFSTUDENT) As NAMEOFSTUDENT, "

            ' SQLstudnts &= "IIF(ISNULL(ADMISSIONNUMBER),0,ADMISSIONNUMBER) As ADMISSIONNUMBER,"

            ' SQLstudnts &= "IIF(ISNULL(GENDER),0,GENDER) As GENDER,"

            'SQLstudnts &= "IIf(ISNULL(Class), 0, Class) As Class,"
            ' SQLstudnts &= "Class,"

            ' SQLstudnts &= "IIf(ISNULL(STREAM), 0, STREAM) As STREAM,"
            ' SQLstudnts &= "STREAM,"

            ' SQLstudnts &= "IIF(ISNULL(OFFENSECOMMITED),0,OFFENSECOMMITED) As OFFENSECOMMITED,"

            ' SQLstudnts &= "IIf(ISNULL(TYPEOFOFFENSE), 0, TYPEOFOFFENSE) As TYPEOFOFFENSE,"

            ' SQLstudnts &= "TYPEOFOFFENSE,"

            'SQLstudnts &= "IIf(ISNULL(OFFENSECATEGORY), 0, OFFENSECATEGORY) As OFFENSECATEGORY,"
            ' SQLstudnts &= "OFFENSECATEGORY,"


            'SQLstudnts &= "IIF(ISNULL(FORMERSCHOOL),0,FORMERSCHOOL) As FORMERSCHOOL,"

            ' SQLstudnts &= "IIF(ISNULL(FEESBALANCE),0,FEESBALANCE) As FEESBALANCE,"

            ' SQLstudnts &= "IIF(ISNULL(FEEPAYER),0,FEEPAYER) As FEEPAYER,"


            ' SQLstudnts &= "IIF(ISNULL(EXPECTEDDATEOFRETURN),0,EXPECTEDDATEOFRETURN) As EXPECTEDDATEOFRETURN,"

            ' SQLstudnts &= "IIF(ISNULL(ACTUALDATEOFRETURN),0,ACTUALDATEOFRETURN) As ACTUALDATEOFRETURN,"

            'SQLstudnts &= "IIF(ISNULL(DIDSTUDENTRETURN),0,DIDSTUDENTRETURN) As DIDSTUDENTRETURN,"

            ' SQLstudnts &= "DIDSTUDENTRETURN,"

            ' SQLstudnts &= "IIF(ISNULL(STATEOFAFFAIRS),0,STATEOFAFFAIRS) As STATEOFAFFAIRS,"



            'SQLstudnts &= "IIF(ISNULL(DIDPUNSHMENT),0,DIDPUNSHMENT) As DIDPUNSHMENT,"

            ' SQLstudnts &= "DIDPUNSHMENT,"



            ' SQLstudnts &= "IIF(ISNULL(PUNSHMENTSTATE),0,PUNSHMENTSTATE) As PUNSHMENTSTATE,"


            ' SQLstudnts &= "IIF(ISNULL(DATECOMPLETEDPUNSHMENT),0,DATECOMPLETEDPUNSHMENT) As DATECOMPLETEDPUNSHMENT,"

            ' SQLstudnts &= "IIF(ISNULL(PUNSHEDBY),0,PUNSHEDBY) As PUNSHEDBY,"


            'SQLstudnts &= "IIF(ISNULL(STUDENTPHOTO),0,STUDENTPHOTO) As STUDENTPHOTO,"

            ' SQLstudnts &= "STUDENTPHOTO,"


            ' SQLstudnts &= "IIF(ISNULL(FAMILYSITUATION),0,FAMILYSITUATION) As FAMILYSITUATION,"
            'SQLstudnts &= "FAMILYSITUATION,"


            'SQLstudnts &= "IIF(ISNULL(NAMEOFPARENT),0,NAMEOFPARENT) As NAMEOFPARENT,"




            'SQLstudnts &= "IIF(ISNULL(PARENTPHONENUMBER),0,PARENTPHONENUMBER) As PARENTPHONENUMBER,"

            ' SQLstudnts &= "IIF(ISNULL(COUNTY),0,COUNTY) As COUNTY,"

            'SQLstudnts &= "IIF(ISNULL(SUBCOUNTY),0,SUBCOUNTY) As SUBCOUNTY,"

            'SQLstudnts &= "IIF(ISNULL(RESIDENCEESTATE),0,RESIDENCEESTATE) As RESIDENCEESTATE,"

            ' SQLstudnts &= "IIF(ISNULL(KCPEMARKS),0,KCPEMARKS) As KCPEMARKS,"

            '  SQLstudnts &= "IIF(ISNULL(KCPEGRADE),0,KCPEGRADE) As KCPEGRADE,"

            '  SQLstudnts &= "IIF(ISNULL(CURRENTMARKS),0,CURRENTMARKS) As CURRENTMARKS,"

            '  SQLstudnts &= "IIF(ISNULL(CURRENTGRADE),0,CURRENTGRADE) As CURRENTGRADE,"

            ' SQLstudnts &= "IIF(ISNULL(STUDENTVAP),0,STUDENTVAP) As STUDENTVAP,"

            ' SQLstudnts &= "IIF(ISNULL(CLASSPOSITION),0,CLASSPOSITION) As CLASSPOSITION,"

            ' SQLstudnts &= "IIF(ISNULL(STREAMPOSITION),0,STREAMPOSITION) As STREAMPOSITION,"

            'SQLstudnts &= "IIF(ISNULL(REMARKS),0,REMARKS) As REMARKS FROM tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER = '" & ComboADMNO.Text & "'"


            'Set the data adapter and fetch the records from the database using the select query
            'dtadpt2 = New OleDb.OleDbDataAdapter(SQLstudnts, conn)





            ' Use the data adapter to fill data in the dataset
            dtadpt2.Fill(dst2, "tblSTUDENTSNIDHAMU") 'Record source for first datagridview  'DataGridViewFirstStudentDetails'


            'Close the database after filling the datasets
            conn.Close()



            'bind the datagridview to the datasets 'dst2' 
            DataGridViewFirstStudentDetails.DataSource = dst2.Tables("tblSTUDENTSNIDHAMU")


            'Transfer the information below to the text boxes


            'Automatically populate repetetive data into the textboxes

            txtADMISSIONNUMBER.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("ADMISSIONNUMBER").Value.ToString
            txtNAMEOFSTUDENT.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("NAMEOFSTUDENT").Value.ToString
            txtGENDER.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("GENDER").Value.ToString
            txtKCPEMARKS.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("KCPEMARKS").Value
            txtKCPEGRADE.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("KCPEGRADE").Value.ToString
            txtFORMERSCHOOL.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("FORMERSCHOOL").Value.ToString
            txtDATEOFADMISSION.Text = DataGridViewFirstStudentDetails.Rows(0).Cells("DATEOFADMISSION").Value.ToString



            'Make the above columns invisible on the datagridview

            DataGridViewFirstStudentDetails.Columns("ADMISSIONNUMBER").Visible = False
            DataGridViewFirstStudentDetails.Columns("NAMEOFSTUDENT").Visible = False
            DataGridViewFirstStudentDetails.Columns("GENDER").Visible = False
            DataGridViewFirstStudentDetails.Columns("KCPEMARKS").Visible = False
            DataGridViewFirstStudentDetails.Columns("KCPEGRADE").Visible = False
            DataGridViewFirstStudentDetails.Columns("FORMERSCHOOL").Visible = False
            DataGridViewFirstStudentDetails.Columns("DATEOFADMISSION").Visible = False






            Dim cb2 As New OleDb.OleDbCommandBuilder(dtadpt2)



            ' DataGridViewFirstStudentDetails.AutoResizeColumns()


            ' DataGridViewFirstStudentDetails.AutoResizeRows()



            'Hide the child's table datagridview columns: TypeOfOffense, OffenseCategory, Class, Stream to pave way for the respective combobox columns to be seen

            DataGridViewFirstStudentDetails.Columns("OFFENSECATEGORY").Visible = False
            DataGridViewFirstStudentDetails.Columns("TYPEOFOFFENSE").Visible = False
            DataGridViewFirstStudentDetails.Columns("STREAM").Visible = False
            DataGridViewFirstStudentDetails.Columns("CLASS").Visible = False
            DataGridViewFirstStudentDetails.Columns("DORMITORIES").Visible = False
            DataGridViewFirstStudentDetails.Columns("FAMILYSITUATION").Visible = False
            DataGridViewFirstStudentDetails.Columns("TERM").Visible = False


            'Work on the datagridview columns, formatting, widths sizes, locking, reordering etc

            ' After a student has been selected, re-order the datagridview controls appropriately:


            'DataGridViewFirstStudentDetails.Columns("comboOffenseCatgry").ReadOnly = True

            ' DataGridViewFirstStudentDetails.Columns("comboOffenseCatgry").DefaultCellStyle.ForeColor = Color.Black


            'Adjust column widths

            DataGridViewFirstStudentDetails.Columns("REMARKS").Width = 700
            DataGridViewFirstStudentDetails.Columns("TERM").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells



            '.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


            ' DataGridViewFirstStudentDetails.Columns("PUNSHMENTSTATE").Width = 250

            ' DataGridViewFirstStudentDetails.Columns("KCPEMARKS").Width = 50
            '  DataGridViewFirstStudentDetails.Columns("KCPEGRADE").Width = 20
            '  DataGridViewFirstStudentDetails.Columns("CURRENTMARKS").Width = 50
            '  DataGridViewFirstStudentDetails.Columns("CURRENTPOINTS").Width = 20
            '  DataGridViewFirstStudentDetails.Columns("CURRENTGRADE").Width = 20
            '  DataGridViewFirstStudentDetails.Columns("STUDENTVAP").Width = 50
            '  DataGridViewFirstStudentDetails.Columns("CLASSPOSITION").Width = 20
            '  DataGridViewFirstStudentDetails.Columns("STREAMPOSITION").Width = 20



            'Lock non-editable columns

            ' DataGridViewFirstStudentDetails.Columns("NAMEOFSTUDENT").ReadOnly = True
            '  DataGridViewFirstStudentDetails.Columns("ADMISSIONNUMBER").ReadOnly = True
            '  DataGridViewFirstStudentDetails.Columns("GENDER").ReadOnly = True
            '  DataGridViewFirstStudentDetails.Columns("ID").ReadOnly = True
            '  DataGridViewFirstStudentDetails.Columns("KCPEMARKS").ReadOnly = True
            '  DataGridViewFirstStudentDetails.Columns("KCPEGRADE").ReadOnly = True


            'Now get the photo/picture saved in the database into the picture box control on a different form

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()

            'Before fetching a student photo from the database table 'tblSTUDENTSNIDHAMU', first handle the null photo situation so that it does not display
            'another student's photo in the picture box on the form by making that picture box invisible.

            Dim dstNullPhoto As New DataSet
            Dim dtadptNullPhoto As OleDb.OleDbDataAdapter


            'If null photo, make the picture box invisible

            'Fetch data first

            'clear the previous record before fetching new record 
            dstNullPhoto.Clear()


            'Set the data adapter and fetch data fro the database using select query
            dtadptNullPhoto = New OleDb.OleDbDataAdapter("SELECT STUDENTPHOTO FROM tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER ='" & dgvSearchName.CurrentRow.Cells("ADMISSIONNUMBER").Value & "'", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptNullPhoto.Fill(dstNullPhoto, "tblSTUDENTSNIDHAMU")


            If IsDBNull(dstNullPhoto.Tables("tblSTUDENTSNIDHAMU").Rows(0).Item("STUDENTPHOTO")) = True Then
                Me.PictureBoxStudentPhoto.Visible = False

                '  MessageBox.Show("Photo Missing for this Student.", "Missing Photo")

                'LblNullPhoto.ForeColor = Color.Red
                ' LblNullPhoto.Text = "Photo Missing"


            Else


                Dim command As New OleDbCommand("SELECT STUDENTPHOTO FROM tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER ='" & dgvSearchName.CurrentRow.Cells("ADMISSIONNUMBER").Value & "'", conn)
                command.Parameters.AddWithValue("@ADMISSIONNUMBER", ComboADMNO.Text)
                Dim pictureData As Byte() = DirectCast(command.ExecuteScalar(), Byte())

                conn.Close()
                command.Dispose()

                Dim stream As New IO.MemoryStream(pictureData)

                Me.PictureBoxStudentPhoto.Image = Image.FromStream(stream) 'See in this PictureBoxStudentPhoto you're showing the Image.
                '' NOTE: don't dispose stream!!

                Me.PictureBoxStudentPhoto.Visible = True
                'LblNullPhoto.Visible = False

            End If



            'KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK



            'Now fectch data to count the no. of mistakes of a student and show them in a message box as you fetch a student's record

            Dim dstOffensesCountByStudent As New DataSet
            Dim dtadptOffensesCountByStudent As OleDb.OleDbDataAdapter
            Dim CURRENTSTUDENTNOOFMISTAKES As Integer

            Dim dstPastOffensesCountByStudent As New DataSet
            Dim dtadptPastOffensesCountByStudent As OleDb.OleDbDataAdapter
            Dim PastSTUDENTNOOFMISTAKES As Integer

            Dim TOTALSTUDENTNOOFMISTAKES As Integer

            Dim JINALAMWANAFUNZI As String
            Dim NAMBARIYAUSAJILI As String


            'fetch data from the tblSTUDENTSNIDHAMU table

            'Current year's count of offences
            'clear the previous record before fetching new record 
            dstOffensesCountByStudent.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptOffensesCountByStudent = New OleDb.OleDbDataAdapter("SELECT NAMEOFSTUDENT, ADMISSIONNUMBER, COUNT(OFFENSECATEGORY) as CURRENTSTUDENTOFFENSECOUNT From tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER = '" & dgvSearchName.CurrentRow.Cells("ADMISSIONNUMBER").Value & "' AND OFFENSECATEGORY <> 'DISCIPLINED' GROUP BY NAMEOFSTUDENT, ADMISSIONNUMBER", conn)

            dtadptOffensesCountByStudent.Fill(dstOffensesCountByStudent, "tblSTUDENTSNIDHAMU")
            ' Use the data adapter to fill data in the dataset




            ' Past years count of offences
            'clear the previous record before fetching new record 
            dstPastOffensesCountByStudent.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptPastOffensesCountByStudent = New OleDb.OleDbDataAdapter("SELECT NAMEOFSTUDENT, ADMISSIONNUMBER, COUNT(OFFENSECATEGORY) as PASTSTUDENTOFFENSECOUNT From tblSTUDENTSNIDHAMUArchive WHERE ADMISSIONNUMBER = '" & dgvSearchName.CurrentRow.Cells("ADMISSIONNUMBER").Value & "' AND OFFENSECATEGORY <> 'DISCIPLINED' GROUP BY NAMEOFSTUDENT, ADMISSIONNUMBER", conn)

            dtadptPastOffensesCountByStudent.Fill(dstPastOffensesCountByStudent, "tblSTUDENTSNIDHAMUArchive")
            ' Use the data adapter to fill data in the dataset

            ' conn.Close()



            JINALAMWANAFUNZI = dstOffensesCountByStudent.Tables("tblSTUDENTSNIDHAMU").Rows(0).Item("NAMEOFSTUDENT").ToString
            NAMBARIYAUSAJILI = dstOffensesCountByStudent.Tables("tblSTUDENTSNIDHAMU").Rows(0).Item("ADMISSIONNUMBER").ToString



            If dstOffensesCountByStudent.Tables("tblSTUDENTSNIDHAMU").Rows.Count > 0 Then

                CURRENTSTUDENTNOOFMISTAKES = dstOffensesCountByStudent.Tables("tblSTUDENTSNIDHAMU").Rows(0).Item("CURRENTSTUDENTOFFENSECOUNT")

            Else

                CURRENTSTUDENTNOOFMISTAKES = 0

            End If


            If dstPastOffensesCountByStudent.Tables("tblSTUDENTSNIDHAMUArchive").Rows.Count > 0 Then

                PastSTUDENTNOOFMISTAKES = dstPastOffensesCountByStudent.Tables("tblSTUDENTSNIDHAMUArchive").Rows(0).Item("PASTSTUDENTOFFENSECOUNT")

            Else
                PastSTUDENTNOOFMISTAKES = 0

            End If



            TOTALSTUDENTNOOFMISTAKES = Val(CURRENTSTUDENTNOOFMISTAKES) + Val(PastSTUDENTNOOFMISTAKES)


            MessageBox.Show(JINALAMWANAFUNZI & "," & " " & "ADMNO: " & NAMBARIYAUSAJILI & "  has so far committed:  " & TOTALSTUDENTNOOFMISTAKES & "  Offense(s) since joined this school.", "Number Of Offenses Committed", MessageBoxButtons.OK, MessageBoxIcon.Information)





            'If no current offences then highlight past offences

            '  If IsDBNull(dstOffensesCountByStudent.Tables("tblSTUDENTSNIDHAMU").Rows(0).Item("CURRENTSTUDENTNOOFMISTAKES")) = True Then

            ' MessageBox.Show(JINALAMWANAFUNZI & "'s" & " " & "Current year's offences are: " & CURRENTSTUDENTNOOFMISTAKES & "  and past years' offences are:  " & PastSTUDENTNOOFMISTAKES & ".", "Number Of Offenses Committed", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' End If




        Catch ex As Exception
            ' Label1.ForeColor = Color.Red
            ' Label1.Text = "The Given ADMISSIONNUMBER has not been found in the database"
            Return



            ' Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub txtNameToSearch_Click(sender As Object, e As EventArgs) Handles txtNameToSearch.Click

        Try
            txtNameToSearch.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub DataGridViewFirstStudentDetails_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewFirstStudentDetails.RowLeave
        Try

            Dim KCPEMIDMARK As Single
            'Dim CURRENTGRADE As String


            If IsDBNull(DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEMARKS").Value) = True Then
                DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEMARKS").Value = 0
            End If


            If IsDBNull(DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value) = True Then
                DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 0
            End If


            KCPEMIDMARK = Val(DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEMARKS").Value) / 5
            KCPEMIDMARK = FormatNumber(Val(KCPEMIDMARK), 0)

            Select Case KCPEMIDMARK

                Case 0

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "X"
                    txtKCPEGRADE.Text = "X"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 0



                Case 1 To 24

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "E"
                    txtKCPEGRADE.Text = "E"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 1

                Case 25 To 29

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "D-"
                    txtKCPEGRADE.Text = "D-"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 2

                Case 30 To 34

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "D"
                    txtKCPEGRADE.Text = "D"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 3

                Case 35 To 39

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "D+"
                    txtKCPEGRADE.Text = "D+"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 4

                Case 40 To 44

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "C-"
                    txtKCPEGRADE.Text = "C-"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 5

                Case 45 To 54

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "C"
                    txtKCPEGRADE.Text = "C"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 6

                Case 55 To 59

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "C+"
                    txtKCPEGRADE.Text = "C+"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 7

                Case 60 To 64

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "B-"
                    txtKCPEGRADE.Text = "B-"


                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 8

                Case 65 To 69

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "B"
                    txtKCPEGRADE.Text = "B"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 9

                Case 70 To 74

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "B+"
                    txtKCPEGRADE.Text = "B+"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 10

                Case 75 To 79

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "A-"
                    txtKCPEGRADE.Text = "A-"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 11

                Case 80 To 100

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "A"
                    txtKCPEGRADE.Text = "A"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 12

            End Select




            'Calculate points from current grades



            If IsDBNull(DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value) = True Then
                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 0
            End If


            If IsDBNull(DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value) = True Then
                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "-"
            End If



            If DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "A" Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 12


            ElseIf DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "A-" Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 11


            ElseIf DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "B+" Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 10


            ElseIf DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "B" Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 9


            ElseIf DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "B-" Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 8


            ElseIf DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "C+" Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 7


            ElseIf DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "C" Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 6


            ElseIf DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "C-" Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 5


            ElseIf DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "D+" Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 4


            ElseIf DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "D" Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 3


            ElseIf DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "D-" Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 2


            ElseIf DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "E" Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 1


            ElseIf DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "X" Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 0


            ElseIf DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "-" Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 0


            End If




            'Calculate Student VAP

            DataGridViewFirstStudentDetails.CurrentRow.Cells("STUDENTVAP").Value = DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value - DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value

            FormatNumber(DataGridViewFirstStudentDetails.CurrentRow.Cells("STUDENTVAP").Value, 2)

            'set VAP to 0 if no current points/current grade

            If DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 0 Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("STUDENTVAP").Value = 0

            End If


            If DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 0 Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("STUDENTVAP").Value = 0

            End If



            'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX



            'For single user updating, just use the command builder to overwrite the changes. This approach is called 'Last in Win"

            'Dim cb2 As New OleDb.OleDbCommandBuilder(dtadpt2)
            ' cb2.ConflictOption = ConflictOption.OverwriteChanges


            ' dtadpt2.Update(dst2, "tblSTUDENTSNIDHAMU")


            'NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN

            'Updating in a multiple user environment, use this 'Optimistic approach though not yet completed.

            '  Dim updateCommand As New OleDb.OleDbCommand("Update tblSTUDENTSNIDHAMU Set [ADMISSIONNUMBER]=@ADMISSIONNUMBER, [TYPEOFOFFENSE]= @TYPEOFOFFENSE, [OFFENSECATEGORY] =@OFFENSECATEGORY, [NAMEOFSTUDENT] =@NAMEOFSTUDENT WHERE [ID]= @ID", conn) ' and [ADMISSIONNUMBER] =@ADMISSIONNUMBER and [GENDER] =@GENDER and [Field 6] =" &
            '  "@Field6 and  [Field 7] =@Field7 and  [Field 8] =@Field8 and  [Field 9] =@Field9 and  [Field 10] =@Field10 and  [Field 11] =@Field11 and  [Field 12] = " &
            '  "@Field12 and  [Field 13] =@Field13 and  [Field 14] =@Field14 and  [Field 15] =@Field15 and  [Field 16] =@Field16 and  [Field 17] =@Field17", conn)

            ' updateCommand.Parameters.Add("@ADMISSIONNUMBER", OleDb.OleDbType.VarChar, 15, "ADMISSIONNUMBER")
            ' updateCommand.Parameters.Add("@DATEOFOCCURENCE", OleDb.OleDbType.VarChar, 50, "DATEOFOCCURENCE")
            ' updateCommand.Parameters.Add("@Field3", OleDb.OleDbType.VarChar, 50, "Field 3")


            ' updateCommand.Parameters.Add("@TYPEOFOFFENSE", OleDb.OleDbType.VarChar, 70, "TYPEOFOFFENSE")

            ' updateCommand.Parameters.Add("@OFFENSECATEGORY", OleDb.OleDbType.VarChar, 70, "OFFENSECATEGORY")

            ' updateCommand.Parameters.Add("@NAMEOFSTUDENT", OleDb.OleDbType.VarChar, 40, "NAMEOFSTUDENT")

            'updateCommand.Parameters.Add("@ID", OleDb.OleDbType.VarChar, 70, "ID")



            ' dtadpt2.UpdateCommand = updateCommand
            ' ....DataTable1 Changes...
            ' dtadpt2.Update(dst2, "tblSTUDENTSNIDHAMU")


            'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx

            ' Dim cb2 As New OleDb.OleDbCommandBuilder(dtadpt2)

            ' dtadpt2.Update(dst2, "tblSTUDENTSNIDHAMU")


            ' MsgBox("Record(s) Successfully Saved!", MsgBoxStyle.OkOnly, "")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewFirstStudentDetails_Click(sender As Object, e As EventArgs) Handles DataGridViewFirstStudentDetails.Click

        Try

            Dim KCPEMIDMARK As Single
            'Dim CURRENTGRADE As String


            If IsDBNull(DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEMARKS").Value) = True Then
                DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEMARKS").Value = 0
            End If


            If IsDBNull(DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value) = True Then
                DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 0
            End If


            KCPEMIDMARK = Val(DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEMARKS").Value) / 5
            KCPEMIDMARK = FormatNumber(Val(KCPEMIDMARK), 0)

            Select Case KCPEMIDMARK

                Case 0

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "X"
                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 0



                Case 1 To 24

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "E"
                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 1

                Case 25 To 29

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "D-"
                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 2

                Case 30 To 34

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "D"
                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 3

                Case 35 To 39

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "D+"
                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 4

                Case 40 To 44

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "C-"
                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 5

                Case 45 To 54

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "C"
                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 6

                Case 55 To 59

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "C+"
                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 7

                Case 60 To 64

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "B-"
                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 8

                Case 65 To 69

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "B"
                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 9

                Case 70 To 74

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "B+"
                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 10

                Case 75 To 79

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "A-"
                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 11

                Case 80 To 100

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEGRADE").Value = "A"
                    DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 12

            End Select




            'Calculate points from current grades



            If IsDBNull(DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value) = True Then
                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 0
            End If


            If IsDBNull(DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value) = True Then
                DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "-"
            End If



            ' CURRENTGRADE = DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").ToString

            ' Select Case CURRENTGRADE


            Select Case DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value


                Case "A"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 12



                Case "A-"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 11


                Case "B+"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 10


                Case "B"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 9


                Case "B-"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 8


                Case "C+"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 7


                Case "C"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 6


                Case "C-"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 5


                Case "D+"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 4


                Case "D"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 3


                Case "D-"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 2


                Case "E"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 1


                Case "X"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 0


                Case "-"

                    DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 0

            End Select


            'Calculate Student VAP

            DataGridViewFirstStudentDetails.CurrentRow.Cells("STUDENTVAP").Value = DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value - DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value

            FormatNumber(DataGridViewFirstStudentDetails.CurrentRow.Cells("STUDENTVAP").Value, 2)

            'set VAP to 0 if no current points/current grade

            If DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 0 Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("STUDENTVAP").Value = 0

            End If


            If DataGridViewFirstStudentDetails.CurrentRow.Cells("KCPEPOINTS").Value = 0 Then

                DataGridViewFirstStudentDetails.CurrentRow.Cells("STUDENTVAP").Value = 0

            End If










            'Calculate grades and points from the current marks



            ' If IsDBNull(DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTMARKS").Value) = True Then
            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTMARKS").Value = 0
            '  End If


            ' If IsDBNull(DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value) = True Then
            ' DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = 0
            ' End If


            '  CURRENTMIDMARK = Val(DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTMARKS").Value) / 7
            '  CURRENTMIDMARK = FormatNumber(Val(CURRENTMIDMARK), 0)

            '  Select Case CURRENTMIDMARK

            ' Case 0 To 24

            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "E"
            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = "1"

            'Case 25 To 29

            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "D-"
            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = "2"

            'Case 30 To 34

            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "D"
            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = "3"

            'Case 35 To 39

            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "D+"
            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = "4"

            'Case 40 To 44

            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "C-"
            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = "5"

            'Case 45 To 54

            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "C"
            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = "6"

            'Case 55 To 59

            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "C+"
            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = "7"

            'Case 60 To 64

            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "B-"
            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = "8"

            'Case 65 To 69

            ' DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "B"
            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = "9"

            'Case 70 To 74

            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "B+"
            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = "10"

            'Case 75 To 79

            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "A-"
            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = "11"

            'Case 80 To 100

            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTGRADE").Value = "A"
            'DataGridViewFirstStudentDetails.CurrentRow.Cells("CURRENTPOINTS").Value = "12"

            ' End Select


            'Calculate VAP



            DataGridViewFirstStudentDetails.Columns("KCPEMARKS").ReadOnly = True
            DataGridViewFirstStudentDetails.Columns("KCPEGRADE").ReadOnly = True
            DataGridViewFirstStudentDetails.CurrentRow.Cells("ACADEMICYEAR").ReadOnly = True


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub frmNIDHAMUMain_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Try



            'Date of Occurence that is empty, fill it with today's date

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            Dim dstDates As New DataSet()

            Dim dtadptDates As OleDb.OleDbDataAdapter

            Dim IntCntDate As Integer


            'This sub procedure takes a long time to complete(It is a long operation) Therefore:

            ' Set cursor as hourglass for waiting to prevent the user doing something else before the operation completes

            Cursor.Current = Cursors.WaitCursor

            ' Application.DoEvents()

            ' Execute your code here

            'fetch data 
            'clear the previous record before fetching new record 
            dstDates.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptDates = New OleDb.OleDbDataAdapter("SELECT ID, DATEOFOCCURENCE, OFFENSECATEGORY From tblSTUDENTSNIDHAMU", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptDates.Fill(dstDates, "tblSTUDENTSNIDHAMU")

            'close connection after filling the dataset
            conn.Close()



            If IntCntDate <> -1 Then



                Dim cbDates As New OleDb.OleDbCommandBuilder(dtadptDates)


                cbDates.ConflictOption = ConflictOption.OverwriteChanges


                IntCntDate = 0



                If dstDates.Tables("tblSTUDENTSNIDHAMU").Rows.Count > 0 Then

                    For IntCntDate = 0 To dstDates.Tables("tblSTUDENTSNIDHAMU").Rows.Count - 1
                        If IsDBNull(dstDates.Tables("tblSTUDENTSNIDHAMU").Rows(IntCntDate).Item("DATEOFOCCURENCE")) = True Then
                            dstDates.Tables("tblSTUDENTSNIDHAMU").Rows(IntCntDate).Item("DATEOFOCCURENCE") = Today()
                        End If
                    Next

                End If
            End If


            'Save data that has pulled above

            dtadptDates.Update(dstDates, "tblSTUDENTSNIDHAMU")




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmNIDHAMUMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()



            Dim delcmd As New OleDbCommand("DELETE * FROM tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER Is Null", conn)
            delcmd.ExecuteNonQuery()


            conn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnDeleteCurrentRecord_Click(sender As Object, e As EventArgs) Handles BtnDeleteCurrentRecord.Click
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()



            '  If MessageBox.Show("Are you sure you want to delete the Current Selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then

            ' Exit Sub

            '  Else

            ' Dim delcmd As New OleDbCommand("DELETE * FROM tblSTUDENTSNIDHAMU WHERE ID = '" & DataGridViewFirstStudentDetails.CurrentRow.Cells("ID").Value & "'", conn)
            ' delcmd.ExecuteNonQuery()



            ' MessageBox.Show("Record deleted", "Deletion Confirmed")

            '  End If








            'Xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

            'To delete a datagridview row use the Rows collection's Remove or RemoveAt method.
            'First check to see if the current row is new because you cannot delete a new row.
            'Then remove the current row.

            'Now check to see if the current row is not new and and proceed

            If Not DataGridViewFirstStudentDetails.CurrentRow.IsNewRow Then

                If MessageBox.Show("Are you sure you want to delete the Current Selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then

                    Exit Sub

                Else


                    DataGridViewFirstStudentDetails.Rows.Remove(DataGridViewFirstStudentDetails.CurrentRow)




                    Dim cb2 As New OleDb.OleDbCommandBuilder(dtadpt2)
                    cb2.ConflictOption = ConflictOption.OverwriteChanges


                    dtadpt2.Update(dst2, "tblSTUDENTSNIDHAMU")



                    MessageBox.Show("Record deleted", "Deletion Confirmed")


                End If
            End If


            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub DataGridViewFirstStudentDetails_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridViewFirstStudentDetails.DataError

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

    Private Sub DataGridViewFirstStudentDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewFirstStudentDetails.CellContentClick

    End Sub

    Private Sub dgvSearchName_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchName.CellContentClick

    End Sub
End Class
