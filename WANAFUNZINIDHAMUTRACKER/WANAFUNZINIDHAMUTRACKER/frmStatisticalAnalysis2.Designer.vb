<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatisticalAnalysis2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnMinorOffensesPerDorm = New System.Windows.Forms.Button()
        Me.MinorOffensesPerClass = New System.Windows.Forms.Button()
        Me.MajorOffensesPerClass = New System.Windows.Forms.Button()
        Me.BtnGenderDisciplineStatistics = New System.Windows.Forms.Button()
        Me.BtnMajorVsMinorOffencesPercentages = New System.Windows.Forms.Button()
        Me.BtnMinorOffencesDormStatistics = New System.Windows.Forms.Button()
        Me.BtnMinorOffencesClassStatistics = New System.Windows.Forms.Button()
        Me.BtnMajorOffencesClassStatistics = New System.Windows.Forms.Button()
        Me.BtnMajorOffencesDormStatistics = New System.Windows.Forms.Button()
        Me.BtnClassOffenseCategoriesChart = New System.Windows.Forms.Button()
        Me.BtnMajorOffensesPerDorm = New System.Windows.Forms.Button()
        Me.BtnPendingPunishment = New System.Windows.Forms.Button()
        Me.BtnIndisciplinedStudentsByDormitory = New System.Windows.Forms.Button()
        Me.BtnIndisciplinedStudentsByClass = New System.Windows.Forms.Button()
        Me.BtnAllStudentsDispCard = New System.Windows.Forms.Button()
        Me.LlbOR = New System.Windows.Forms.Label()
        Me.LblDoubleclickonStudent = New System.Windows.Forms.Label()
        Me.txtNameToSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearchByName = New System.Windows.Forms.Button()
        Me.dgvSearchName = New System.Windows.Forms.DataGridView()
        Me.BtnSubjects = New System.Windows.Forms.Button()
        Me.LblSelectaStudent = New System.Windows.Forms.Label()
        Me.ComboADMNO = New System.Windows.Forms.ComboBox()
        Me.GrpSingleStudent = New System.Windows.Forms.GroupBox()
        Me.BtnBtnStudentOffenceNarration2 = New System.Windows.Forms.Button()
        Me.BtnIndividualMwanafunzi = New System.Windows.Forms.Button()
        Me.LblTotalSchoolPopulation = New System.Windows.Forms.Label()
        Me.BtnDormitoryOffenseCategoriesChart = New System.Windows.Forms.Button()
        Me.BtnStudentOffenceNarration = New System.Windows.Forms.Button()
        Me.BtnGenderOffenceAnalysis = New System.Windows.Forms.Button()
        Me.GbNamesOfIndisciplinedStudents = New System.Windows.Forms.GroupBox()
        Me.BtnViewLeavers = New System.Windows.Forms.Button()
        Me.BtnGenerateIndisciplineCases2report = New System.Windows.Forms.Button()
        Me.GbOffenseCountsCharts = New System.Windows.Forms.GroupBox()
        Me.BtnGenerateOffenseCategoriesChart = New System.Windows.Forms.Button()
        Me.BtnOverallIndisciplinePercentages = New System.Windows.Forms.Button()
        Me.TotalNumberOfOffenses = New System.Windows.Forms.TextBox()
        Me.DtpEndingDate = New System.Windows.Forms.DateTimePicker()
        Me.DtpBeginningDate = New System.Windows.Forms.DateTimePicker()
        Me.LblEndingDate = New System.Windows.Forms.Label()
        Me.LblBeginningDate = New System.Windows.Forms.Label()
        Me.BtnOverallOffenseAnalysis = New System.Windows.Forms.Button()
        Me.TotalSchoolPopulation = New System.Windows.Forms.TextBox()
        Me.BtnAnalysisByOffenseType = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.DGVStatisticalAnalysis = New System.Windows.Forms.DataGridView()
        Me.CombAllYears = New System.Windows.Forms.ComboBox()
        Me.LblCombAllYears = New System.Windows.Forms.Label()
        Me.BtnClassEnrolment = New System.Windows.Forms.Button()
        CType(Me.dgvSearchName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSingleStudent.SuspendLayout()
        Me.GbNamesOfIndisciplinedStudents.SuspendLayout()
        Me.GbOffenseCountsCharts.SuspendLayout()
        CType(Me.DGVStatisticalAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'BtnPendingPunishment
        '
        Me.BtnPendingPunishment.Location = New System.Drawing.Point(19, 145)
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
        Me.BtnIndisciplinedStudentsByDormitory.Location = New System.Drawing.Point(19, 107)
        Me.BtnIndisciplinedStudentsByDormitory.Name = "BtnIndisciplinedStudentsByDormitory"
        Me.BtnIndisciplinedStudentsByDormitory.Size = New System.Drawing.Size(373, 23)
        Me.BtnIndisciplinedStudentsByDormitory.TabIndex = 28
        Me.BtnIndisciplinedStudentsByDormitory.Text = "View All past Indisciplined Students By Dormitory"
        Me.BtnIndisciplinedStudentsByDormitory.UseVisualStyleBackColor = True
        '
        'BtnIndisciplinedStudentsByClass
        '
        Me.BtnIndisciplinedStudentsByClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIndisciplinedStudentsByClass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnIndisciplinedStudentsByClass.Location = New System.Drawing.Point(19, 71)
        Me.BtnIndisciplinedStudentsByClass.Name = "BtnIndisciplinedStudentsByClass"
        Me.BtnIndisciplinedStudentsByClass.Size = New System.Drawing.Size(345, 23)
        Me.BtnIndisciplinedStudentsByClass.TabIndex = 27
        Me.BtnIndisciplinedStudentsByClass.Text = "View All past Indisciplined Students By Class"
        Me.BtnIndisciplinedStudentsByClass.UseVisualStyleBackColor = True
        '
        'BtnAllStudentsDispCard
        '
        Me.BtnAllStudentsDispCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAllStudentsDispCard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAllStudentsDispCard.Location = New System.Drawing.Point(2, 114)
        Me.BtnAllStudentsDispCard.Name = "BtnAllStudentsDispCard"
        Me.BtnAllStudentsDispCard.Size = New System.Drawing.Size(216, 23)
        Me.BtnAllStudentsDispCard.TabIndex = 28
        Me.BtnAllStudentsDispCard.Text = "All Students Discipline Cards"
        Me.BtnAllStudentsDispCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAllStudentsDispCard.UseVisualStyleBackColor = True
        Me.BtnAllStudentsDispCard.Visible = False
        '
        'LlbOR
        '
        Me.LlbOR.AutoSize = True
        Me.LlbOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LlbOR.ForeColor = System.Drawing.Color.Blue
        Me.LlbOR.Location = New System.Drawing.Point(1138, 166)
        Me.LlbOR.Name = "LlbOR"
        Me.LlbOR.Size = New System.Drawing.Size(45, 25)
        Me.LlbOR.TabIndex = 69
        Me.LlbOR.Text = "OR"
        '
        'LblDoubleclickonStudent
        '
        Me.LblDoubleclickonStudent.AutoSize = True
        Me.LblDoubleclickonStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDoubleclickonStudent.ForeColor = System.Drawing.Color.Maroon
        Me.LblDoubleclickonStudent.Location = New System.Drawing.Point(915, 357)
        Me.LblDoubleclickonStudent.Name = "LblDoubleclickonStudent"
        Me.LblDoubleclickonStudent.Size = New System.Drawing.Size(294, 16)
        Me.LblDoubleclickonStudent.TabIndex = 68
        Me.LblDoubleclickonStudent.Text = "Double Click on a student's name to open"
        '
        'txtNameToSearch
        '
        Me.txtNameToSearch.Location = New System.Drawing.Point(911, 227)
        Me.txtNameToSearch.Name = "txtNameToSearch"
        Me.txtNameToSearch.Size = New System.Drawing.Size(171, 20)
        Me.txtNameToSearch.TabIndex = 67
        '
        'BtnSearchByName
        '
        Me.BtnSearchByName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchByName.Location = New System.Drawing.Point(1088, 223)
        Me.BtnSearchByName.Name = "BtnSearchByName"
        Me.BtnSearchByName.Size = New System.Drawing.Size(132, 24)
        Me.BtnSearchByName.TabIndex = 66
        Me.BtnSearchByName.Text = "Search By Name"
        Me.BtnSearchByName.UseVisualStyleBackColor = True
        '
        'dgvSearchName
        '
        Me.dgvSearchName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchName.Location = New System.Drawing.Point(911, 253)
        Me.dgvSearchName.Name = "dgvSearchName"
        Me.dgvSearchName.Size = New System.Drawing.Size(298, 101)
        Me.dgvSearchName.TabIndex = 65
        '
        'BtnSubjects
        '
        Me.BtnSubjects.BackColor = System.Drawing.Color.LightYellow
        Me.BtnSubjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubjects.Location = New System.Drawing.Point(888, 486)
        Me.BtnSubjects.Name = "BtnSubjects"
        Me.BtnSubjects.Size = New System.Drawing.Size(101, 23)
        Me.BtnSubjects.TabIndex = 64
        Me.BtnSubjects.Text = "Subjects"
        Me.BtnSubjects.UseVisualStyleBackColor = False
        Me.BtnSubjects.Visible = False
        '
        'LblSelectaStudent
        '
        Me.LblSelectaStudent.AutoSize = True
        Me.LblSelectaStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSelectaStudent.ForeColor = System.Drawing.Color.Fuchsia
        Me.LblSelectaStudent.Location = New System.Drawing.Point(1114, 96)
        Me.LblSelectaStudent.Name = "LblSelectaStudent"
        Me.LblSelectaStudent.Size = New System.Drawing.Size(105, 16)
        Me.LblSelectaStudent.TabIndex = 63
        Me.LblSelectaStudent.Text = "Pick ADM NO."
        '
        'ComboADMNO
        '
        Me.ComboADMNO.FormattingEnabled = True
        Me.ComboADMNO.Location = New System.Drawing.Point(1115, 112)
        Me.ComboADMNO.Name = "ComboADMNO"
        Me.ComboADMNO.Size = New System.Drawing.Size(93, 21)
        Me.ComboADMNO.TabIndex = 62
        '
        'GrpSingleStudent
        '
        Me.GrpSingleStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GrpSingleStudent.Controls.Add(Me.BtnBtnStudentOffenceNarration2)
        Me.GrpSingleStudent.Controls.Add(Me.BtnAllStudentsDispCard)
        Me.GrpSingleStudent.Controls.Add(Me.BtnIndividualMwanafunzi)
        Me.GrpSingleStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSingleStudent.ForeColor = System.Drawing.Color.Purple
        Me.GrpSingleStudent.Location = New System.Drawing.Point(888, 68)
        Me.GrpSingleStudent.Name = "GrpSingleStudent"
        Me.GrpSingleStudent.Size = New System.Drawing.Size(222, 137)
        Me.GrpSingleStudent.TabIndex = 61
        Me.GrpSingleStudent.TabStop = False
        Me.GrpSingleStudent.Text = "STUDENT DISCIPLINE REPORT CARDS"
        '
        'BtnBtnStudentOffenceNarration2
        '
        Me.BtnBtnStudentOffenceNarration2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBtnStudentOffenceNarration2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBtnStudentOffenceNarration2.Location = New System.Drawing.Point(2, 78)
        Me.BtnBtnStudentOffenceNarration2.Name = "BtnBtnStudentOffenceNarration2"
        Me.BtnBtnStudentOffenceNarration2.Size = New System.Drawing.Size(219, 23)
        Me.BtnBtnStudentOffenceNarration2.TabIndex = 46
        Me.BtnBtnStudentOffenceNarration2.Text = "A Student's Offence Narration"
        Me.BtnBtnStudentOffenceNarration2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBtnStudentOffenceNarration2.UseVisualStyleBackColor = True
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
        'LblTotalSchoolPopulation
        '
        Me.LblTotalSchoolPopulation.AutoSize = True
        Me.LblTotalSchoolPopulation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalSchoolPopulation.ForeColor = System.Drawing.Color.BlueViolet
        Me.LblTotalSchoolPopulation.Location = New System.Drawing.Point(1014, 14)
        Me.LblTotalSchoolPopulation.Name = "LblTotalSchoolPopulation"
        Me.LblTotalSchoolPopulation.Size = New System.Drawing.Size(169, 16)
        Me.LblTotalSchoolPopulation.TabIndex = 51
        Me.LblTotalSchoolPopulation.Text = "Total School Enrolment"
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
        'BtnStudentOffenceNarration
        '
        Me.BtnStudentOffenceNarration.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStudentOffenceNarration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnStudentOffenceNarration.Location = New System.Drawing.Point(890, 146)
        Me.BtnStudentOffenceNarration.Name = "BtnStudentOffenceNarration"
        Me.BtnStudentOffenceNarration.Size = New System.Drawing.Size(219, 23)
        Me.BtnStudentOffenceNarration.TabIndex = 70
        Me.BtnStudentOffenceNarration.Text = "A Student's Offence Narration"
        Me.BtnStudentOffenceNarration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStudentOffenceNarration.UseVisualStyleBackColor = True
        '
        'BtnGenderOffenceAnalysis
        '
        Me.BtnGenderOffenceAnalysis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenderOffenceAnalysis.ForeColor = System.Drawing.Color.Green
        Me.BtnGenderOffenceAnalysis.Location = New System.Drawing.Point(526, 474)
        Me.BtnGenderOffenceAnalysis.Name = "BtnGenderOffenceAnalysis"
        Me.BtnGenderOffenceAnalysis.Size = New System.Drawing.Size(316, 23)
        Me.BtnGenderOffenceAnalysis.TabIndex = 58
        Me.BtnGenderOffenceAnalysis.Text = "Overall Gender Offense Statistics"
        Me.BtnGenderOffenceAnalysis.UseVisualStyleBackColor = True
        Me.BtnGenderOffenceAnalysis.Visible = False
        '
        'GbNamesOfIndisciplinedStudents
        '
        Me.GbNamesOfIndisciplinedStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
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
        Me.GbNamesOfIndisciplinedStudents.Location = New System.Drawing.Point(40, 75)
        Me.GbNamesOfIndisciplinedStudents.Name = "GbNamesOfIndisciplinedStudents"
        Me.GbNamesOfIndisciplinedStudents.Size = New System.Drawing.Size(409, 383)
        Me.GbNamesOfIndisciplinedStudents.TabIndex = 60
        Me.GbNamesOfIndisciplinedStudents.TabStop = False
        Me.GbNamesOfIndisciplinedStudents.Text = "NAMES OF INDISCIPLINED STUDENTS"
        '
        'BtnViewLeavers
        '
        Me.BtnViewLeavers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewLeavers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnViewLeavers.Location = New System.Drawing.Point(19, 174)
        Me.BtnViewLeavers.Name = "BtnViewLeavers"
        Me.BtnViewLeavers.Size = New System.Drawing.Size(276, 23)
        Me.BtnViewLeavers.TabIndex = 26
        Me.BtnViewLeavers.Text = "View Leavers"
        Me.BtnViewLeavers.UseVisualStyleBackColor = True
        Me.BtnViewLeavers.Visible = False
        '
        'BtnGenerateIndisciplineCases2report
        '
        Me.BtnGenerateIndisciplineCases2report.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerateIndisciplineCases2report.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnGenerateIndisciplineCases2report.Location = New System.Drawing.Point(19, 33)
        Me.BtnGenerateIndisciplineCases2report.Name = "BtnGenerateIndisciplineCases2report"
        Me.BtnGenerateIndisciplineCases2report.Size = New System.Drawing.Size(314, 23)
        Me.BtnGenerateIndisciplineCases2report.TabIndex = 24
        Me.BtnGenerateIndisciplineCases2report.Text = "View All Past Indisciplined Students"
        Me.BtnGenerateIndisciplineCases2report.UseVisualStyleBackColor = True
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
        Me.GbOffenseCountsCharts.Location = New System.Drawing.Point(508, 68)
        Me.GbOffenseCountsCharts.Name = "GbOffenseCountsCharts"
        Me.GbOffenseCountsCharts.Size = New System.Drawing.Size(352, 390)
        Me.GbOffenseCountsCharts.TabIndex = 59
        Me.GbOffenseCountsCharts.TabStop = False
        Me.GbOffenseCountsCharts.Text = "OFFENSE COUNTS AND CHARTS"
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
        'TotalNumberOfOffenses
        '
        Me.TotalNumberOfOffenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalNumberOfOffenses.Location = New System.Drawing.Point(1193, 17)
        Me.TotalNumberOfOffenses.Name = "TotalNumberOfOffenses"
        Me.TotalNumberOfOffenses.Size = New System.Drawing.Size(45, 26)
        Me.TotalNumberOfOffenses.TabIndex = 57
        Me.TotalNumberOfOffenses.Visible = False
        '
        'DtpEndingDate
        '
        Me.DtpEndingDate.CustomFormat = ""
        Me.DtpEndingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpEndingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpEndingDate.Location = New System.Drawing.Point(257, 36)
        Me.DtpEndingDate.Name = "DtpEndingDate"
        Me.DtpEndingDate.Size = New System.Drawing.Size(142, 29)
        Me.DtpEndingDate.TabIndex = 56
        Me.DtpEndingDate.Value = New Date(2017, 10, 4, 0, 0, 0, 0)
        '
        'DtpBeginningDate
        '
        Me.DtpBeginningDate.CustomFormat = ""
        Me.DtpBeginningDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpBeginningDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpBeginningDate.Location = New System.Drawing.Point(61, 36)
        Me.DtpBeginningDate.Name = "DtpBeginningDate"
        Me.DtpBeginningDate.Size = New System.Drawing.Size(142, 29)
        Me.DtpBeginningDate.TabIndex = 55
        Me.DtpBeginningDate.Value = New Date(2017, 8, 5, 22, 54, 42, 0)
        '
        'LblEndingDate
        '
        Me.LblEndingDate.AutoSize = True
        Me.LblEndingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEndingDate.ForeColor = System.Drawing.Color.Fuchsia
        Me.LblEndingDate.Location = New System.Drawing.Point(255, 17)
        Me.LblEndingDate.Name = "LblEndingDate"
        Me.LblEndingDate.Size = New System.Drawing.Size(133, 16)
        Me.LblEndingDate.TabIndex = 54
        Me.LblEndingDate.Text = "Enter Ending Date"
        '
        'LblBeginningDate
        '
        Me.LblBeginningDate.AutoSize = True
        Me.LblBeginningDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBeginningDate.ForeColor = System.Drawing.Color.Fuchsia
        Me.LblBeginningDate.Location = New System.Drawing.Point(56, 17)
        Me.LblBeginningDate.Name = "LblBeginningDate"
        Me.LblBeginningDate.Size = New System.Drawing.Size(153, 16)
        Me.LblBeginningDate.TabIndex = 53
        Me.LblBeginningDate.Text = "Enter beginning Date"
        '
        'BtnOverallOffenseAnalysis
        '
        Me.BtnOverallOffenseAnalysis.BackColor = System.Drawing.Color.LightYellow
        Me.BtnOverallOffenseAnalysis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOverallOffenseAnalysis.Location = New System.Drawing.Point(1074, 457)
        Me.BtnOverallOffenseAnalysis.Name = "BtnOverallOffenseAnalysis"
        Me.BtnOverallOffenseAnalysis.Size = New System.Drawing.Size(145, 23)
        Me.BtnOverallOffenseAnalysis.TabIndex = 52
        Me.BtnOverallOffenseAnalysis.Text = "Overall Offense Analysis "
        Me.BtnOverallOffenseAnalysis.UseVisualStyleBackColor = False
        Me.BtnOverallOffenseAnalysis.Visible = False
        '
        'TotalSchoolPopulation
        '
        Me.TotalSchoolPopulation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSchoolPopulation.Location = New System.Drawing.Point(1017, 33)
        Me.TotalSchoolPopulation.Name = "TotalSchoolPopulation"
        Me.TotalSchoolPopulation.Size = New System.Drawing.Size(114, 29)
        Me.TotalSchoolPopulation.TabIndex = 50
        '
        'BtnAnalysisByOffenseType
        '
        Me.BtnAnalysisByOffenseType.BackColor = System.Drawing.Color.LightYellow
        Me.BtnAnalysisByOffenseType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnalysisByOffenseType.Location = New System.Drawing.Point(888, 457)
        Me.BtnAnalysisByOffenseType.Name = "BtnAnalysisByOffenseType"
        Me.BtnAnalysisByOffenseType.Size = New System.Drawing.Size(180, 23)
        Me.BtnAnalysisByOffenseType.TabIndex = 49
        Me.BtnAnalysisByOffenseType.Text = "Analysis By Offense Category"
        Me.BtnAnalysisByOffenseType.UseVisualStyleBackColor = False
        Me.BtnAnalysisByOffenseType.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.LightYellow
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(31, 474)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(116, 23)
        Me.BtnClose.TabIndex = 48
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'DGVStatisticalAnalysis
        '
        Me.DGVStatisticalAnalysis.AllowUserToOrderColumns = True
        Me.DGVStatisticalAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVStatisticalAnalysis.Location = New System.Drawing.Point(487, 486)
        Me.DGVStatisticalAnalysis.Name = "DGVStatisticalAnalysis"
        Me.DGVStatisticalAnalysis.Size = New System.Drawing.Size(314, 35)
        Me.DGVStatisticalAnalysis.TabIndex = 47
        Me.DGVStatisticalAnalysis.Visible = False
        '
        'CombAllYears
        '
        Me.CombAllYears.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombAllYears.FormattingEnabled = True
        Me.CombAllYears.Items.AddRange(New Object() {"2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050"})
        Me.CombAllYears.Location = New System.Drawing.Point(560, 33)
        Me.CombAllYears.Name = "CombAllYears"
        Me.CombAllYears.Size = New System.Drawing.Size(121, 24)
        Me.CombAllYears.TabIndex = 72
        '
        'LblCombAllYears
        '
        Me.LblCombAllYears.AutoSize = True
        Me.LblCombAllYears.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCombAllYears.ForeColor = System.Drawing.Color.Fuchsia
        Me.LblCombAllYears.Location = New System.Drawing.Point(559, 14)
        Me.LblCombAllYears.Name = "LblCombAllYears"
        Me.LblCombAllYears.Size = New System.Drawing.Size(228, 16)
        Me.LblCombAllYears.TabIndex = 73
        Me.LblCombAllYears.Text = "Choose Year Before Previewing"
        '
        'BtnClassEnrolment
        '
        Me.BtnClassEnrolment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClassEnrolment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnClassEnrolment.Location = New System.Drawing.Point(929, 427)
        Me.BtnClassEnrolment.Name = "BtnClassEnrolment"
        Me.BtnClassEnrolment.Size = New System.Drawing.Size(228, 23)
        Me.BtnClassEnrolment.TabIndex = 74
        Me.BtnClassEnrolment.Text = "View Class Enrolment"
        Me.BtnClassEnrolment.UseVisualStyleBackColor = True
        '
        'frmStatisticalAnalysis2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 523)
        Me.Controls.Add(Me.BtnClassEnrolment)
        Me.Controls.Add(Me.LblCombAllYears)
        Me.Controls.Add(Me.CombAllYears)
        Me.Controls.Add(Me.LlbOR)
        Me.Controls.Add(Me.LblDoubleclickonStudent)
        Me.Controls.Add(Me.txtNameToSearch)
        Me.Controls.Add(Me.BtnSearchByName)
        Me.Controls.Add(Me.dgvSearchName)
        Me.Controls.Add(Me.BtnSubjects)
        Me.Controls.Add(Me.LblSelectaStudent)
        Me.Controls.Add(Me.ComboADMNO)
        Me.Controls.Add(Me.GrpSingleStudent)
        Me.Controls.Add(Me.LblTotalSchoolPopulation)
        Me.Controls.Add(Me.BtnStudentOffenceNarration)
        Me.Controls.Add(Me.BtnGenderOffenceAnalysis)
        Me.Controls.Add(Me.GbNamesOfIndisciplinedStudents)
        Me.Controls.Add(Me.GbOffenseCountsCharts)
        Me.Controls.Add(Me.TotalNumberOfOffenses)
        Me.Controls.Add(Me.DtpEndingDate)
        Me.Controls.Add(Me.DtpBeginningDate)
        Me.Controls.Add(Me.LblEndingDate)
        Me.Controls.Add(Me.LblBeginningDate)
        Me.Controls.Add(Me.BtnOverallOffenseAnalysis)
        Me.Controls.Add(Me.TotalSchoolPopulation)
        Me.Controls.Add(Me.BtnAnalysisByOffenseType)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.DGVStatisticalAnalysis)
        Me.Name = "frmStatisticalAnalysis2"
        Me.ShowIcon = False
        Me.Text = "Offences Statistical Analysis and Printing (Past Years)"
        CType(Me.dgvSearchName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSingleStudent.ResumeLayout(False)
        Me.GbNamesOfIndisciplinedStudents.ResumeLayout(False)
        Me.GbOffenseCountsCharts.ResumeLayout(False)
        CType(Me.DGVStatisticalAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMinorOffensesPerDorm As Button
    Friend WithEvents MinorOffensesPerClass As Button
    Friend WithEvents MajorOffensesPerClass As Button
    Friend WithEvents BtnGenderDisciplineStatistics As Button
    Friend WithEvents BtnMajorVsMinorOffencesPercentages As Button
    Friend WithEvents BtnMinorOffencesDormStatistics As Button
    Friend WithEvents BtnMinorOffencesClassStatistics As Button
    Friend WithEvents BtnMajorOffencesClassStatistics As Button
    Friend WithEvents BtnMajorOffencesDormStatistics As Button
    Friend WithEvents BtnClassOffenseCategoriesChart As Button
    Friend WithEvents BtnMajorOffensesPerDorm As Button
    Friend WithEvents BtnPendingPunishment As Button
    Friend WithEvents BtnIndisciplinedStudentsByDormitory As Button
    Friend WithEvents BtnIndisciplinedStudentsByClass As Button
    Friend WithEvents BtnAllStudentsDispCard As Button
    Friend WithEvents LlbOR As Label
    Friend WithEvents LblDoubleclickonStudent As Label
    Friend WithEvents txtNameToSearch As TextBox
    Friend WithEvents BtnSearchByName As Button
    Friend WithEvents dgvSearchName As DataGridView
    Friend WithEvents BtnSubjects As Button
    Friend WithEvents LblSelectaStudent As Label
    Friend WithEvents ComboADMNO As ComboBox
    Friend WithEvents GrpSingleStudent As GroupBox
    Friend WithEvents BtnIndividualMwanafunzi As Button
    Friend WithEvents LblTotalSchoolPopulation As Label
    Friend WithEvents BtnDormitoryOffenseCategoriesChart As Button
    Friend WithEvents BtnStudentOffenceNarration As Button
    Friend WithEvents BtnGenderOffenceAnalysis As Button
    Friend WithEvents GbNamesOfIndisciplinedStudents As GroupBox
    Friend WithEvents BtnViewLeavers As Button
    Friend WithEvents BtnGenerateIndisciplineCases2report As Button
    Friend WithEvents GbOffenseCountsCharts As GroupBox
    Friend WithEvents BtnGenerateOffenseCategoriesChart As Button
    Friend WithEvents BtnOverallIndisciplinePercentages As Button
    Friend WithEvents TotalNumberOfOffenses As TextBox
    Friend WithEvents DtpEndingDate As DateTimePicker
    Friend WithEvents DtpBeginningDate As DateTimePicker
    Friend WithEvents LblEndingDate As Label
    Friend WithEvents LblBeginningDate As Label
    Friend WithEvents BtnOverallOffenseAnalysis As Button
    Friend WithEvents TotalSchoolPopulation As TextBox
    Friend WithEvents BtnAnalysisByOffenseType As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents DGVStatisticalAnalysis As DataGridView
    Friend WithEvents BtnBtnStudentOffenceNarration2 As Button
    Friend WithEvents CombAllYears As ComboBox
    Friend WithEvents LblCombAllYears As Label
    Friend WithEvents BtnClassEnrolment As Button
End Class
