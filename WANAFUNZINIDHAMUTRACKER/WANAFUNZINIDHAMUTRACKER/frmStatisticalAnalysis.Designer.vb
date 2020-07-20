<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStatisticalAnalysis
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGVStatisticalAnalysis = New System.Windows.Forms.DataGridView()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnAnalysisByOffenseType = New System.Windows.Forms.Button()
        Me.TotalSchoolPopulation = New System.Windows.Forms.TextBox()
        Me.BtnOverallOffenseAnalysis = New System.Windows.Forms.Button()
        Me.LblBeginningDate = New System.Windows.Forms.Label()
        Me.LblEndingDate = New System.Windows.Forms.Label()
        Me.DtpBeginningDate = New System.Windows.Forms.DateTimePicker()
        Me.DtpEndingDate = New System.Windows.Forms.DateTimePicker()
        Me.BtnGenerateOffenseCategoriesChart = New System.Windows.Forms.Button()
        Me.TotalNumberOfOffenses = New System.Windows.Forms.TextBox()
        Me.BtnOverallIndisciplinePercentages = New System.Windows.Forms.Button()
        Me.BtnGenerateIndisciplineCases2report = New System.Windows.Forms.Button()
        Me.BtnViewLeavers = New System.Windows.Forms.Button()
        Me.GbOffenseCountsCharts = New System.Windows.Forms.GroupBox()
        Me.BtnGenderDisciplineStatistics = New System.Windows.Forms.Button()
        Me.BtnMajorVsMinorOffencesPercentages = New System.Windows.Forms.Button()
        Me.BtnMinorOffencesDormStatistics = New System.Windows.Forms.Button()
        Me.BtnMinorOffencesClassStatistics = New System.Windows.Forms.Button()
        Me.BtnMajorOffencesClassStatistics = New System.Windows.Forms.Button()
        Me.BtnMajorOffencesDormStatistics = New System.Windows.Forms.Button()
        Me.BtnClassOffenseCategoriesChart = New System.Windows.Forms.Button()
        Me.BtnDormitoryOffenseCategoriesChart = New System.Windows.Forms.Button()
        Me.BtnGenderOffenceAnalysis = New System.Windows.Forms.Button()
        Me.BtnIndividualMwanafunzi = New System.Windows.Forms.Button()
        Me.GbNamesOfIndisciplinedStudents = New System.Windows.Forms.GroupBox()
        Me.CombStream = New System.Windows.Forms.ComboBox()
        Me.CombClass = New System.Windows.Forms.ComboBox()
        Me.BtnIndisciplinedStudentsBySingleClass = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnMinorOffensesPerDorm = New System.Windows.Forms.Button()
        Me.BtnMajorOffensesPerDorm = New System.Windows.Forms.Button()
        Me.MinorOffensesPerClass = New System.Windows.Forms.Button()
        Me.MajorOffensesPerClass = New System.Windows.Forms.Button()
        Me.BtnPendingPunishment = New System.Windows.Forms.Button()
        Me.BtnIndisciplinedStudentsByDormitory = New System.Windows.Forms.Button()
        Me.BtnIndisciplinedStudentsByClass = New System.Windows.Forms.Button()
        Me.GrpSingleStudent = New System.Windows.Forms.GroupBox()
        Me.BtnAllStudentsDispCard = New System.Windows.Forms.Button()
        Me.LblSelectaStudent = New System.Windows.Forms.Label()
        Me.ComboADMNO = New System.Windows.Forms.ComboBox()
        Me.BtnSubjects = New System.Windows.Forms.Button()
        Me.LlbOR = New System.Windows.Forms.Label()
        Me.LblDoubleclickonStudent = New System.Windows.Forms.Label()
        Me.txtNameToSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearchByName = New System.Windows.Forms.Button()
        Me.dgvSearchName = New System.Windows.Forms.DataGridView()
        Me.LblTotalSchoolPopulation = New System.Windows.Forms.Label()
        Me.BtnStudentOffenceNarration = New System.Windows.Forms.Button()
        Me.txtCurrentYear = New System.Windows.Forms.TextBox()
        Me.BtnPrintAllYears = New System.Windows.Forms.Button()
        Me.BtnClassEnrolment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CombClass2 = New System.Windows.Forms.ComboBox()
        Me.CombStream2 = New System.Windows.Forms.ComboBox()
        Me.BtnClassLists = New System.Windows.Forms.Button()
        CType(Me.DGVStatisticalAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbOffenseCountsCharts.SuspendLayout()
        Me.GbNamesOfIndisciplinedStudents.SuspendLayout()
        Me.GrpSingleStudent.SuspendLayout()
        CType(Me.dgvSearchName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVStatisticalAnalysis
        '
        Me.DGVStatisticalAnalysis.AllowUserToOrderColumns = True
        Me.DGVStatisticalAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVStatisticalAnalysis.Location = New System.Drawing.Point(549, 510)
        Me.DGVStatisticalAnalysis.Name = "DGVStatisticalAnalysis"
        Me.DGVStatisticalAnalysis.Size = New System.Drawing.Size(314, 33)
        Me.DGVStatisticalAnalysis.TabIndex = 0
        Me.DGVStatisticalAnalysis.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.LightYellow
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(12, 473)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(116, 23)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnAnalysisByOffenseType
        '
        Me.BtnAnalysisByOffenseType.BackColor = System.Drawing.Color.LightYellow
        Me.BtnAnalysisByOffenseType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnalysisByOffenseType.Location = New System.Drawing.Point(869, 503)
        Me.BtnAnalysisByOffenseType.Name = "BtnAnalysisByOffenseType"
        Me.BtnAnalysisByOffenseType.Size = New System.Drawing.Size(180, 23)
        Me.BtnAnalysisByOffenseType.TabIndex = 9
        Me.BtnAnalysisByOffenseType.Text = "Analysis By Offense Category"
        Me.BtnAnalysisByOffenseType.UseVisualStyleBackColor = False
        Me.BtnAnalysisByOffenseType.Visible = False
        '
        'TotalSchoolPopulation
        '
        Me.TotalSchoolPopulation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSchoolPopulation.Location = New System.Drawing.Point(967, 32)
        Me.TotalSchoolPopulation.Name = "TotalSchoolPopulation"
        Me.TotalSchoolPopulation.ReadOnly = True
        Me.TotalSchoolPopulation.Size = New System.Drawing.Size(114, 29)
        Me.TotalSchoolPopulation.TabIndex = 11
        '
        'BtnOverallOffenseAnalysis
        '
        Me.BtnOverallOffenseAnalysis.BackColor = System.Drawing.Color.LightYellow
        Me.BtnOverallOffenseAnalysis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOverallOffenseAnalysis.Location = New System.Drawing.Point(1055, 503)
        Me.BtnOverallOffenseAnalysis.Name = "BtnOverallOffenseAnalysis"
        Me.BtnOverallOffenseAnalysis.Size = New System.Drawing.Size(145, 23)
        Me.BtnOverallOffenseAnalysis.TabIndex = 13
        Me.BtnOverallOffenseAnalysis.Text = "Overall Offense Analysis "
        Me.BtnOverallOffenseAnalysis.UseVisualStyleBackColor = False
        Me.BtnOverallOffenseAnalysis.Visible = False
        '
        'LblBeginningDate
        '
        Me.LblBeginningDate.AutoSize = True
        Me.LblBeginningDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBeginningDate.ForeColor = System.Drawing.Color.Fuchsia
        Me.LblBeginningDate.Location = New System.Drawing.Point(39, 16)
        Me.LblBeginningDate.Name = "LblBeginningDate"
        Me.LblBeginningDate.Size = New System.Drawing.Size(153, 16)
        Me.LblBeginningDate.TabIndex = 16
        Me.LblBeginningDate.Text = "Enter beginning Date"
        '
        'LblEndingDate
        '
        Me.LblEndingDate.AutoSize = True
        Me.LblEndingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEndingDate.ForeColor = System.Drawing.Color.Fuchsia
        Me.LblEndingDate.Location = New System.Drawing.Point(238, 16)
        Me.LblEndingDate.Name = "LblEndingDate"
        Me.LblEndingDate.Size = New System.Drawing.Size(133, 16)
        Me.LblEndingDate.TabIndex = 17
        Me.LblEndingDate.Text = "Enter Ending Date"
        '
        'DtpBeginningDate
        '
        Me.DtpBeginningDate.CustomFormat = ""
        Me.DtpBeginningDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpBeginningDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpBeginningDate.Location = New System.Drawing.Point(44, 35)
        Me.DtpBeginningDate.Name = "DtpBeginningDate"
        Me.DtpBeginningDate.Size = New System.Drawing.Size(142, 29)
        Me.DtpBeginningDate.TabIndex = 18
        Me.DtpBeginningDate.Value = New Date(2017, 8, 5, 22, 54, 42, 0)
        '
        'DtpEndingDate
        '
        Me.DtpEndingDate.CustomFormat = ""
        Me.DtpEndingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpEndingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpEndingDate.Location = New System.Drawing.Point(240, 35)
        Me.DtpEndingDate.Name = "DtpEndingDate"
        Me.DtpEndingDate.Size = New System.Drawing.Size(142, 29)
        Me.DtpEndingDate.TabIndex = 19
        Me.DtpEndingDate.Value = New Date(2017, 10, 4, 0, 0, 0, 0)
        '
        'BtnGenerateOffenseCategoriesChart
        '
        Me.BtnGenerateOffenseCategoriesChart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerateOffenseCategoriesChart.ForeColor = System.Drawing.Color.Green
        Me.BtnGenerateOffenseCategoriesChart.Location = New System.Drawing.Point(19, 40)
        Me.BtnGenerateOffenseCategoriesChart.Name = "BtnGenerateOffenseCategoriesChart"
        Me.BtnGenerateOffenseCategoriesChart.Size = New System.Drawing.Size(315, 23)
        Me.BtnGenerateOffenseCategoriesChart.TabIndex = 20
        Me.BtnGenerateOffenseCategoriesChart.Text = "Overall Offense Categories Chart & Statistics"
        Me.BtnGenerateOffenseCategoriesChart.UseVisualStyleBackColor = True
        '
        'TotalNumberOfOffenses
        '
        Me.TotalNumberOfOffenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalNumberOfOffenses.Location = New System.Drawing.Point(1152, 61)
        Me.TotalNumberOfOffenses.Name = "TotalNumberOfOffenses"
        Me.TotalNumberOfOffenses.Size = New System.Drawing.Size(48, 26)
        Me.TotalNumberOfOffenses.TabIndex = 22
        Me.TotalNumberOfOffenses.Visible = False
        '
        'BtnOverallIndisciplinePercentages
        '
        Me.BtnOverallIndisciplinePercentages.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOverallIndisciplinePercentages.ForeColor = System.Drawing.Color.Green
        Me.BtnOverallIndisciplinePercentages.Location = New System.Drawing.Point(19, 156)
        Me.BtnOverallIndisciplinePercentages.Name = "BtnOverallIndisciplinePercentages"
        Me.BtnOverallIndisciplinePercentages.Size = New System.Drawing.Size(316, 23)
        Me.BtnOverallIndisciplinePercentages.TabIndex = 23
        Me.BtnOverallIndisciplinePercentages.Text = "Overall Disciplined Vs Indisciplined Statistics"
        Me.BtnOverallIndisciplinePercentages.UseVisualStyleBackColor = True
        '
        'BtnGenerateIndisciplineCases2report
        '
        Me.BtnGenerateIndisciplineCases2report.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerateIndisciplineCases2report.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGenerateIndisciplineCases2report.Location = New System.Drawing.Point(21, 21)
        Me.BtnGenerateIndisciplineCases2report.Name = "BtnGenerateIndisciplineCases2report"
        Me.BtnGenerateIndisciplineCases2report.Size = New System.Drawing.Size(314, 23)
        Me.BtnGenerateIndisciplineCases2report.TabIndex = 24
        Me.BtnGenerateIndisciplineCases2report.Text = "View All Current Indisciplined Students"
        Me.BtnGenerateIndisciplineCases2report.UseVisualStyleBackColor = True
        '
        'BtnViewLeavers
        '
        Me.BtnViewLeavers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewLeavers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnViewLeavers.Location = New System.Drawing.Point(19, 196)
        Me.BtnViewLeavers.Name = "BtnViewLeavers"
        Me.BtnViewLeavers.Size = New System.Drawing.Size(276, 23)
        Me.BtnViewLeavers.TabIndex = 26
        Me.BtnViewLeavers.Text = "View Leavers"
        Me.BtnViewLeavers.UseVisualStyleBackColor = True
        Me.BtnViewLeavers.Visible = False
        '
        'GbOffenseCountsCharts
        '
        Me.GbOffenseCountsCharts.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GbOffenseCountsCharts.Controls.Add(Me.BtnGenderDisciplineStatistics)
        Me.GbOffenseCountsCharts.Controls.Add(Me.BtnMajorVsMinorOffencesPercentages)
        Me.GbOffenseCountsCharts.Controls.Add(Me.BtnMinorOffencesDormStatistics)
        Me.GbOffenseCountsCharts.Controls.Add(Me.BtnMinorOffencesClassStatistics)
        Me.GbOffenseCountsCharts.Controls.Add(Me.BtnMajorOffencesClassStatistics)
        Me.GbOffenseCountsCharts.Controls.Add(Me.BtnMajorOffencesDormStatistics)
        Me.GbOffenseCountsCharts.Controls.Add(Me.BtnClassOffenseCategoriesChart)
        Me.GbOffenseCountsCharts.Controls.Add(Me.BtnDormitoryOffenseCategoriesChart)
        Me.GbOffenseCountsCharts.Controls.Add(Me.BtnGenerateOffenseCategoriesChart)
        Me.GbOffenseCountsCharts.Controls.Add(Me.BtnOverallIndisciplinePercentages)
        Me.GbOffenseCountsCharts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbOffenseCountsCharts.ForeColor = System.Drawing.Color.Purple
        Me.GbOffenseCountsCharts.Location = New System.Drawing.Point(489, 67)
        Me.GbOffenseCountsCharts.Name = "GbOffenseCountsCharts"
        Me.GbOffenseCountsCharts.Size = New System.Drawing.Size(352, 390)
        Me.GbOffenseCountsCharts.TabIndex = 27
        Me.GbOffenseCountsCharts.TabStop = False
        Me.GbOffenseCountsCharts.Text = "OFFENSE COUNTS AND CHARTS"
        '
        'BtnGenderDisciplineStatistics
        '
        Me.BtnGenderDisciplineStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenderDisciplineStatistics.ForeColor = System.Drawing.Color.Green
        Me.BtnGenderDisciplineStatistics.Location = New System.Drawing.Point(18, 127)
        Me.BtnGenderDisciplineStatistics.Name = "BtnGenderDisciplineStatistics"
        Me.BtnGenderDisciplineStatistics.Size = New System.Drawing.Size(316, 23)
        Me.BtnGenderDisciplineStatistics.TabIndex = 36
        Me.BtnGenderDisciplineStatistics.Text = "Gender Offense Statistics"
        Me.BtnGenderDisciplineStatistics.UseVisualStyleBackColor = True
        '
        'BtnMajorVsMinorOffencesPercentages
        '
        Me.BtnMajorVsMinorOffencesPercentages.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMajorVsMinorOffencesPercentages.ForeColor = System.Drawing.Color.Green
        Me.BtnMajorVsMinorOffencesPercentages.Location = New System.Drawing.Point(19, 185)
        Me.BtnMajorVsMinorOffencesPercentages.Name = "BtnMajorVsMinorOffencesPercentages"
        Me.BtnMajorVsMinorOffencesPercentages.Size = New System.Drawing.Size(315, 23)
        Me.BtnMajorVsMinorOffencesPercentages.TabIndex = 35
        Me.BtnMajorVsMinorOffencesPercentages.Text = "Major Vs Minor Offences Comparison"
        Me.BtnMajorVsMinorOffencesPercentages.UseVisualStyleBackColor = True
        '
        'BtnMinorOffencesDormStatistics
        '
        Me.BtnMinorOffencesDormStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinorOffencesDormStatistics.ForeColor = System.Drawing.Color.Green
        Me.BtnMinorOffencesDormStatistics.Location = New System.Drawing.Point(19, 359)
        Me.BtnMinorOffencesDormStatistics.Name = "BtnMinorOffencesDormStatistics"
        Me.BtnMinorOffencesDormStatistics.Size = New System.Drawing.Size(315, 23)
        Me.BtnMinorOffencesDormStatistics.TabIndex = 34
        Me.BtnMinorOffencesDormStatistics.Text = "Minor Offences Dormitory Statistics"
        Me.BtnMinorOffencesDormStatistics.UseVisualStyleBackColor = True
        '
        'BtnMinorOffencesClassStatistics
        '
        Me.BtnMinorOffencesClassStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinorOffencesClassStatistics.ForeColor = System.Drawing.Color.Green
        Me.BtnMinorOffencesClassStatistics.Location = New System.Drawing.Point(20, 294)
        Me.BtnMinorOffencesClassStatistics.Name = "BtnMinorOffencesClassStatistics"
        Me.BtnMinorOffencesClassStatistics.Size = New System.Drawing.Size(315, 23)
        Me.BtnMinorOffencesClassStatistics.TabIndex = 29
        Me.BtnMinorOffencesClassStatistics.Text = "Minor Offences Class Statistics"
        Me.BtnMinorOffencesClassStatistics.UseVisualStyleBackColor = True
        '
        'BtnMajorOffencesClassStatistics
        '
        Me.BtnMajorOffencesClassStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMajorOffencesClassStatistics.ForeColor = System.Drawing.Color.Green
        Me.BtnMajorOffencesClassStatistics.Location = New System.Drawing.Point(20, 258)
        Me.BtnMajorOffencesClassStatistics.Name = "BtnMajorOffencesClassStatistics"
        Me.BtnMajorOffencesClassStatistics.Size = New System.Drawing.Size(315, 23)
        Me.BtnMajorOffencesClassStatistics.TabIndex = 28
        Me.BtnMajorOffencesClassStatistics.Text = "Major Offences Class Statistics"
        Me.BtnMajorOffencesClassStatistics.UseVisualStyleBackColor = True
        '
        'BtnMajorOffencesDormStatistics
        '
        Me.BtnMajorOffencesDormStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMajorOffencesDormStatistics.ForeColor = System.Drawing.Color.Green
        Me.BtnMajorOffencesDormStatistics.Location = New System.Drawing.Point(19, 330)
        Me.BtnMajorOffencesDormStatistics.Name = "BtnMajorOffencesDormStatistics"
        Me.BtnMajorOffencesDormStatistics.Size = New System.Drawing.Size(315, 23)
        Me.BtnMajorOffencesDormStatistics.TabIndex = 27
        Me.BtnMajorOffencesDormStatistics.Text = "Major Offences Dormitory Statistics"
        Me.BtnMajorOffencesDormStatistics.UseVisualStyleBackColor = True
        '
        'BtnClassOffenseCategoriesChart
        '
        Me.BtnClassOffenseCategoriesChart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClassOffenseCategoriesChart.ForeColor = System.Drawing.Color.Green
        Me.BtnClassOffenseCategoriesChart.Location = New System.Drawing.Point(19, 98)
        Me.BtnClassOffenseCategoriesChart.Name = "BtnClassOffenseCategoriesChart"
        Me.BtnClassOffenseCategoriesChart.Size = New System.Drawing.Size(315, 23)
        Me.BtnClassOffenseCategoriesChart.TabIndex = 25
        Me.BtnClassOffenseCategoriesChart.Text = "Overall Class Offense Statistics"
        Me.BtnClassOffenseCategoriesChart.UseVisualStyleBackColor = True
        '
        'BtnDormitoryOffenseCategoriesChart
        '
        Me.BtnDormitoryOffenseCategoriesChart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDormitoryOffenseCategoriesChart.ForeColor = System.Drawing.Color.Green
        Me.BtnDormitoryOffenseCategoriesChart.Location = New System.Drawing.Point(19, 69)
        Me.BtnDormitoryOffenseCategoriesChart.Name = "BtnDormitoryOffenseCategoriesChart"
        Me.BtnDormitoryOffenseCategoriesChart.Size = New System.Drawing.Size(315, 23)
        Me.BtnDormitoryOffenseCategoriesChart.TabIndex = 24
        Me.BtnDormitoryOffenseCategoriesChart.Text = "Overall Dormitory Offense Statistics"
        Me.BtnDormitoryOffenseCategoriesChart.UseVisualStyleBackColor = True
        '
        'BtnGenderOffenceAnalysis
        '
        Me.BtnGenderOffenceAnalysis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenderOffenceAnalysis.ForeColor = System.Drawing.Color.Green
        Me.BtnGenderOffenceAnalysis.Location = New System.Drawing.Point(931, 520)
        Me.BtnGenderOffenceAnalysis.Name = "BtnGenderOffenceAnalysis"
        Me.BtnGenderOffenceAnalysis.Size = New System.Drawing.Size(267, 23)
        Me.BtnGenderOffenceAnalysis.TabIndex = 26
        Me.BtnGenderOffenceAnalysis.Text = "Overall Gender Offense Statistics"
        Me.BtnGenderOffenceAnalysis.UseVisualStyleBackColor = True
        Me.BtnGenderOffenceAnalysis.Visible = False
        '
        'BtnIndividualMwanafunzi
        '
        Me.BtnIndividualMwanafunzi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIndividualMwanafunzi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnIndividualMwanafunzi.Location = New System.Drawing.Point(6, 40)
        Me.BtnIndividualMwanafunzi.Name = "BtnIndividualMwanafunzi"
        Me.BtnIndividualMwanafunzi.Size = New System.Drawing.Size(206, 23)
        Me.BtnIndividualMwanafunzi.TabIndex = 27
        Me.BtnIndividualMwanafunzi.Text = "A Student's Discipline Card"
        Me.BtnIndividualMwanafunzi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIndividualMwanafunzi.UseVisualStyleBackColor = True
        '
        'GbNamesOfIndisciplinedStudents
        '
        Me.GbNamesOfIndisciplinedStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GbNamesOfIndisciplinedStudents.Controls.Add(Me.CombStream)
        Me.GbNamesOfIndisciplinedStudents.Controls.Add(Me.CombClass)
        Me.GbNamesOfIndisciplinedStudents.Controls.Add(Me.BtnIndisciplinedStudentsBySingleClass)
        Me.GbNamesOfIndisciplinedStudents.Controls.Add(Me.Button1)
        Me.GbNamesOfIndisciplinedStudents.Controls.Add(Me.BtnMinorOffensesPerDorm)
        Me.GbNamesOfIndisciplinedStudents.Controls.Add(Me.BtnMajorOffensesPerDorm)
        Me.GbNamesOfIndisciplinedStudents.Controls.Add(Me.MinorOffensesPerClass)
        Me.GbNamesOfIndisciplinedStudents.Controls.Add(Me.MajorOffensesPerClass)
        Me.GbNamesOfIndisciplinedStudents.Controls.Add(Me.BtnPendingPunishment)
        Me.GbNamesOfIndisciplinedStudents.Controls.Add(Me.BtnIndisciplinedStudentsByDormitory)
        Me.GbNamesOfIndisciplinedStudents.Controls.Add(Me.BtnIndisciplinedStudentsByClass)
        Me.GbNamesOfIndisciplinedStudents.Controls.Add(Me.BtnViewLeavers)
        Me.GbNamesOfIndisciplinedStudents.Controls.Add(Me.BtnGenerateIndisciplineCases2report)
        Me.GbNamesOfIndisciplinedStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbNamesOfIndisciplinedStudents.ForeColor = System.Drawing.Color.Purple
        Me.GbNamesOfIndisciplinedStudents.Location = New System.Drawing.Point(21, 74)
        Me.GbNamesOfIndisciplinedStudents.Name = "GbNamesOfIndisciplinedStudents"
        Me.GbNamesOfIndisciplinedStudents.Size = New System.Drawing.Size(409, 383)
        Me.GbNamesOfIndisciplinedStudents.TabIndex = 28
        Me.GbNamesOfIndisciplinedStudents.TabStop = False
        Me.GbNamesOfIndisciplinedStudents.Text = "NAMES OF INDISCIPLINED STUDENTS"
        '
        'CombStream
        '
        Me.CombStream.FormattingEnabled = True
        Me.CombStream.Location = New System.Drawing.Point(285, 111)
        Me.CombStream.Name = "CombStream"
        Me.CombStream.Size = New System.Drawing.Size(124, 24)
        Me.CombStream.TabIndex = 51
        '
        'CombClass
        '
        Me.CombClass.FormattingEnabled = True
        Me.CombClass.Location = New System.Drawing.Point(285, 81)
        Me.CombClass.Name = "CombClass"
        Me.CombClass.Size = New System.Drawing.Size(124, 24)
        Me.CombClass.TabIndex = 50
        '
        'BtnIndisciplinedStudentsBySingleClass
        '
        Me.BtnIndisciplinedStudentsBySingleClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIndisciplinedStudentsBySingleClass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnIndisciplinedStudentsBySingleClass.Location = New System.Drawing.Point(15, 79)
        Me.BtnIndisciplinedStudentsBySingleClass.Name = "BtnIndisciplinedStudentsBySingleClass"
        Me.BtnIndisciplinedStudentsBySingleClass.Size = New System.Drawing.Size(279, 23)
        Me.BtnIndisciplinedStudentsBySingleClass.TabIndex = 35
        Me.BtnIndisciplinedStudentsBySingleClass.Text = "Indisciplined Students By single Class"
        Me.BtnIndisciplinedStudentsBySingleClass.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(878, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(276, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "View Leavers"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'BtnMinorOffensesPerDorm
        '
        Me.BtnMinorOffensesPerDorm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinorOffensesPerDorm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnMinorOffensesPerDorm.Location = New System.Drawing.Point(21, 349)
        Me.BtnMinorOffensesPerDorm.Name = "BtnMinorOffensesPerDorm"
        Me.BtnMinorOffensesPerDorm.Size = New System.Drawing.Size(276, 23)
        Me.BtnMinorOffensesPerDorm.TabIndex = 33
        Me.BtnMinorOffensesPerDorm.Text = "Minor Offenses Per Dorm"
        Me.BtnMinorOffensesPerDorm.UseVisualStyleBackColor = True
        '
        'BtnMajorOffensesPerDorm
        '
        Me.BtnMajorOffensesPerDorm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMajorOffensesPerDorm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnMajorOffensesPerDorm.Location = New System.Drawing.Point(21, 313)
        Me.BtnMajorOffensesPerDorm.Name = "BtnMajorOffensesPerDorm"
        Me.BtnMajorOffensesPerDorm.Size = New System.Drawing.Size(276, 23)
        Me.BtnMajorOffensesPerDorm.TabIndex = 32
        Me.BtnMajorOffensesPerDorm.Text = "Major Offenses Per Dorm"
        Me.BtnMajorOffensesPerDorm.UseVisualStyleBackColor = True
        '
        'MinorOffensesPerClass
        '
        Me.MinorOffensesPerClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinorOffensesPerClass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MinorOffensesPerClass.Location = New System.Drawing.Point(19, 277)
        Me.MinorOffensesPerClass.Name = "MinorOffensesPerClass"
        Me.MinorOffensesPerClass.Size = New System.Drawing.Size(276, 23)
        Me.MinorOffensesPerClass.TabIndex = 31
        Me.MinorOffensesPerClass.Text = "Minor Offenses Per Class"
        Me.MinorOffensesPerClass.UseVisualStyleBackColor = True
        '
        'MajorOffensesPerClass
        '
        Me.MajorOffensesPerClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MajorOffensesPerClass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MajorOffensesPerClass.Location = New System.Drawing.Point(19, 241)
        Me.MajorOffensesPerClass.Name = "MajorOffensesPerClass"
        Me.MajorOffensesPerClass.Size = New System.Drawing.Size(276, 23)
        Me.MajorOffensesPerClass.TabIndex = 30
        Me.MajorOffensesPerClass.Text = "Major Offenses Per Class"
        Me.MajorOffensesPerClass.UseVisualStyleBackColor = True
        '
        'BtnPendingPunishment
        '
        Me.BtnPendingPunishment.Location = New System.Drawing.Point(19, 178)
        Me.BtnPendingPunishment.Name = "BtnPendingPunishment"
        Me.BtnPendingPunishment.Size = New System.Drawing.Size(275, 23)
        Me.BtnPendingPunishment.TabIndex = 29
        Me.BtnPendingPunishment.Text = "Pending Punishment"
        Me.BtnPendingPunishment.UseVisualStyleBackColor = True
        '
        'BtnIndisciplinedStudentsByDormitory
        '
        Me.BtnIndisciplinedStudentsByDormitory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIndisciplinedStudentsByDormitory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnIndisciplinedStudentsByDormitory.Location = New System.Drawing.Point(19, 138)
        Me.BtnIndisciplinedStudentsByDormitory.Name = "BtnIndisciplinedStudentsByDormitory"
        Me.BtnIndisciplinedStudentsByDormitory.Size = New System.Drawing.Size(373, 23)
        Me.BtnIndisciplinedStudentsByDormitory.TabIndex = 28
        Me.BtnIndisciplinedStudentsByDormitory.Text = "View All Current Indisciplined Students By Dormitory"
        Me.BtnIndisciplinedStudentsByDormitory.UseVisualStyleBackColor = True
        '
        'BtnIndisciplinedStudentsByClass
        '
        Me.BtnIndisciplinedStudentsByClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIndisciplinedStudentsByClass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnIndisciplinedStudentsByClass.Location = New System.Drawing.Point(18, 50)
        Me.BtnIndisciplinedStudentsByClass.Name = "BtnIndisciplinedStudentsByClass"
        Me.BtnIndisciplinedStudentsByClass.Size = New System.Drawing.Size(385, 23)
        Me.BtnIndisciplinedStudentsByClass.TabIndex = 27
        Me.BtnIndisciplinedStudentsByClass.Text = "View All Current Indisciplined Students By All Classes"
        Me.BtnIndisciplinedStudentsByClass.UseVisualStyleBackColor = True
        '
        'GrpSingleStudent
        '
        Me.GrpSingleStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GrpSingleStudent.Controls.Add(Me.BtnAllStudentsDispCard)
        Me.GrpSingleStudent.Controls.Add(Me.BtnIndividualMwanafunzi)
        Me.GrpSingleStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSingleStudent.ForeColor = System.Drawing.Color.Purple
        Me.GrpSingleStudent.Location = New System.Drawing.Point(869, 67)
        Me.GrpSingleStudent.Name = "GrpSingleStudent"
        Me.GrpSingleStudent.Size = New System.Drawing.Size(222, 137)
        Me.GrpSingleStudent.TabIndex = 30
        Me.GrpSingleStudent.TabStop = False
        Me.GrpSingleStudent.Text = "STUDENT DISCIPLINE REPORT CARDS"
        '
        'BtnAllStudentsDispCard
        '
        Me.BtnAllStudentsDispCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAllStudentsDispCard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAllStudentsDispCard.Location = New System.Drawing.Point(2, 108)
        Me.BtnAllStudentsDispCard.Name = "BtnAllStudentsDispCard"
        Me.BtnAllStudentsDispCard.Size = New System.Drawing.Size(216, 23)
        Me.BtnAllStudentsDispCard.TabIndex = 28
        Me.BtnAllStudentsDispCard.Text = "All Students Discipline Cards"
        Me.BtnAllStudentsDispCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAllStudentsDispCard.UseVisualStyleBackColor = True
        Me.BtnAllStudentsDispCard.Visible = False
        '
        'LblSelectaStudent
        '
        Me.LblSelectaStudent.AutoSize = True
        Me.LblSelectaStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSelectaStudent.ForeColor = System.Drawing.Color.Fuchsia
        Me.LblSelectaStudent.Location = New System.Drawing.Point(1095, 95)
        Me.LblSelectaStudent.Name = "LblSelectaStudent"
        Me.LblSelectaStudent.Size = New System.Drawing.Size(105, 16)
        Me.LblSelectaStudent.TabIndex = 32
        Me.LblSelectaStudent.Text = "Pick ADM NO."
        '
        'ComboADMNO
        '
        Me.ComboADMNO.FormattingEnabled = True
        Me.ComboADMNO.Location = New System.Drawing.Point(1096, 111)
        Me.ComboADMNO.Name = "ComboADMNO"
        Me.ComboADMNO.Size = New System.Drawing.Size(93, 21)
        Me.ComboADMNO.TabIndex = 31
        '
        'BtnSubjects
        '
        Me.BtnSubjects.BackColor = System.Drawing.Color.LightYellow
        Me.BtnSubjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubjects.Location = New System.Drawing.Point(869, 532)
        Me.BtnSubjects.Name = "BtnSubjects"
        Me.BtnSubjects.Size = New System.Drawing.Size(101, 23)
        Me.BtnSubjects.TabIndex = 33
        Me.BtnSubjects.Text = "Subjects"
        Me.BtnSubjects.UseVisualStyleBackColor = False
        Me.BtnSubjects.Visible = False
        '
        'LlbOR
        '
        Me.LlbOR.AutoSize = True
        Me.LlbOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LlbOR.ForeColor = System.Drawing.Color.Blue
        Me.LlbOR.Location = New System.Drawing.Point(1119, 165)
        Me.LlbOR.Name = "LlbOR"
        Me.LlbOR.Size = New System.Drawing.Size(45, 25)
        Me.LlbOR.TabIndex = 44
        Me.LlbOR.Text = "OR"
        '
        'LblDoubleclickonStudent
        '
        Me.LblDoubleclickonStudent.AutoSize = True
        Me.LblDoubleclickonStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDoubleclickonStudent.ForeColor = System.Drawing.Color.Maroon
        Me.LblDoubleclickonStudent.Location = New System.Drawing.Point(896, 356)
        Me.LblDoubleclickonStudent.Name = "LblDoubleclickonStudent"
        Me.LblDoubleclickonStudent.Size = New System.Drawing.Size(294, 16)
        Me.LblDoubleclickonStudent.TabIndex = 43
        Me.LblDoubleclickonStudent.Text = "Double Click on a student's name to open"
        '
        'txtNameToSearch
        '
        Me.txtNameToSearch.Location = New System.Drawing.Point(892, 226)
        Me.txtNameToSearch.Name = "txtNameToSearch"
        Me.txtNameToSearch.Size = New System.Drawing.Size(171, 20)
        Me.txtNameToSearch.TabIndex = 42
        '
        'BtnSearchByName
        '
        Me.BtnSearchByName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchByName.Location = New System.Drawing.Point(1069, 222)
        Me.BtnSearchByName.Name = "BtnSearchByName"
        Me.BtnSearchByName.Size = New System.Drawing.Size(132, 24)
        Me.BtnSearchByName.TabIndex = 41
        Me.BtnSearchByName.Text = "Search By Name"
        Me.BtnSearchByName.UseVisualStyleBackColor = True
        '
        'dgvSearchName
        '
        Me.dgvSearchName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchName.Location = New System.Drawing.Point(892, 252)
        Me.dgvSearchName.Name = "dgvSearchName"
        Me.dgvSearchName.Size = New System.Drawing.Size(298, 101)
        Me.dgvSearchName.TabIndex = 40
        '
        'LblTotalSchoolPopulation
        '
        Me.LblTotalSchoolPopulation.AutoSize = True
        Me.LblTotalSchoolPopulation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalSchoolPopulation.ForeColor = System.Drawing.Color.Fuchsia
        Me.LblTotalSchoolPopulation.Location = New System.Drawing.Point(928, 16)
        Me.LblTotalSchoolPopulation.Name = "LblTotalSchoolPopulation"
        Me.LblTotalSchoolPopulation.Size = New System.Drawing.Size(169, 16)
        Me.LblTotalSchoolPopulation.TabIndex = 12
        Me.LblTotalSchoolPopulation.Text = "Total School Enrolment"
        '
        'BtnStudentOffenceNarration
        '
        Me.BtnStudentOffenceNarration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStudentOffenceNarration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnStudentOffenceNarration.Location = New System.Drawing.Point(871, 145)
        Me.BtnStudentOffenceNarration.Name = "BtnStudentOffenceNarration"
        Me.BtnStudentOffenceNarration.Size = New System.Drawing.Size(219, 23)
        Me.BtnStudentOffenceNarration.TabIndex = 45
        Me.BtnStudentOffenceNarration.Text = "A Student's Offence Narration"
        Me.BtnStudentOffenceNarration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStudentOffenceNarration.UseVisualStyleBackColor = True
        '
        'txtCurrentYear
        '
        Me.txtCurrentYear.Location = New System.Drawing.Point(1135, 35)
        Me.txtCurrentYear.Name = "txtCurrentYear"
        Me.txtCurrentYear.ReadOnly = True
        Me.txtCurrentYear.Size = New System.Drawing.Size(66, 20)
        Me.txtCurrentYear.TabIndex = 46
        '
        'BtnPrintAllYears
        '
        Me.BtnPrintAllYears.BackColor = System.Drawing.Color.LightYellow
        Me.BtnPrintAllYears.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintAllYears.Location = New System.Drawing.Point(297, 473)
        Me.BtnPrintAllYears.Name = "BtnPrintAllYears"
        Me.BtnPrintAllYears.Size = New System.Drawing.Size(230, 23)
        Me.BtnPrintAllYears.TabIndex = 47
        Me.BtnPrintAllYears.Text = "To Print Other Years Click here"
        Me.BtnPrintAllYears.UseVisualStyleBackColor = False
        '
        'BtnClassEnrolment
        '
        Me.BtnClassEnrolment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClassEnrolment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnClassEnrolment.Location = New System.Drawing.Point(931, 397)
        Me.BtnClassEnrolment.Name = "BtnClassEnrolment"
        Me.BtnClassEnrolment.Size = New System.Drawing.Size(228, 23)
        Me.BtnClassEnrolment.TabIndex = 48
        Me.BtnClassEnrolment.Text = "View Class Enrolment"
        Me.BtnClassEnrolment.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1148, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Year"
        '
        'CombClass2
        '
        Me.CombClass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombClass2.FormattingEnabled = True
        Me.CombClass2.Location = New System.Drawing.Point(1068, 438)
        Me.CombClass2.Name = "CombClass2"
        Me.CombClass2.Size = New System.Drawing.Size(121, 26)
        Me.CombClass2.TabIndex = 50
        '
        'CombStream2
        '
        Me.CombStream2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombStream2.FormattingEnabled = True
        Me.CombStream2.Location = New System.Drawing.Point(1069, 471)
        Me.CombStream2.Name = "CombStream2"
        Me.CombStream2.Size = New System.Drawing.Size(121, 26)
        Me.CombStream2.TabIndex = 51
        '
        'BtnClassLists
        '
        Me.BtnClassLists.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClassLists.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnClassLists.Location = New System.Drawing.Point(946, 455)
        Me.BtnClassLists.Name = "BtnClassLists"
        Me.BtnClassLists.Size = New System.Drawing.Size(103, 23)
        Me.BtnClassLists.TabIndex = 52
        Me.BtnClassLists.Text = "Class Lists"
        Me.BtnClassLists.UseVisualStyleBackColor = True
        '
        'frmStatisticalAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 558)
        Me.Controls.Add(Me.BtnClassLists)
        Me.Controls.Add(Me.CombStream2)
        Me.Controls.Add(Me.CombClass2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClassEnrolment)
        Me.Controls.Add(Me.BtnPrintAllYears)
        Me.Controls.Add(Me.txtCurrentYear)
        Me.Controls.Add(Me.BtnStudentOffenceNarration)
        Me.Controls.Add(Me.LlbOR)
        Me.Controls.Add(Me.LblDoubleclickonStudent)
        Me.Controls.Add(Me.txtNameToSearch)
        Me.Controls.Add(Me.BtnSearchByName)
        Me.Controls.Add(Me.dgvSearchName)
        Me.Controls.Add(Me.BtnSubjects)
        Me.Controls.Add(Me.BtnGenderOffenceAnalysis)
        Me.Controls.Add(Me.LblSelectaStudent)
        Me.Controls.Add(Me.ComboADMNO)
        Me.Controls.Add(Me.GrpSingleStudent)
        Me.Controls.Add(Me.GbNamesOfIndisciplinedStudents)
        Me.Controls.Add(Me.GbOffenseCountsCharts)
        Me.Controls.Add(Me.TotalNumberOfOffenses)
        Me.Controls.Add(Me.DtpEndingDate)
        Me.Controls.Add(Me.DtpBeginningDate)
        Me.Controls.Add(Me.LblEndingDate)
        Me.Controls.Add(Me.LblBeginningDate)
        Me.Controls.Add(Me.BtnOverallOffenseAnalysis)
        Me.Controls.Add(Me.LblTotalSchoolPopulation)
        Me.Controls.Add(Me.TotalSchoolPopulation)
        Me.Controls.Add(Me.BtnAnalysisByOffenseType)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.DGVStatisticalAnalysis)
        Me.Name = "frmStatisticalAnalysis"
        Me.ShowIcon = False
        Me.Text = "Offences Statistical Analysis and Printing (Current Year)"
        CType(Me.DGVStatisticalAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbOffenseCountsCharts.ResumeLayout(False)
        Me.GbNamesOfIndisciplinedStudents.ResumeLayout(False)
        Me.GrpSingleStudent.ResumeLayout(False)
        CType(Me.dgvSearchName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVStatisticalAnalysis As DataGridView
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnAnalysisByOffenseType As Button
    Friend WithEvents TotalSchoolPopulation As TextBox
    Friend WithEvents BtnOverallOffenseAnalysis As Button
    Friend WithEvents LblBeginningDate As Label
    Friend WithEvents LblEndingDate As Label
    Friend WithEvents DtpBeginningDate As DateTimePicker
    Friend WithEvents DtpEndingDate As DateTimePicker
    Friend WithEvents BtnGenerateOffenseCategoriesChart As Button
    Friend WithEvents TotalNumberOfOffenses As TextBox
    Friend WithEvents BtnOverallIndisciplinePercentages As Button
    Friend WithEvents BtnGenerateIndisciplineCases2report As Button
    Friend WithEvents BtnViewLeavers As Button
    Friend WithEvents GbOffenseCountsCharts As GroupBox
    Friend WithEvents GbNamesOfIndisciplinedStudents As GroupBox
    Friend WithEvents BtnIndisciplinedStudentsByClass As Button
    Friend WithEvents BtnIndisciplinedStudentsByDormitory As Button
    Friend WithEvents BtnDormitoryOffenseCategoriesChart As Button
    Friend WithEvents BtnClassOffenseCategoriesChart As Button
    Friend WithEvents BtnGenderOffenceAnalysis As Button
    Friend WithEvents BtnIndividualMwanafunzi As Button
    Friend WithEvents GrpSingleStudent As GroupBox
    Friend WithEvents LblSelectaStudent As Label
    Friend WithEvents ComboADMNO As ComboBox
    Friend WithEvents BtnSubjects As Button
    Friend WithEvents BtnPendingPunishment As Button
    Friend WithEvents MinorOffensesPerClass As Button
    Friend WithEvents MajorOffensesPerClass As Button
    Friend WithEvents BtnMinorOffensesPerDorm As Button
    Friend WithEvents BtnMajorOffensesPerDorm As Button
    Friend WithEvents BtnMinorOffencesDormStatistics As Button
    Friend WithEvents BtnMinorOffencesClassStatistics As Button
    Friend WithEvents BtnMajorOffencesClassStatistics As Button
    Friend WithEvents BtnMajorOffencesDormStatistics As Button
    Friend WithEvents BtnMajorVsMinorOffencesPercentages As Button
    Friend WithEvents LlbOR As Label
    Friend WithEvents LblDoubleclickonStudent As Label
    Friend WithEvents txtNameToSearch As TextBox
    Friend WithEvents BtnSearchByName As Button
    Friend WithEvents dgvSearchName As DataGridView
    Friend WithEvents BtnGenderDisciplineStatistics As Button
    Friend WithEvents LblTotalSchoolPopulation As Label
    Friend WithEvents BtnAllStudentsDispCard As Button
    Friend WithEvents BtnStudentOffenceNarration As Button
    Friend WithEvents txtCurrentYear As TextBox
    Friend WithEvents BtnPrintAllYears As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnClassEnrolment As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnIndisciplinedStudentsBySingleClass As Button
    Friend WithEvents CombClass As ComboBox
    Friend WithEvents CombStream As ComboBox
    Friend WithEvents CombClass2 As ComboBox
    Friend WithEvents CombStream2 As ComboBox
    Friend WithEvents BtnClassLists As Button
End Class
