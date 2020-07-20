Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class frmPrintOuts


    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnALLIndisciplineCases_Click(sender As Object, e As EventArgs) Handles BtnALLIndisciplineCases.Click



        Dim DBconn As OleDbConnection
        Dim objCmd As OleDbCommand
        Dim objReader As OleDbDataReader
        Dim objDataset As DataSet = New dsIndisciplineCasesRpt
        Dim strSQL As String

        strSQL = ""

        strSQL = "Select DATEOFOCCURENCE, ADMISSIONNUMBER, TERM, NAMEOFSTUDENT, GENDER, KCPEMARKS, KCPEGRADE, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASS, STREAM, FORMERSCHOOL, DATEOFADMISSION, "

        strSQL &= "TYPEOFOFFENSE, OFFENSECATEGORY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER FROM tblSTUDENTSNIDHAMU WHERE DATEOFOCCURENCE >= #" & DtpBeginningDate.Value & "# AND DATEOFOCCURENCE <= #" & DtpEndingDate.Value & "#"

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
        ' Note: "dsIndisciplineCasesRpt_dtIndisciplineCasesRpt" was name we gave to the report dataset 
        ' when setting it up with the wizard
        rds.Name = "dsIndisciplineCasesRpt_dtIndisciplineCasesRpt"
        rds.Value = objDataset.Tables(0)
        Dim paramList As New Generic.List(Of ReportParameter)
        paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "mm/dd/yyyy")))
        paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "mm/dd/yyyy")))

        With frmIndisciplineCasesReportVewer
            ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
            ' qualify the report object name with the project name (in this case "WANAFUNZINIDHAMUTRACKER")
            .ReportViewer1.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.rptIndisciplineCases.rdlc"
            .ReportViewer1.LocalReport.DataSources.Clear()
            .ReportViewer1.LocalReport.DataSources.Add(rds)
            .ReportViewer1.LocalReport.SetParameters(paramList)
            .ReportViewer1.RefreshReport()
            .Text = "Indiscipline Cases Report"
            .ShowDialog()
        End With


    End Sub

    Private Sub BtnGenerateIndisciplineCases2report_Click(sender As Object, e As EventArgs) Handles BtnGenerateIndisciplineCases2report.Click
        Dim DBconn As OleDbConnection
        Dim objCmd As OleDbCommand
        Dim objReader As OleDbDataReader
        Dim objDataset As DataSet = New dsIndisciplineCases2
        Dim strSQL As String

        strSQL = ""

        strSQL = "Select ID, DATEOFOCCURENCE, ADMISSIONNUMBER, TERM, NAMEOFSTUDENT, GENDER, KCPEMARKS, KCPEGRADE, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASS, STREAM, FORMERSCHOOL, DATEOFADMISSION, "

        strSQL &= "TYPEOFOFFENSE, OFFENSECATEGORY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER FROM tblSTUDENTSNIDHAMU WHERE DATEOFOCCURENCE >= #" & DtpBeginningDate.Value & "# AND DATEOFOCCURENCE <= #" & DtpEndingDate.Value & "# AND OFFENSECATEGORY <> 'DISCIPLINED'" 'AND OFFENSECATEGORY <> NULL"

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
        paramList.Add(New ReportParameter("prmBeginningDate", Format(DtpBeginningDate.Value, "mm/dd/yyyy")))
        paramList.Add(New ReportParameter("prmEndingDate", Format(DtpEndingDate.Value, "mm/dd/yyyy")))

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
    End Sub
End Class