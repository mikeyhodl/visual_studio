Imports System
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Imports System.ComponentModel
Public Class frmStatisticalAnalysis2

    ' This is the connection to the local MS Access database.
    ' The database is needed in both the Debug and Release folders.
    'At Public Class level, you only need one connection for all procedures in the form. You will only be opening and closing them whenever you want to fetch records from the database
    Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")

    'Also define the datasets and dataadapters at public class level so that they can be accessed by other procedures
    Dim dstAnalysisByOffenseType As New DataSet
    Dim dstOffenseAnalysisByStudent As New DataSet
    Dim dstOverallOffenseAnalysis As New DataSet
    Dim dstTotalSchoolEnrolment As New DataSet
    Dim dstOffenseCategoryAnalysis As New DataSet


    Dim dtadptAnalysisByOffenseType As OleDb.OleDbDataAdapter
    Dim dtadptOffenseAnalysisByStudent As OleDb.OleDbDataAdapter
    Dim dtadptOverallOffenseAnalysis As OleDb.OleDbDataAdapter
    Dim dtadptTotalSchoolEnrolment As OleDb.OleDbDataAdapter
    Dim dtadptOffenseCategoryAnalysis As OleDb.OleDbDataAdapter


    Dim strCount As Integer
    Private Sub frmStatisticalAnalysis2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            'fetch data from the tblSTUDENTSNIDHAMUArchive table

            'clear the previous record before fetching new record 
            dstTotalSchoolEnrolment.Clear()

            'Set the data adapter and fetch data from the database using select query

            dtadptTotalSchoolEnrolment = New OleDb.OleDbDataAdapter("SELECT COUNT(ADMISSIONNUMBER) as TotalSchoolEnrolment FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE", conn) 'WHERE ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblSTUDENTSNIDHAMUArchive)", conn)


            ' Use the data adapter to fill data in the dataset
            dtadptTotalSchoolEnrolment.Fill(dstTotalSchoolEnrolment, "tblNEWSTUDENTSArchive")



            'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

            'fetch data from the tblSTUDENTSNIDHAMUArchive table

            Dim dstTotalNumberOfOffenses As New DataSet
            Dim dtadptTotalNumberOfOffenses As OleDb.OleDbDataAdapter

            'clear the previous record before fetching new record 
            dstTotalNumberOfOffenses.Clear()


            'Set the data adapter and fetch data from the database using select query

            dtadptTotalNumberOfOffenses = New OleDb.OleDbDataAdapter("SELECT COUNT(OFFENSECATEGORY) as TotalOffenses FROM tblSTUDENTSNIDHAMUArchive WHERE OFFENSECATEGORY <> 'DISCIPLINED'", conn)


            ' Use the data adapter to fill data in the dataset
            dtadptTotalNumberOfOffenses.Fill(dstTotalNumberOfOffenses, "tblSTUDENTSNIDHAMUArchive")



            'Close the database connection after filling the dataset
            conn.Close()


            Me.TotalSchoolPopulation.Text = dstTotalSchoolEnrolment.Tables("tblNEWSTUDENTSArchive").Rows(0).Item("TotalSchoolEnrolment")
            Me.TotalNumberOfOffenses.Text = dstTotalNumberOfOffenses.Tables("tblSTUDENTSNIDHAMUArchive").Rows(0).Item("TotalOffenses")



            'Add three DataGridViewTextBoxColumn for Number of Disciplined students and their percentage

            'create a DataGridViewTextBoxColumn for Number of Disciplined students on the datagridview

            Dim txtNoOfDisciplinedStudents As New DataGridViewTextBoxColumn

            txtNoOfDisciplinedStudents.Name = "txtNoOfDisciplinedStudents"

            txtNoOfDisciplinedStudents.HeaderText = "NO. of Disciplined Students"
            '  txtNoOfDisciplinedStudents.DefaultCellStyle.Format = "d"

            ' txtNoOfDisciplinedStudents.Width = 220

            DGVStatisticalAnalysis.Columns.Add(txtNoOfDisciplinedStudents)



            'create a DataGridViewTextBoxColumn for Number of Disciplined students on the datagridview

            Dim txtPercentageOfDisciplinedStudents As New DataGridViewTextBoxColumn

            txtPercentageOfDisciplinedStudents.Name = "txtPercentageOfDisciplinedStudents"

            txtPercentageOfDisciplinedStudents.HeaderText = "% of Disciplined Students"
            ' txtPercentageOfDisciplinedStudents.DefaultCellStyle.Format = "d"

            'txtPercentageOfDisciplinedStudents.Width = 220

            DGVStatisticalAnalysis.Columns.Add(txtPercentageOfDisciplinedStudents)



            'create a DataGridViewTextBoxColumn for total Number of students on the datagridview

            Dim txtTotalNoOfStudents As New DataGridViewTextBoxColumn

            txtTotalNoOfStudents.Name = "txtTotalNoOfStudents"

            txtTotalNoOfStudents.HeaderText = "Total No. of Students"
            '  txtTotalNoOfStudents.DefaultCellStyle.Format = "d"

            ' txtTotalNoOfStudents.Width = 220

            DGVStatisticalAnalysis.Columns.Add(txtTotalNoOfStudents)


            DGVStatisticalAnalysis.Columns("txtNoOfDisciplinedStudents").Visible = False
            DGVStatisticalAnalysis.Columns("txtPercentageOfDisciplinedStudents").Visible = False
            DGVStatisticalAnalysis.Columns("txtTotalNoOfStudents").Visible = False


            'Lock all the datagridview columns

            DGVStatisticalAnalysis.AllowUserToAddRows = False
            DGVStatisticalAnalysis.AllowUserToDeleteRows = False
            DGVStatisticalAnalysis.ReadOnly = True


            'CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC



            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()

            'fetch data for the combobox 'ADMNO'

            Dim dst1 As New DataSet()
            Dim dtadpt1 As OleDbDataAdapter


            'clear the previous record before fetching new record and bind it to the combobox 'ComboADNO'
            dst1.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadpt1 = New OleDb.OleDbDataAdapter("SELECT DISTINCT ADMISSIONNUMBER From tblSTUDENTSNIDHAMUArchive", conn)

            ' Use the data adapter to fill data in the dataset
            dtadpt1.Fill(dst1, "tblSTUDENTSNIDHAMUArchive") 'For combobox ADMNO

            conn.Close()

            'Fill the combobox 'ComboADMNO'

            ComboADMNO.DataSource = dst1.Tables("tblSTUDENTSNIDHAMUArchive")
            ComboADMNO.DisplayMember = "ADMISSIONNUMBER"
            ComboADMNO.ValueMember = "ADMISSIONNUMBER"


            'Fill the DtpEndingDate control with the current date

            DtpEndingDate.Value = Today()


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

    Private Sub BtnAnalysisByOffenseType_Click(sender As Object, e As EventArgs) Handles BtnAnalysisByOffenseType.Click

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()

            'fetch data from the tblSTUDENTSNIDHAMUArchive table

            'clear the previous record before fetching new record 
            dstAnalysisByOffenseType.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptAnalysisByOffenseType = New OleDb.OleDbDataAdapter("SELECT DATEOFOCCURENCE, OFFENSECATEGORY, COUNT(OFFENSECATEGORY) as COUNTOFOFFENSESCOMMITED, COUNT(OFFENSECATEGORY)/ '" & Me.TotalSchoolPopulation.Text & "' *100 as PERCENTAGE  From tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND OFFENSECATEGORY <> 'DISCIPLINED' GROUP BY DATEOFOCCURENCE, OFFENSECATEGORY ORDER BY DATEOFOCCURENCE DESC", conn)

            dtadptAnalysisByOffenseType.Fill(dstAnalysisByOffenseType, "tblSTUDENTSNIDHAMUArchive")
            ' Use the data adapter to fill data in the dataset




            'Delete the tblSTUDENTSOFFENSECATEGORYANALYSIS before feeding into it new data


            Dim dstDeleteOffenseCategoryAnalysis As New DataSet


            Dim dtadptOffenseCategoryAnalysisDelete As OleDb.OleDbDataAdapter

            'fetch data from the tblSTUDENTSOFFENSECATEGORYANALYSIS table

            'clear the previous record before fetching new record 
            dstDeleteOffenseCategoryAnalysis.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptOffenseCategoryAnalysisDelete = New OleDb.OleDbDataAdapter("DELETE * FROM tblSTUDENTSOFFENSECATEGORYANALYSIS", conn)

            dtadptOffenseCategoryAnalysisDelete.Fill(dstDeleteOffenseCategoryAnalysis, "tblSTUDENTSOFFENSECATEGORYANALYSIS")
            ' Use the data adapter to fill data in the dataset


            '  Dim cbdOffenseCategoryAnalysisDelete As New OleDb.OleDbCommandBuilder(dtadptOffenseCategoryAnalysisDelete)

            'cbdOffenseCategoryAnalysisDelete.ConflictOption=ConflictOption.OverwriteChanges


            '   dtadptOffenseCategoryAnalysisDelete.Update(dstDeleteOffenseCategoryAnalysis, "tblSTUDENTSOFFENSECATEGORYANALYSIS")





            'fetch data from the tblSTUDENTSOFFENSECATEGORYANALYSIS table

            'clear the previous record before fetching new record 
            dstOffenseCategoryAnalysis.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptOffenseCategoryAnalysis = New OleDb.OleDbDataAdapter("SELECT ID, DATEOFOCCURENCE, OFFENSECATEGORY, OCCURENCECOUNT, PERCENTAGEOFOCCURENCE FROM tblSTUDENTSOFFENSECATEGORYANALYSIS ORDER BY DATEOFOCCURENCE DESC", conn)

            dtadptOffenseCategoryAnalysis.Fill(dstOffenseCategoryAnalysis, "tblSTUDENTSOFFENSECATEGORYANALYSIS")
            ' Use the data adapter to fill data in the dataset



            'Close the database connection after filling the dataset
            conn.Close()



            If strCount <> -1 Then

                Dim cbdOffenseCategoryAnalysis As New OleDb.OleDbCommandBuilder(dtadptOffenseCategoryAnalysis)

                'Overwrite the changes in "tblSTUDENTSOFFENSECATEGORYANALYSIS"


                cbdOffenseCategoryAnalysis.ConflictOption = ConflictOption.OverwriteChanges


                Dim dstAnalysisNewRow As DataRow

                strCount = 0

                If dstAnalysisByOffenseType.Tables("tblSTUDENTSNIDHAMUArchive").Rows.Count > 0 Then

                    For strCount = 0 To dstAnalysisByOffenseType.Tables("tblSTUDENTSNIDHAMUArchive").Rows.Count - 1

                        dstAnalysisNewRow = dstOffenseCategoryAnalysis.Tables("tblSTUDENTSOFFENSECATEGORYANALYSIS").NewRow()
                        dstAnalysisNewRow.Item("DATEOFOCCURENCE") = dstAnalysisByOffenseType.Tables("tblSTUDENTSNIDHAMUArchive").Rows(strCount).Item("DATEOFOCCURENCE")
                        dstAnalysisNewRow.Item("OFFENSECATEGORY") = dstAnalysisByOffenseType.Tables("tblSTUDENTSNIDHAMUArchive").Rows(strCount).Item("OFFENSECATEGORY").ToString
                        dstAnalysisNewRow.Item("OCCURENCECOUNT") = dstAnalysisByOffenseType.Tables("tblSTUDENTSNIDHAMUArchive").Rows(strCount).Item("COUNTOFOFFENSESCOMMITED")


                        dstOffenseCategoryAnalysis.Tables("tblSTUDENTSOFFENSECATEGORYANALYSIS").Rows.Add(dstAnalysisNewRow)

                    Next

                    'save data in the database table

                    dtadptOffenseCategoryAnalysis.Update(dstOffenseCategoryAnalysis, "tblSTUDENTSOFFENSECATEGORYANALYSIS")

                    MsgBox("Record(s) successfully Saved!", MsgBoxStyle.OkOnly, "")
                End If
            End If




            DGVStatisticalAnalysis.DataSource = dstAnalysisByOffenseType.Tables("tblSTUDENTSNIDHAMUArchive")


            DGVStatisticalAnalysis.Columns("txtNoOfDisciplinedStudents").Visible = False
            DGVStatisticalAnalysis.Columns("txtPercentageOfDisciplinedStudents").Visible = False
            DGVStatisticalAnalysis.Columns("txtTotalNoOfStudents").Visible = False


            DGVStatisticalAnalysis.AutoResizeColumns()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub BtnOverallOffenseAnalysis_Click(sender As Object, e As EventArgs) Handles BtnOverallOffenseAnalysis.Click

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()

            'fetch data from the tblSTUDENTSNIDHAMUArchive table

            'clear the previous record before fetching new record 
            dstOverallOffenseAnalysis.Clear()


            'This query fetches and calculates the number of indisciplined students and their percentage

            dtadptOverallOffenseAnalysis = New OleDb.OleDbDataAdapter("SELECT COUNT(ADMISSIONNUMBER) as OVERALLOFFENSESCOUNT, COUNT(ADMISSIONNUMBER)/ '" & TotalSchoolPopulation.Text & "' *100 as PERCENTAGE FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND OFFENSECATEGORY <> 'DISCIPLINED')", conn) 'AND OFFENSECATEGORY <> NULL)", conn)


            ' Use the data adapter to fill data in the dataset
            dtadptOverallOffenseAnalysis.Fill(dstOverallOffenseAnalysis, "tblNEWSTUDENTSArchive")


            'Close the database connection after filling the dataset
            conn.Close()


            Dim cbOverallOffenseAnalysis As New OleDb.OleDbCommandBuilder(dtadptOverallOffenseAnalysis)


            DGVStatisticalAnalysis.DataSource = dstOverallOffenseAnalysis.Tables("tblNEWSTUDENTSArchive")


            'Calculations

            DGVStatisticalAnalysis.CurrentRow.Cells("txtTotalNoOfStudents").Value = Val(TotalSchoolPopulation.Text)
            DGVStatisticalAnalysis.CurrentRow.Cells("txtNoOfDisciplinedStudents").Value = Val(TotalSchoolPopulation.Text) - Val(DGVStatisticalAnalysis.CurrentRow.Cells("OVERALLOFFENSESCOUNT").Value)
            DGVStatisticalAnalysis.CurrentRow.Cells("txtPercentageOfDisciplinedStudents").Value = 100 - Val(DGVStatisticalAnalysis.CurrentRow.Cells("PERCENTAGE").Value)



            'resize the datagridview columns
            DGVStatisticalAnalysis.AutoResizeColumns()

            'make visible columns that were made invisible during loading

            DGVStatisticalAnalysis.Columns("txtNoOfDisciplinedStudents").Visible = True
            DGVStatisticalAnalysis.Columns("txtPercentageOfDisciplinedStudents").Visible = True
            DGVStatisticalAnalysis.Columns("txtTotalNoOfStudents").Visible = True


            'Arrange the columns on the datagridview

            DGVStatisticalAnalysis.Columns("txtTotalNoOfStudents").DisplayIndex = 0
            DGVStatisticalAnalysis.Columns("OVERALLOFFENSESCOUNT").DisplayIndex = 1
            DGVStatisticalAnalysis.Columns("PERCENTAGE").DisplayIndex = 2
            DGVStatisticalAnalysis.Columns("txtNoOfDisciplinedStudents").DisplayIndex = 3
            DGVStatisticalAnalysis.Columns("txtPercentageOfDisciplinedStudents").DisplayIndex = 4


            DGVStatisticalAnalysis.Columns("OVERALLOFFENSESCOUNT").HeaderText = "No. of Indisciplined Students"
            DGVStatisticalAnalysis.Columns("PERCENTAGE").HeaderText = "% of Indisciplined Students"


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnGenerateOffenseCategoriesChart_Click(sender As Object, e As EventArgs) Handles BtnGenerateOffenseCategoriesChart.Click

        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsOffensesCategStatisticsChart
            Dim strSQL As String

            strSQL = ""

            'This query fetches, counts the offenses and categorizes them

            strSQL = "SELECT OFFENSECATEGORY, COUNT(OFFENSECATEGORY) as OCCURENCECOUNT From tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) GROUP BY OFFENSECATEGORY"



            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsOffensesCategStatisticsChart_dtOffensesCategStatisticsChart" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsOffensesCategStatisticsChart_dtOffensesCategStatisticsChart"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmOffensesCategStatisticsChartReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvOffensesCategStatisticsChartReportViewer.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptOffensesCategStatisticsChart.rdlc"
                .RvOffensesCategStatisticsChartReportViewer.LocalReport.DataSources.Clear()
                .RvOffensesCategStatisticsChartReportViewer.LocalReport.DataSources.Add(rds)
                .RvOffensesCategStatisticsChartReportViewer.LocalReport.SetParameters(paramList)
                .RvOffensesCategStatisticsChartReportViewer.RefreshReport()
                .Text = "Categories of Offenses Statistics & Chart"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnOverallIndisciplinePercentages_Click(sender As Object, e As EventArgs) Handles BtnOverallIndisciplinePercentages.Click

        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsIndisciplinePercentages
            Dim strSQL As String

            strSQL = ""

            'This query fetches and calculates the number of indisciplined students and their percentage

            strSQL = "SELECT COUNT(ADMISSIONNUMBER) as NumberOfIndisciplined, COUNT(ADMISSIONNUMBER)/ '" & TotalSchoolPopulation.Text & "' as PercentageOfIndisciplined FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED')"


            'SELECT OFFENSECATEGORY, COUNT(OFFENSECATEGORY) as OCCURENCECOUNT, COUNT(OFFENSECATEGORY)/ '" & Me.TotalSchoolPopulation.Text & "' *100 as PERCENTAGEOFOCCURENCE  From tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND OFFENSECATEGORY <> 'NONE' GROUP BY OFFENSECATEGORY ORDER BY OFFENSECATEGORY DESC"




            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsIndisciplinePercentages_dtIndisciplinePercentages" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsIndisciplinePercentages_dtIndisciplinePercentages"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmIndisciplinePercentagesReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvIndisciplinePercentagesReportViewer.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptIndisciplinePercentages.rdlc"
                .RvIndisciplinePercentagesReportViewer.LocalReport.DataSources.Clear()
                .RvIndisciplinePercentagesReportViewer.LocalReport.DataSources.Add(rds)
                .RvIndisciplinePercentagesReportViewer.LocalReport.SetParameters(paramList)
                .RvIndisciplinePercentagesReportViewer.RefreshReport()
                .Text = "Overall Offenses Statistics"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnGenerateIndisciplineCases2report_Click(sender As Object, e As EventArgs) Handles BtnGenerateIndisciplineCases2report.Click

        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsIndisciplineCases2
            Dim strSQL As String

            strSQL = ""


            strSQL = "Select ID, DATEOFOCCURENCE, ADMISSIONNUMBER, TERM, NAMEOFSTUDENT, GENDER, KCPEMARKS, KCPEGRADE, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASS, STREAM, FORMERSCHOOL, DATEOFADMISSION, "

            strSQL &= "TYPEOFOFFENSE, OFFENSECATEGORY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER, TYPEOFPUNISHMENT, REMARKS FROM tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) ORDER BY DATEOFOCCURENCE ASC"


            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsIndisciplineCases2_dtIndisciplineCases2" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsIndisciplineCases2_dtIndisciplineCases2"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmIndisciplineCasesReportVewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .ReportViewer1.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptIndisciplineCases2.rdlc"
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rds)
                .ReportViewer1.LocalReport.SetParameters(paramList)
                .ReportViewer1.RefreshReport()
                .Text = "Indiscipline Cases Report"
                .ShowDialog()


            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnViewLeavers_Click(sender As Object, e As EventArgs) Handles BtnViewLeavers.Click

        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsIndisciplineCases2
            Dim strSQL As String

            strSQL = ""


            strSQL = "Select ID, DATEOFOCCURENCE, ADMISSIONNUMBER, TERM, NAMEOFSTUDENT, GENDER, KCPEMARKS, KCPEGRADE, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASS, STREAM, FORMERSCHOOL, DATEOFADMISSION, "

            strSQL &= "TYPEOFOFFENSE, OFFENSECATEGORY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER FROM tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = TRUE) ORDER BY DATEOFOCCURENCE ASC"

            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsIndisciplineCases2_dtIndisciplineCases2" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsIndisciplineCases2_dtIndisciplineCases2"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmIndisciplineCasesReportVewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .ReportViewer1.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptIndisciplineCases2.rdlc"
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rds)
                .ReportViewer1.LocalReport.SetParameters(paramList)
                .ReportViewer1.RefreshReport()
                .Text = "Indiscipline Cases Report"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnIndisciplinedStudentsByClass_Click(sender As Object, e As EventArgs) Handles BtnIndisciplinedStudentsByClass.Click

        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsStudentsDisciplineByClass
            Dim strSQL As String

            strSQL = ""


            strSQL = "Select ID, DATEOFOCCURENCE, ADMISSIONNUMBER, TERM, NAMEOFSTUDENT, GENDER, KCPEMARKS, KCPEGRADE, KCPEPOINTS, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASS, STREAM, FORMERSCHOOL, DATEOFADMISSION, "

            strSQL &= "TYPEOFOFFENSE, OFFENSECATEGORY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER, TYPEOFPUNISHMENT FROM tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) ORDER BY DATEOFOCCURENCE ASC"


            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsIndisciplineCases2_dtIndisciplineCases2" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsStudentsDisciplineByClass_dtStudentsDisciplineByClass"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmStudentsDisciplineByClassReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvStudentsDisciplineByClass.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.StudentsDisciplineByClass.rdlc"
                .RvStudentsDisciplineByClass.LocalReport.DataSources.Clear()
                .RvStudentsDisciplineByClass.LocalReport.DataSources.Add(rds)
                .RvStudentsDisciplineByClass.LocalReport.SetParameters(paramList)
                .RvStudentsDisciplineByClass.RefreshReport()
                .Text = "Indisciplined Students By Class Report"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnIndisciplinedStudentsByDormitory_Click(sender As Object, e As EventArgs) Handles BtnIndisciplinedStudentsByDormitory.Click

        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsStudentDisciplineByDormitory
            Dim strSQL As String

            strSQL = ""


            strSQL = "Select DORMITORIES, ID, DATEOFOCCURENCE, ADMISSIONNUMBER, TERM, NAMEOFSTUDENT, GENDER, KCPEMARKS, KCPEGRADE, KCPEPOINTS, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASS, STREAM, FORMERSCHOOL, DATEOFADMISSION, "

            strSQL &= "TYPEOFOFFENSE, OFFENSECATEGORY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER, TYPEOFPUNISHMENT FROM tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) ORDER BY DATEOFOCCURENCE ASC"


            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsStudentDisciplineByDormitory_dtStudentDisciplineByDormitory" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsStudentDisciplineByDormitory_dtStudentDisciplineByDormitory"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmStudentDisciplineByDormitoryReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvStudentDisciplineByDormitory.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptStudentDisciplineByDormitory.rdlc"
                .RvStudentDisciplineByDormitory.LocalReport.DataSources.Clear()
                .RvStudentDisciplineByDormitory.LocalReport.DataSources.Add(rds)
                .RvStudentDisciplineByDormitory.LocalReport.SetParameters(paramList)
                .RvStudentDisciplineByDormitory.RefreshReport()
                .Text = "Indisciplined Students By Dormitory Report"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnDormitoryOffenseCategoriesChart_Click(sender As Object, e As EventArgs) Handles BtnDormitoryOffenseCategoriesChart.Click

        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsDormitoryOffensesCategStatisticsChart
            Dim strSQL As String

            strSQL = ""

            'This query fetches, counts the offenses and categorizes them

            strSQL = "SELECT DORMITORIES, TYPEOFOFFENSE, OFFENSECATEGORY, COUNT(OFFENSECATEGORY) as OCCURENCECOUNT, COUNT(ADMISSIONNUMBER) as DORMENROLMENT From tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) GROUP BY DORMITORIES, TYPEOFOFFENSE, OFFENSECATEGORY ORDER BY DORMITORIES ASC"



            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsDormitoryOffensesCategStatisticsChart_dtDormitoryOffensesCategStatisticsChart" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsDormitoryOffensesCategStatisticsChart_dtDormitoryOffensesCategStatisticsChart"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmDormitoryOffensesCategStatisticsChartReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvDormitoryOffensesCategStatisticsChart.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptDormitoryOffensesCategStatisticsChart.rdlc"
                .RvDormitoryOffensesCategStatisticsChart.LocalReport.DataSources.Clear()
                .RvDormitoryOffensesCategStatisticsChart.LocalReport.DataSources.Add(rds)
                .RvDormitoryOffensesCategStatisticsChart.LocalReport.SetParameters(paramList)
                .RvDormitoryOffensesCategStatisticsChart.RefreshReport()
                .Text = "Dormitories Categories of Offenses Statistics & Chart"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnClassOffenseCategoriesChart_Click(sender As Object, e As EventArgs) Handles BtnClassOffenseCategoriesChart.Click

        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsClassOffensesCategStatisticsChart
            Dim strSQL As String

            strSQL = ""

            'This query fetches, counts the offenses and categorizes them

            strSQL = "SELECT CLASS, STREAM, TYPEOFOFFENSE, OFFENSECATEGORY, COUNT(OFFENSECATEGORY) as OCCURENCECOUNT, COUNT(ADMISSIONNUMBER) as StreamEnrolment From tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) GROUP BY CLASS, STREAM, TYPEOFOFFENSE, OFFENSECATEGORY ORDER BY CLASS ASC"



            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsClassOffensesCategStatisticsChart_dtClassOffensesCategStatisticsChart" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsClassOffensesCategStatisticsChart_dtClassOffensesCategStatisticsChart"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmClassOffensesCategStatisticsChartReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvClassOffensesCategStatisticsChart.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptClassOffensesCategStatisticsChart.rdlc"
                .RvClassOffensesCategStatisticsChart.LocalReport.DataSources.Clear()
                .RvClassOffensesCategStatisticsChart.LocalReport.DataSources.Add(rds)
                .RvClassOffensesCategStatisticsChart.LocalReport.SetParameters(paramList)
                .RvClassOffensesCategStatisticsChart.RefreshReport()
                .Text = "Class/Stream Categories of Offenses Statistics & Chart"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnGenderOffenceAnalysis_Click(sender As Object, e As EventArgs) Handles BtnGenderOffenceAnalysis.Click

        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsGenderIndisciplinePercentages
            Dim strSQL As String

            strSQL = ""

            'This query fetches and calculates the number of male and female students

            strSQL = "SELECT GENDER, TYPEOFOFFENSE, OFFENSECATEGORY, COUNT(OFFENSECATEGORY) as OCCURENCECOUNT, COUNT(ADMISSIONNUMBER) as GENDERENROLMENT From tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) GROUP BY GENDER, TYPEOFOFFENSE, OFFENSECATEGORY ORDER BY GENDER ASC"


            'strSQL = "SELECT DORMITORIES, TYPEOFOFFENSE, OFFENSECATEGORY, COUNT(OFFENSECATEGORY) as OCCURENCECOUNT, COUNT(ADMISSIONNUMBER) as DORMENROLMENT From tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) GROUP BY DORMITORIES, TYPEOFOFFENSE, OFFENSECATEGORY ORDER BY DORMITORIES ASC"




            ' strSQL = "SELECT GENDER, COUNT(ADMISSIONNUMBER) as NumberOfIndisciplined, COUNT(ADMISSIONNUMBER)/ '" & TotalSchoolPopulation.Text & "' as PercentageOfIndisciplined FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND OFFENSECATEGORY <> 'DISCIPLINED') GROUP BY GENDER ORDER BY GENDER ASC"

            ' strSQL = "SELECT GENDER, COUNT(ADMISSIONNUMBER) as NumberOfIndisciplined, COUNT(ADMISSIONNUMBER)/ 499 as PercentageOfIndisciplined FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND OFFENSECATEGORY <> 'DISCIPLINED') GROUP BY GENDER ORDER BY GENDER ASC"


            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsGenderIndisciplinePercentages_dtGenderIndisciplinePercentages" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsGenderIndisciplinePercentages_dtGenderIndisciplinePercentages"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmGenderIndisciplinePercentagesReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvGenderIndisciplinePercentagesReportViewer.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptGenderIndisciplinePercentages.rdlc"
                .RvGenderIndisciplinePercentagesReportViewer.LocalReport.DataSources.Clear()
                .RvGenderIndisciplinePercentagesReportViewer.LocalReport.DataSources.Add(rds)
                .RvGenderIndisciplinePercentagesReportViewer.LocalReport.SetParameters(paramList)
                .RvGenderIndisciplinePercentagesReportViewer.RefreshReport()
                .Text = "Gender Offences Statistics"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnIndividualMwanafunzi_Click(sender As Object, e As EventArgs) Handles BtnIndividualMwanafunzi.Click

        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsIndividualMwanafunzi
            Dim strSQL As String

            strSQL = ""


            strSQL = "Select ID, DATEOFOCCURENCE, ADMISSIONNUMBER, TERM, NAMEOFSTUDENT, GENDER, KCPEMARKS, KCPEGRADE, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASS, STREAM, FORMERSCHOOL, DATEOFADMISSION, DORMITORIES, "

            strSQL &= "TYPEOFOFFENSE, OFFENSECATEGORY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER, STUDENTPHOTO, FAMILYSITUATION, COUNTY, SUBCOUNTY, RESIDENCEESTATE, RESPONSIBILITY, REMARKS, TYPEOFPUNISHMENT, FEESBALANCE FROM tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ADMISSIONNUMBER = '" & ComboADMNO.Text & "' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive) ORDER BY DATEOFOCCURENCE ASC"


            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsIndividualMwanafunzi_dtIndividualMwanafunzi" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsIndividualMwanafunzi_dtIndividualMwanafunzi"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))


            With frmIndividualMwanafunziReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvIndividualMwanafunziReportViewer.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptIndividualMwanafunzi.rdlc"
                .RvIndividualMwanafunziReportViewer.LocalReport.DataSources.Clear()
                .RvIndividualMwanafunziReportViewer.LocalReport.DataSources.Add(rds)
                .RvIndividualMwanafunziReportViewer.LocalReport.SetParameters(paramList)
                .RvIndividualMwanafunziReportViewer.RefreshReport()
                .Text = "Individual Student Cases Report"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DtpEndingDate_ValueChanged(sender As Object, e As EventArgs) Handles DtpEndingDate.ValueChanged
        Try

            ' If conn.State = ConnectionState.Open Then conn.Close()

            '  conn.Open()


            '  Dim dstFillDATEOFOCCURENCE As New DataSet()
            '  Dim dtadptFillDATEOFOCCURENCE As OleDb.OleDbDataAdapter
            '  Dim IntCounter As Integer



            'This sub procedure takes a long time to complete(It is a long operation) Therefore:

            ' Set cursor as hourglass for waiting to prevent the user doing something else before the operation completes

            '  Cursor.Current = Cursors.WaitCursor

            ' Application.DoEvents()

            ' Execute your code here


            'clear the previous record before fetching new record and bind it to the datagridview
            'dstFillDATEOFOCCURENCE.Clear()


            'Set the data adapter and fetch data fro the database using select query
            'dtadptFillDATEOFOCCURENCE = New OleDb.OleDbDataAdapter("Select * FROM tblSTUDENTSNIDHAMUArchive", conn)



            ' Use the data adapter to fill data in the dataset
            'dtadptFillDATEOFOCCURENCE.Fill(dstFillDATEOFOCCURENCE, "tblSTUDENTSNIDHAMUArchive")

            'Close the database connection after filling the dataset
            'conn.Close()


            'If IntCounter <> -1 Then

            'Dim cbFillDATEOFOCCURENCE As New OleDb.OleDbCommandBuilder(dtadptFillDATEOFOCCURENCE)


            'IntCounter = 0

            'If dstFillDATEOFOCCURENCE.Tables("tblSTUDENTSNIDHAMUArchive").Rows.Count > 0 Then

            'For IntCounter = 0 To dstFillDATEOFOCCURENCE.Tables("tblSTUDENTSNIDHAMUArchive").Rows.Count - 1
            'If dstFillDATEOFOCCURENCE.Tables("tblSTUDENTSNIDHAMUArchive").Rows(IntCounter).Item("OFFENSECATEGORY") = "DISCIPLINED" Then
            'dstFillDATEOFOCCURENCE.Tables("tblSTUDENTSNIDHAMUArchive").Rows(IntCounter).Item("DATEOFOCCURENCE") = DtpEndingDate.Value
            'End If
            'Next

            'dtadptFillDATEOFOCCURENCE.Update(dstFillDATEOFOCCURENCE, "tblSTUDENTSNIDHAMUArchive")

            'End If
            'End If


            ' Set cursor as default arrow to return it to the normal state from the hourglass.
            'Cursor.Current = Cursors.Default



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnSubjects_Click(sender As Object, e As EventArgs) Handles BtnSubjects.Click
        Dim DBconn As OleDbConnection
        Dim objCmd As OleDbCommand
        Dim objReader As OleDbDataReader
        Dim objDataset As DataSet = New dsSUBJECTS
        Dim strSQL As String

        strSQL = ""

        'This query fetches, counts the offenses and categorizes them

        strSQL = "SELECT * FROM tblSUBJECTMARKS"



        DBconn = New OleDbConnection(DBASE_CONC_STRING)

        objCmd = New OleDbCommand(strSQL, DBconn)
        objCmd.CommandType = CommandType.Text
        objCmd.Connection.Open()


        objReader = objCmd.ExecuteReader

        objDataset.Tables(0).Clear()
        objDataset.Tables(0).Load(objReader)
        objReader.Close()
        DBconn.Close()


        Dim rds As ReportDataSource = New ReportDataSource
        ' Note: "dsSUBJECTS_dtSUBJECTS" was name we gave to the report dataset 
        ' when setting it up with the wizard
        rds.Name = "dsSUBJECTS_dtSUBJECTS"
        rds.Value = objDataset.Tables(0)
        ' Dim paramList As New Generic.List(Of ReportParameter)
        ' paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
        ' paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

        With frmSUBJECTS
            ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
            ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
            .RvSUBJECTSreportViewer.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptSUBJECTS.rdlc"
            .RvSUBJECTSreportViewer.LocalReport.DataSources.Clear()
            .RvSUBJECTSreportViewer.LocalReport.DataSources.Add(rds)
            ' .RvSUBJECTSreportViewer.LocalReport.SetParameters(paramList)
            .RvSUBJECTSreportViewer.RefreshReport()
            .Text = "Subjects"
            .ShowDialog()
        End With
    End Sub


    Private Sub BtnPendingPunishment_Click(sender As Object, e As EventArgs) Handles BtnPendingPunishment.Click
        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsStudentsDisciplineByClass
            Dim strSQL As String

            strSQL = ""


            strSQL = "Select ID, DATEOFOCCURENCE, ADMISSIONNUMBER, TERM, NAMEOFSTUDENT, GENDER, KCPEMARKS, KCPEGRADE, KCPEPOINTS, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASS, STREAM, FORMERSCHOOL, DATEOFADMISSION, "

            strSQL &= "TYPEOFOFFENSE, OFFENSECATEGORY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER, TYPEOFPUNISHMENT FROM tblSTUDENTSNIDHAMUArchive WHERE TYPEOFPUNISHMENT = 'Pending' AND DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) ORDER BY DATEOFOCCURENCE ASC"


            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsIndisciplineCases2_dtIndisciplineCases2" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsStudentsDisciplineByClass_dtStudentsDisciplineByClass"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmStudentsDisciplineByClassReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvStudentsDisciplineByClass.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.StudentsDisciplineByClass.rdlc"
                .RvStudentsDisciplineByClass.LocalReport.DataSources.Clear()
                .RvStudentsDisciplineByClass.LocalReport.DataSources.Add(rds)
                .RvStudentsDisciplineByClass.LocalReport.SetParameters(paramList)
                .RvStudentsDisciplineByClass.RefreshReport()
                .Text = "Indisciplined Students By Class Report"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MajorOffensesPerClass_Click(sender As Object, e As EventArgs) Handles MajorOffensesPerClass.Click
        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsStudentsDisciplineByClass
            Dim strSQL As String

            strSQL = ""


            strSQL = "Select ID, DATEOFOCCURENCE, ADMISSIONNUMBER, TERM, NAMEOFSTUDENT, GENDER, KCPEMARKS, KCPEGRADE, KCPEPOINTS, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASS, STREAM, FORMERSCHOOL, DATEOFADMISSION, "

            strSQL &= "TYPEOFOFFENSE, OFFENSECATEGORY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER, TYPEOFPUNISHMENT FROM tblSTUDENTSNIDHAMUArchive WHERE TYPEOFOFFENSE = 'Major' AND DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) ORDER BY DATEOFOCCURENCE ASC"


            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsIndisciplineCases2_dtIndisciplineCases2" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsStudentsDisciplineByClass_dtStudentsDisciplineByClass"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmStudentsDisciplineByClassReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvStudentsDisciplineByClass.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.StudentsDisciplineByClass.rdlc"
                .RvStudentsDisciplineByClass.LocalReport.DataSources.Clear()
                .RvStudentsDisciplineByClass.LocalReport.DataSources.Add(rds)
                .RvStudentsDisciplineByClass.LocalReport.SetParameters(paramList)
                .RvStudentsDisciplineByClass.RefreshReport()
                .Text = "Indisciplined Students By Class Report"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MinorOffensesPerClass_Click(sender As Object, e As EventArgs) Handles MinorOffensesPerClass.Click
        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsStudentsDisciplineByClass
            Dim strSQL As String

            strSQL = ""


            strSQL = "Select ID, DATEOFOCCURENCE, ADMISSIONNUMBER, TERM, NAMEOFSTUDENT, GENDER, KCPEMARKS, KCPEGRADE, KCPEPOINTS, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASS, STREAM, FORMERSCHOOL, DATEOFADMISSION, "

            strSQL &= "TYPEOFOFFENSE, OFFENSECATEGORY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER, TYPEOFPUNISHMENT FROM tblSTUDENTSNIDHAMUArchive WHERE TYPEOFOFFENSE = 'Minor' AND DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) ORDER BY DATEOFOCCURENCE ASC"


            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsIndisciplineCases2_dtIndisciplineCases2" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsStudentsDisciplineByClass_dtStudentsDisciplineByClass"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmStudentsDisciplineByClassReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvStudentsDisciplineByClass.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.StudentsDisciplineByClass.rdlc"
                .RvStudentsDisciplineByClass.LocalReport.DataSources.Clear()
                .RvStudentsDisciplineByClass.LocalReport.DataSources.Add(rds)
                .RvStudentsDisciplineByClass.LocalReport.SetParameters(paramList)
                .RvStudentsDisciplineByClass.RefreshReport()
                .Text = "Indisciplined Students By Class Report"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnMajorOffensesPerDorm_Click(sender As Object, e As EventArgs) Handles BtnMajorOffensesPerDorm.Click
        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsStudentDisciplineByDormitory
            Dim strSQL As String

            strSQL = ""


            strSQL = "Select DORMITORIES, ID, DATEOFOCCURENCE, ADMISSIONNUMBER, TERM, NAMEOFSTUDENT, GENDER, KCPEMARKS, KCPEGRADE, KCPEPOINTS, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASS, STREAM, FORMERSCHOOL, DATEOFADMISSION, "

            strSQL &= "TYPEOFOFFENSE, OFFENSECATEGORY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER, TYPEOFPUNISHMENT FROM tblSTUDENTSNIDHAMUArchive WHERE TYPEOFOFFENSE = 'Major' AND DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) ORDER BY DATEOFOCCURENCE ASC"


            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsStudentDisciplineByDormitory_dtStudentDisciplineByDormitory" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsStudentDisciplineByDormitory_dtStudentDisciplineByDormitory"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmStudentDisciplineByDormitoryReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvStudentDisciplineByDormitory.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptStudentDisciplineByDormitory.rdlc"
                .RvStudentDisciplineByDormitory.LocalReport.DataSources.Clear()
                .RvStudentDisciplineByDormitory.LocalReport.DataSources.Add(rds)
                .RvStudentDisciplineByDormitory.LocalReport.SetParameters(paramList)
                .RvStudentDisciplineByDormitory.RefreshReport()
                .Text = "Indisciplined Students By Dormitory Report"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnMinorOffensesPerDorm_Click(sender As Object, e As EventArgs) Handles BtnMinorOffensesPerDorm.Click
        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsStudentDisciplineByDormitory
            Dim strSQL As String

            strSQL = ""


            strSQL = "Select DORMITORIES, ID, DATEOFOCCURENCE, ADMISSIONNUMBER, TERM, NAMEOFSTUDENT, GENDER, KCPEMARKS, KCPEGRADE, KCPEPOINTS, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASS, STREAM, FORMERSCHOOL, DATEOFADMISSION, "

            strSQL &= "TYPEOFOFFENSE, OFFENSECATEGORY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER, TYPEOFPUNISHMENT FROM tblSTUDENTSNIDHAMUArchive WHERE TYPEOFOFFENSE = 'Minor' AND DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) ORDER BY DATEOFOCCURENCE ASC"


            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsStudentDisciplineByDormitory_dtStudentDisciplineByDormitory" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsStudentDisciplineByDormitory_dtStudentDisciplineByDormitory"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmStudentDisciplineByDormitoryReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvStudentDisciplineByDormitory.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptStudentDisciplineByDormitory.rdlc"
                .RvStudentDisciplineByDormitory.LocalReport.DataSources.Clear()
                .RvStudentDisciplineByDormitory.LocalReport.DataSources.Add(rds)
                .RvStudentDisciplineByDormitory.LocalReport.SetParameters(paramList)
                .RvStudentDisciplineByDormitory.RefreshReport()
                .Text = "Indisciplined Students By Dormitory Report"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnMajorOffencesClassStatistics_Click(sender As Object, e As EventArgs) Handles BtnMajorOffencesClassStatistics.Click
        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsClassOffensesCategStatisticsChart
            Dim strSQL As String

            strSQL = ""

            'This query fetches, counts the offenses and categorizes them

            strSQL = "SELECT CLASS, STREAM, TYPEOFOFFENSE, OFFENSECATEGORY, COUNT(OFFENSECATEGORY) as OCCURENCECOUNT, COUNT(ADMISSIONNUMBER) as StreamEnrolment From tblSTUDENTSNIDHAMUArchive WHERE TYPEOFOFFENSE = 'Major' AND DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) GROUP BY CLASS, STREAM, TYPEOFOFFENSE, OFFENSECATEGORY ORDER BY CLASS ASC"



            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsClassOffensesCategStatisticsChart_dtClassOffensesCategStatisticsChart" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsClassOffensesCategStatisticsChart_dtClassOffensesCategStatisticsChart"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmClassOffensesCategStatisticsChartReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvClassOffensesCategStatisticsChart.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptClassOffensesCategStatisticsChart.rdlc"
                .RvClassOffensesCategStatisticsChart.LocalReport.DataSources.Clear()
                .RvClassOffensesCategStatisticsChart.LocalReport.DataSources.Add(rds)
                .RvClassOffensesCategStatisticsChart.LocalReport.SetParameters(paramList)
                .RvClassOffensesCategStatisticsChart.RefreshReport()
                .Text = "Class/Stream Categories of Offenses Statistics & Chart"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnMinorOffencesClassStatistics_Click(sender As Object, e As EventArgs) Handles BtnMinorOffencesClassStatistics.Click
        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsClassOffensesCategStatisticsChart
            Dim strSQL As String

            strSQL = ""

            'This query fetches, counts the offenses and categorizes them

            strSQL = "SELECT CLASS, STREAM, TYPEOFOFFENSE, OFFENSECATEGORY, COUNT(OFFENSECATEGORY) as OCCURENCECOUNT, COUNT(ADMISSIONNUMBER) as StreamEnrolment From tblSTUDENTSNIDHAMUArchive WHERE TYPEOFOFFENSE = 'Minor' AND DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) GROUP BY CLASS, STREAM, TYPEOFOFFENSE, OFFENSECATEGORY ORDER BY CLASS ASC"



            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsClassOffensesCategStatisticsChart_dtClassOffensesCategStatisticsChart" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsClassOffensesCategStatisticsChart_dtClassOffensesCategStatisticsChart"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmClassOffensesCategStatisticsChartReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvClassOffensesCategStatisticsChart.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptClassOffensesCategStatisticsChart.rdlc"
                .RvClassOffensesCategStatisticsChart.LocalReport.DataSources.Clear()
                .RvClassOffensesCategStatisticsChart.LocalReport.DataSources.Add(rds)
                .RvClassOffensesCategStatisticsChart.LocalReport.SetParameters(paramList)
                .RvClassOffensesCategStatisticsChart.RefreshReport()
                .Text = "Class/Stream Categories of Offenses Statistics & Chart"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnMajorOffencesDormStatistics_Click(sender As Object, e As EventArgs) Handles BtnMajorOffencesDormStatistics.Click
        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsDormitoryOffensesCategStatisticsChart
            Dim strSQL As String

            strSQL = ""

            'This query fetches, counts the offenses and categorizes them

            strSQL = "SELECT DORMITORIES, TYPEOFOFFENSE, OFFENSECATEGORY, COUNT(OFFENSECATEGORY) as OCCURENCECOUNT, COUNT(ADMISSIONNUMBER) as DORMENROLMENT From tblSTUDENTSNIDHAMUArchive WHERE TYPEOFOFFENSE = 'Major' AND DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) GROUP BY DORMITORIES, TYPEOFOFFENSE, OFFENSECATEGORY ORDER BY DORMITORIES ASC"



            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsDormitoryOffensesCategStatisticsChart_dtDormitoryOffensesCategStatisticsChart" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsDormitoryOffensesCategStatisticsChart_dtDormitoryOffensesCategStatisticsChart"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmDormitoryOffensesCategStatisticsChartReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvDormitoryOffensesCategStatisticsChart.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptDormitoryOffensesCategStatisticsChart.rdlc"
                .RvDormitoryOffensesCategStatisticsChart.LocalReport.DataSources.Clear()
                .RvDormitoryOffensesCategStatisticsChart.LocalReport.DataSources.Add(rds)
                .RvDormitoryOffensesCategStatisticsChart.LocalReport.SetParameters(paramList)
                .RvDormitoryOffensesCategStatisticsChart.RefreshReport()
                .Text = "Dormitories Categories of Offenses Statistics & Chart"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnMinorOffencesDormStatistics_Click(sender As Object, e As EventArgs) Handles BtnMinorOffencesDormStatistics.Click
        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsDormitoryOffensesCategStatisticsChart
            Dim strSQL As String

            strSQL = ""

            'This query fetches, counts the offenses and categorizes them

            strSQL = "SELECT DORMITORIES, TYPEOFOFFENSE, OFFENSECATEGORY, COUNT(OFFENSECATEGORY) as OCCURENCECOUNT, COUNT(ADMISSIONNUMBER) as DORMENROLMENT From tblSTUDENTSNIDHAMUArchive WHERE TYPEOFOFFENSE = 'Minor' AND DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) GROUP BY DORMITORIES, TYPEOFOFFENSE, OFFENSECATEGORY ORDER BY DORMITORIES ASC"



            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsDormitoryOffensesCategStatisticsChart_dtDormitoryOffensesCategStatisticsChart" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsDormitoryOffensesCategStatisticsChart_dtDormitoryOffensesCategStatisticsChart"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmDormitoryOffensesCategStatisticsChartReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvDormitoryOffensesCategStatisticsChart.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptDormitoryOffensesCategStatisticsChart.rdlc"
                .RvDormitoryOffensesCategStatisticsChart.LocalReport.DataSources.Clear()
                .RvDormitoryOffensesCategStatisticsChart.LocalReport.DataSources.Add(rds)
                .RvDormitoryOffensesCategStatisticsChart.LocalReport.SetParameters(paramList)
                .RvDormitoryOffensesCategStatisticsChart.RefreshReport()
                .Text = "Dormitories Categories of Offenses Statistics & Chart"
                .ShowDialog()
            End With

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

            dtadptNameToSearch = New OleDb.OleDbDataAdapter("Select DISTINCT NAMEOFSTUDENT, ADMISSIONNUMBER FROM tblSTUDENTSNIDHAMUArchive WHERE NAMEOFSTUDENT LIKE '%" & txtNameToSearch.Text & "%' ORDER BY NAMEOFSTUDENT ASC", conn)

            '* wild card works in jet 4.0 connection

            ' dtadptNameToSearch = New OleDb.OleDbDataAdapter("Select DISTINCT NAMEOFSTUDENT, ADMISSIONNUMBER FROM tblSTUDENTSNIDHAMUArchive WHERE NAMEOFSTUDENT LIKE '*" & txtNameToSearch.Text & "*' ORDER BY NAMEOFSTUDENT ASC", conn)


            ' Use the data adapter to fill data in the dataset
            dtadptNameToSearch.Fill(dstNameToSearch, "tblSTUDENTSNIDHAMUArchive")


            'Close the connection after filling the dataset
            conn.Close()

            'Fill the datagridview with data from the dataset

            dgvSearchName.DataSource = dstNameToSearch.Tables("tblSTUDENTSNIDHAMUArchive")


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

    Private Sub dgvSearchName_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchName.CellContentClick

    End Sub

    Private Sub dgvSearchName_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchName.CellDoubleClick
        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsIndividualMwanafunzi
            Dim strSQL As String

            strSQL = ""


            strSQL = "Select ID, DATEOFOCCURENCE, ADMISSIONNUMBER, TERM, NAMEOFSTUDENT, GENDER, KCPEMARKS, KCPEGRADE, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASS, STREAM, FORMERSCHOOL, DATEOFADMISSION, DORMITORIES, "

            strSQL &= "TYPEOFOFFENSE, OFFENSECATEGORY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER, STUDENTPHOTO, FAMILYSITUATION, COUNTY, SUBCOUNTY, RESIDENCEESTATE, RESPONSIBILITY, REMARKS, TYPEOFPUNISHMENT FROM tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ADMISSIONNUMBER = '" & dgvSearchName.CurrentRow.Cells("ADMISSIONNUMBER").Value & "' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive) ORDER BY DATEOFOCCURENCE ASC"


            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsIndividualMwanafunzi_dtIndividualMwanafunzi" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsIndividualMwanafunzi_dtIndividualMwanafunzi"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))


            With frmIndividualMwanafunziReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvIndividualMwanafunziReportViewer.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptIndividualMwanafunzi.rdlc"
                .RvIndividualMwanafunziReportViewer.LocalReport.DataSources.Clear()
                .RvIndividualMwanafunziReportViewer.LocalReport.DataSources.Add(rds)
                .RvIndividualMwanafunziReportViewer.LocalReport.SetParameters(paramList)
                .RvIndividualMwanafunziReportViewer.RefreshReport()
                .Text = "Individual Student Cases Report"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnGenderDisciplineStatistics_Click(sender As Object, e As EventArgs) Handles BtnGenderDisciplineStatistics.Click
        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsGenderDiscipline
            Dim strSQL As String

            strSQL = ""

            'This query fetches and calculates the number of male and female students

            strSQL = "SELECT GENDER, TYPEOFOFFENSE, OFFENSECATEGORY, COUNT(OFFENSECATEGORY) as OCCURENCECOUNT, COUNT(ADMISSIONNUMBER) as GENDERENROLMENT From tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) GROUP BY GENDER, TYPEOFOFFENSE, OFFENSECATEGORY ORDER BY GENDER ASC"


            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsGenderDiscipline_dtGenderDiscipline" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsGenderDiscipline_dtGenderDiscipline"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmGenderDisciplineReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .rvGenderDiscipline.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.rptGenderDiscipline.rdlc"
                .rvGenderDiscipline.LocalReport.DataSources.Clear()
                .rvGenderDiscipline.LocalReport.DataSources.Add(rds)
                .rvGenderDiscipline.LocalReport.SetParameters(paramList)
                .rvGenderDiscipline.RefreshReport()
                .Text = "Gender Offences Statistics"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DGVStatisticalAnalysis_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVStatisticalAnalysis.CellContentClick

    End Sub

    Private Sub BtnMajorVsMinorOffencesPercentages_Click(sender As Object, e As EventArgs) Handles BtnMajorVsMinorOffencesPercentages.Click
        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsComparisonMajorMinorOffences
            Dim strSQL As String

            strSQL = ""

            'This query fetches, counts the Major Minor offenses and categorizes them    

            ' strSQL = "SELECT OFFENSECATEGORY, COUNT(OFFENSECATEGORY) as OCCURENCECOUNT From tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) GROUP BY OFFENSECATEGORY ORDER BY OFFENSECATEGORY DESC"

            strSQL = "SELECT TYPEOFOFFENSE, COUNT(TYPEOFOFFENSE) as ALLOFFENCESCOUNT From tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND TYPEOFOFFENSE <> 'NONE' AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND OFFENSECATEGORY <> 'DISCIPLINED' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive WHERE DISCONTINUED = FALSE) GROUP BY TYPEOFOFFENSE ORDER BY TYPEOFOFFENSE ASC"


            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsComparisonMajorMinorOffences_dtComparisonMajorMinorOffences" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsComparisonMajorMinorOffences_dtComparisonMajorMinorOffences"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmComparisonMajorMinorOffences 'Form that houses the reportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .rvComparisonMajorMinorOffences.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.rptComparisonMajorMinorOffences.rdlc"
                .rvComparisonMajorMinorOffences.LocalReport.DataSources.Clear()
                .rvComparisonMajorMinorOffences.LocalReport.DataSources.Add(rds)
                .rvComparisonMajorMinorOffences.LocalReport.SetParameters(paramList)
                .rvComparisonMajorMinorOffences.RefreshReport()
                .Text = "Comparison Of Major Minor Offenses"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnAllStudentsDispCard_Click(sender As Object, e As EventArgs) Handles BtnAllStudentsDispCard.Click
        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsIndividualMwanafunzi
            Dim strSQL As String

            strSQL = ""


            strSQL = "Select ID, DATEOFOCCURENCE, ADMISSIONNUMBER, TERM, NAMEOFSTUDENT, GENDER, KCPEMARKS, KCPEGRADE, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASS, STREAM, FORMERSCHOOL, DATEOFADMISSION, DORMITORIES, "

            strSQL &= "TYPEOFOFFENSE, OFFENSECATEGORY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER, STUDENTPHOTO, FAMILYSITUATION, COUNTY, SUBCOUNTY, RESIDENCEESTATE, RESPONSIBILITY, REMARKS, TYPEOFPUNISHMENT, FEESBALANCE FROM tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive) ORDER BY DATEOFOCCURENCE ASC"


            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsIndividualMwanafunzi_dtIndividualMwanafunzi" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsIndividualMwanafunzi_dtIndividualMwanafunzi"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))


            With frmIndividualMwanafunziReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvIndividualMwanafunziReportViewer.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptIndividualMwanafunzi.rdlc"
                .RvIndividualMwanafunziReportViewer.LocalReport.DataSources.Clear()
                .RvIndividualMwanafunziReportViewer.LocalReport.DataSources.Add(rds)
                .RvIndividualMwanafunziReportViewer.LocalReport.SetParameters(paramList)
                .RvIndividualMwanafunziReportViewer.RefreshReport()
                .Text = "Individual Student Cases Report"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnStudentOffenceNarration_Click(sender As Object, e As EventArgs) Handles BtnStudentOffenceNarration.Click
        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsOffencesNarrations
            Dim strSQL As String

            strSQL = ""


            strSQL = "Select ID, DATEOFOCCURENCE, ADMISSIONNUMBER, TERM, NAMEOFSTUDENT, GENDER, CLASS, STREAM, "

            strSQL &= "TYPEOFOFFENSE, OFFENSECATEGORY, OFFENSECOMMITED FROM tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ADMISSIONNUMBER = '" & ComboADMNO.Text & "' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive) ORDER BY DATEOFOCCURENCE ASC"


            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsOffencesNarrations_dtOffencesNarrations" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsOffencesNarrations_dtOffencesNarrations"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))



            With frmOffenceNarrationsReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvOffenceNarrationsReportViewer.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.rptOffencesNarrations.rdlc"
                .RvOffenceNarrationsReportViewer.LocalReport.DataSources.Clear()
                .RvOffenceNarrationsReportViewer.LocalReport.DataSources.Add(rds)
                .RvOffenceNarrationsReportViewer.LocalReport.SetParameters(paramList)
                .RvOffenceNarrationsReportViewer.RefreshReport()
                .Text = "Students' Offences Narrations Report"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnBtnStudentOffenceNarration2_Click(sender As Object, e As EventArgs) Handles BtnBtnStudentOffenceNarration2.Click
        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsOffencesNarrations
            Dim strSQL As String

            strSQL = ""


            strSQL = "Select ID, DATEOFOCCURENCE, ADMISSIONNUMBER, TERM, NAMEOFSTUDENT, GENDER, CLASS, STREAM, "

            strSQL &= "TYPEOFOFFENSE, OFFENSECATEGORY, OFFENSECOMMITED, TYPEOFPUNISHMENT FROM tblSTUDENTSNIDHAMUArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ADMISSIONNUMBER = '" & ComboADMNO.Text & "' AND ADMISSIONNUMBER IN (SELECT DISTINCT ADMISSIONNUMBER FROM tblNEWSTUDENTSArchive) ORDER BY DATEOFOCCURENCE ASC"


            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsOffencesNarrations_dtOffencesNarrations" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsOffencesNarrations_dtOffencesNarrations"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))



            With frmOffenceNarrationsReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .RvOffenceNarrationsReportViewer.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.rptOffencesNarrations.rdlc"
                .RvOffenceNarrationsReportViewer.LocalReport.DataSources.Clear()
                .RvOffenceNarrationsReportViewer.LocalReport.DataSources.Add(rds)
                .RvOffenceNarrationsReportViewer.LocalReport.SetParameters(paramList)
                .RvOffenceNarrationsReportViewer.RefreshReport()
                .Text = "Students' Offences Narrations Report"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnClassEnrolment_Click(sender As Object, e As EventArgs) Handles BtnClassEnrolment.Click

        Try

            Dim DBconn As OleDbConnection
            Dim objCmd As OleDbCommand
            Dim objReader As OleDbDataReader
            Dim objDataset As DataSet = New dsClassEnrolment
            Dim strSQL As String

            strSQL = ""

            'This query fetches, counts the offenses and categorizes them

            strSQL = "SELECT CLASS, GENDER, STREAM, COUNT(ADMISSIONNUMBER) as ENROLMENT FROM tblNEWSTUDENTSArchive WHERE DATEOFOCCURENCE >= #" & Format(DtpBeginningDate.Value, "dd/MMM/yyyy") & "# AND DATEOFOCCURENCE <= #" & Format(DtpEndingDate.Value, "dd/MMM/yyyy") & "# AND ACADEMICYEAR = '" & CombAllYears.Text & "' AND DISCONTINUED = FALSE GROUP BY CLASS, GENDER, STREAM ORDER BY CLASS ASC"



            DBconn = New OleDbConnection(DBASE_CONC_STRING)

            objCmd = New OleDbCommand(strSQL, DBconn)
            objCmd.CommandType = CommandType.Text
            objCmd.Connection.Open()


            objReader = objCmd.ExecuteReader

            objDataset.Tables(0).Clear()
            objDataset.Tables(0).Load(objReader)
            objReader.Close()
            DBconn.Close()


            Dim rds As ReportDataSource = New ReportDataSource
            ' Note: "dsClassEnrolment_dtClassEnrolment" was name we gave to the report dataset 
            ' when setting it up with the wizard
            rds.Name = "dsClassEnrolment_dtClassEnrolment"
            rds.Value = objDataset.Tables(0)
            Dim paramList As New Generic.List(Of ReportParameter)
            paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "dd/MMM/yyyy")))
            paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "dd/MMM/yyyy")))

            With frmClassEnrolmentReportViewer
                ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
                ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
                .rvClassEnrolmentReportViewer.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.rptClassEnrolment.rdlc"
                .rvClassEnrolmentReportViewer.LocalReport.DataSources.Clear()
                .rvClassEnrolmentReportViewer.LocalReport.DataSources.Add(rds)
                .rvClassEnrolmentReportViewer.LocalReport.SetParameters(paramList)
                .rvClassEnrolmentReportViewer.RefreshReport()
                .Text = "Class Enrolment"
                .ShowDialog()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
