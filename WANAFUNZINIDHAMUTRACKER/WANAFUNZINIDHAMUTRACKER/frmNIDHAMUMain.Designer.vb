<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNIDHAMUMain
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
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.DataGridViewFirstStudentDetails = New System.Windows.Forms.DataGridView()
        Me.ComboADMNO = New System.Windows.Forms.ComboBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblSelectaStudent = New System.Windows.Forms.Label()
        Me.txtOFFENSECOMMITED = New System.Windows.Forms.TextBox()
        Me.txtOffenseDescription = New System.Windows.Forms.TextBox()
        Me.PictureBoxStudentPhoto = New System.Windows.Forms.PictureBox()
        Me.LblNullPhoto = New System.Windows.Forms.Label()
        Me.BtnOpenStatisticalAnalysis = New System.Windows.Forms.Button()
        Me.dgvSearchName = New System.Windows.Forms.DataGridView()
        Me.BtnSearchByName = New System.Windows.Forms.Button()
        Me.txtNameToSearch = New System.Windows.Forms.TextBox()
        Me.LblDoubleclickonStudent = New System.Windows.Forms.Label()
        Me.BtnDeleteCurrentRecord = New System.Windows.Forms.Button()
        Me.LblAdmissionNoDescription2 = New System.Windows.Forms.Label()
        Me.LblAdmissionNoDescription1 = New System.Windows.Forms.Label()
        Me.LlbOR = New System.Windows.Forms.Label()
        Me.txtNAMEOFSTUDENT = New System.Windows.Forms.TextBox()
        Me.LblNAME = New System.Windows.Forms.Label()
        Me.LblADMNO = New System.Windows.Forms.Label()
        Me.txtADMISSIONNUMBER = New System.Windows.Forms.TextBox()
        Me.LblKCPEMARKS = New System.Windows.Forms.Label()
        Me.txtKCPEMARKS = New System.Windows.Forms.TextBox()
        Me.LblGENDER = New System.Windows.Forms.Label()
        Me.txtGENDER = New System.Windows.Forms.TextBox()
        Me.LblKCPEGRADE = New System.Windows.Forms.Label()
        Me.txtKCPEGRADE = New System.Windows.Forms.TextBox()
        Me.LblFORMERSCHOOL = New System.Windows.Forms.Label()
        Me.txtFORMERSCHOOL = New System.Windows.Forms.TextBox()
        Me.LblDATEOFADMISSION = New System.Windows.Forms.Label()
        Me.txtDATEOFADMISSION = New System.Windows.Forms.TextBox()
        Me.LblDoesNotDelete = New System.Windows.Forms.Label()
        Me.LblEnterCurrentDateClassStreamDorm = New System.Windows.Forms.Label()
        CType(Me.DataGridViewFirstStudentDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxStudentPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSearchName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.LightYellow
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(344, 542)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(116, 23)
        Me.BtnUpdate.TabIndex = 3
        Me.BtnUpdate.Text = "Save"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'DataGridViewFirstStudentDetails
        '
        Me.DataGridViewFirstStudentDetails.AllowUserToOrderColumns = True
        Me.DataGridViewFirstStudentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFirstStudentDetails.Location = New System.Drawing.Point(22, 128)
        Me.DataGridViewFirstStudentDetails.Name = "DataGridViewFirstStudentDetails"
        Me.DataGridViewFirstStudentDetails.Size = New System.Drawing.Size(1052, 360)
        Me.DataGridViewFirstStudentDetails.TabIndex = 2
        '
        'ComboADMNO
        '
        Me.ComboADMNO.FormattingEnabled = True
        Me.ComboADMNO.Location = New System.Drawing.Point(503, 544)
        Me.ComboADMNO.Name = "ComboADMNO"
        Me.ComboADMNO.Size = New System.Drawing.Size(107, 21)
        Me.ComboADMNO.TabIndex = 4
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.LightYellow
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(32, 540)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(74, 23)
        Me.BtnClose.TabIndex = 7
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'LblSelectaStudent
        '
        Me.LblSelectaStudent.AutoSize = True
        Me.LblSelectaStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSelectaStudent.ForeColor = System.Drawing.Color.Fuchsia
        Me.LblSelectaStudent.Location = New System.Drawing.Point(486, 525)
        Me.LblSelectaStudent.Name = "LblSelectaStudent"
        Me.LblSelectaStudent.Size = New System.Drawing.Size(123, 16)
        Me.LblSelectaStudent.TabIndex = 9
        Me.LblSelectaStudent.Text = "Select  ADM NO."
        '
        'txtOFFENSECOMMITED
        '
        Me.txtOFFENSECOMMITED.AccessibleDescription = ""
        Me.txtOFFENSECOMMITED.Location = New System.Drawing.Point(1080, 128)
        Me.txtOFFENSECOMMITED.Multiline = True
        Me.txtOFFENSECOMMITED.Name = "txtOFFENSECOMMITED"
        Me.txtOFFENSECOMMITED.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOFFENSECOMMITED.Size = New System.Drawing.Size(234, 354)
        Me.txtOFFENSECOMMITED.TabIndex = 17
        '
        'txtOffenseDescription
        '
        Me.txtOffenseDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffenseDescription.ForeColor = System.Drawing.Color.Fuchsia
        Me.txtOffenseDescription.Location = New System.Drawing.Point(1046, 60)
        Me.txtOffenseDescription.Multiline = True
        Me.txtOffenseDescription.Name = "txtOffenseDescription"
        Me.txtOffenseDescription.ReadOnly = True
        Me.txtOffenseDescription.Size = New System.Drawing.Size(282, 62)
        Me.txtOffenseDescription.TabIndex = 19
        Me.txtOffenseDescription.Text = "To view or type, place the cursor in the offense Committed row cell and type the " &
    "offense description in this box here."
        '
        'PictureBoxStudentPhoto
        '
        Me.PictureBoxStudentPhoto.Location = New System.Drawing.Point(889, 3)
        Me.PictureBoxStudentPhoto.Name = "PictureBoxStudentPhoto"
        Me.PictureBoxStudentPhoto.Size = New System.Drawing.Size(132, 119)
        Me.PictureBoxStudentPhoto.TabIndex = 20
        Me.PictureBoxStudentPhoto.TabStop = False
        '
        'LblNullPhoto
        '
        Me.LblNullPhoto.AutoSize = True
        Me.LblNullPhoto.Location = New System.Drawing.Point(381, 40)
        Me.LblNullPhoto.Name = "LblNullPhoto"
        Me.LblNullPhoto.Size = New System.Drawing.Size(0, 13)
        Me.LblNullPhoto.TabIndex = 21
        '
        'BtnOpenStatisticalAnalysis
        '
        Me.BtnOpenStatisticalAnalysis.BackColor = System.Drawing.Color.LightYellow
        Me.BtnOpenStatisticalAnalysis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenStatisticalAnalysis.Location = New System.Drawing.Point(647, 544)
        Me.BtnOpenStatisticalAnalysis.Name = "BtnOpenStatisticalAnalysis"
        Me.BtnOpenStatisticalAnalysis.Size = New System.Drawing.Size(262, 23)
        Me.BtnOpenStatisticalAnalysis.TabIndex = 22
        Me.BtnOpenStatisticalAnalysis.Text = "Open Statistical Analysis And Print"
        Me.BtnOpenStatisticalAnalysis.UseVisualStyleBackColor = False
        '
        'dgvSearchName
        '
        Me.dgvSearchName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchName.Location = New System.Drawing.Point(936, 540)
        Me.dgvSearchName.Name = "dgvSearchName"
        Me.dgvSearchName.Size = New System.Drawing.Size(378, 112)
        Me.dgvSearchName.TabIndex = 23
        '
        'BtnSearchByName
        '
        Me.BtnSearchByName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearchByName.Location = New System.Drawing.Point(1170, 511)
        Me.BtnSearchByName.Name = "BtnSearchByName"
        Me.BtnSearchByName.Size = New System.Drawing.Size(133, 23)
        Me.BtnSearchByName.TabIndex = 24
        Me.BtnSearchByName.Text = "Search By Name"
        Me.BtnSearchByName.UseVisualStyleBackColor = True
        '
        'txtNameToSearch
        '
        Me.txtNameToSearch.Location = New System.Drawing.Point(936, 514)
        Me.txtNameToSearch.Name = "txtNameToSearch"
        Me.txtNameToSearch.Size = New System.Drawing.Size(218, 20)
        Me.txtNameToSearch.TabIndex = 25
        '
        'LblDoubleclickonStudent
        '
        Me.LblDoubleclickonStudent.AutoSize = True
        Me.LblDoubleclickonStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDoubleclickonStudent.ForeColor = System.Drawing.Color.Maroon
        Me.LblDoubleclickonStudent.Location = New System.Drawing.Point(944, 655)
        Me.LblDoubleclickonStudent.Name = "LblDoubleclickonStudent"
        Me.LblDoubleclickonStudent.Size = New System.Drawing.Size(282, 16)
        Me.LblDoubleclickonStudent.TabIndex = 26
        Me.LblDoubleclickonStudent.Text = "Double Click on a student name to open"
        '
        'BtnDeleteCurrentRecord
        '
        Me.BtnDeleteCurrentRecord.BackColor = System.Drawing.Color.LightYellow
        Me.BtnDeleteCurrentRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteCurrentRecord.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnDeleteCurrentRecord.Location = New System.Drawing.Point(139, 542)
        Me.BtnDeleteCurrentRecord.Name = "BtnDeleteCurrentRecord"
        Me.BtnDeleteCurrentRecord.Size = New System.Drawing.Size(170, 23)
        Me.BtnDeleteCurrentRecord.TabIndex = 27
        Me.BtnDeleteCurrentRecord.Text = "Delete Current Record"
        Me.BtnDeleteCurrentRecord.UseVisualStyleBackColor = False
        '
        'LblAdmissionNoDescription2
        '
        Me.LblAdmissionNoDescription2.AutoSize = True
        Me.LblAdmissionNoDescription2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdmissionNoDescription2.ForeColor = System.Drawing.Color.Blue
        Me.LblAdmissionNoDescription2.Location = New System.Drawing.Point(205, 594)
        Me.LblAdmissionNoDescription2.Name = "LblAdmissionNoDescription2"
        Me.LblAdmissionNoDescription2.Size = New System.Drawing.Size(473, 16)
        Me.LblAdmissionNoDescription2.TabIndex = 38
        Me.LblAdmissionNoDescription2.Text = "highlighted in blue when you click the drop down arrow and select it."
        '
        'LblAdmissionNoDescription1
        '
        Me.LblAdmissionNoDescription1.AutoSize = True
        Me.LblAdmissionNoDescription1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdmissionNoDescription1.ForeColor = System.Drawing.Color.Blue
        Me.LblAdmissionNoDescription1.Location = New System.Drawing.Point(205, 578)
        Me.LblAdmissionNoDescription1.Name = "LblAdmissionNoDescription1"
        Me.LblAdmissionNoDescription1.Size = New System.Drawing.Size(485, 16)
        Me.LblAdmissionNoDescription1.TabIndex = 37
        Me.LblAdmissionNoDescription1.Text = "N/B: You can also type in the Admission Number.  If it exists, it will be "
        '
        'LlbOR
        '
        Me.LlbOR.AutoSize = True
        Me.LlbOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LlbOR.ForeColor = System.Drawing.Color.Blue
        Me.LlbOR.Location = New System.Drawing.Point(791, 594)
        Me.LlbOR.Name = "LlbOR"
        Me.LlbOR.Size = New System.Drawing.Size(98, 55)
        Me.LlbOR.TabIndex = 39
        Me.LlbOR.Text = "OR"
        '
        'txtNAMEOFSTUDENT
        '
        Me.txtNAMEOFSTUDENT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNAMEOFSTUDENT.Location = New System.Drawing.Point(86, 21)
        Me.txtNAMEOFSTUDENT.Name = "txtNAMEOFSTUDENT"
        Me.txtNAMEOFSTUDENT.Size = New System.Drawing.Size(183, 22)
        Me.txtNAMEOFSTUDENT.TabIndex = 40
        '
        'LblNAME
        '
        Me.LblNAME.AutoSize = True
        Me.LblNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNAME.Location = New System.Drawing.Point(31, 28)
        Me.LblNAME.Name = "LblNAME"
        Me.LblNAME.Size = New System.Drawing.Size(55, 16)
        Me.LblNAME.TabIndex = 41
        Me.LblNAME.Text = "NAME:"
        '
        'LblADMNO
        '
        Me.LblADMNO.AutoSize = True
        Me.LblADMNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblADMNO.Location = New System.Drawing.Point(282, 28)
        Me.LblADMNO.Name = "LblADMNO"
        Me.LblADMNO.Size = New System.Drawing.Size(71, 16)
        Me.LblADMNO.TabIndex = 43
        Me.LblADMNO.Text = "ADMNO.:"
        '
        'txtADMISSIONNUMBER
        '
        Me.txtADMISSIONNUMBER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtADMISSIONNUMBER.Location = New System.Drawing.Point(353, 21)
        Me.txtADMISSIONNUMBER.Name = "txtADMISSIONNUMBER"
        Me.txtADMISSIONNUMBER.Size = New System.Drawing.Size(94, 22)
        Me.txtADMISSIONNUMBER.TabIndex = 42
        '
        'LblKCPEMARKS
        '
        Me.LblKCPEMARKS.AutoSize = True
        Me.LblKCPEMARKS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKCPEMARKS.Location = New System.Drawing.Point(574, 28)
        Me.LblKCPEMARKS.Name = "LblKCPEMARKS"
        Me.LblKCPEMARKS.Size = New System.Drawing.Size(107, 16)
        Me.LblKCPEMARKS.TabIndex = 45
        Me.LblKCPEMARKS.Text = "KCPE MARKS:"
        '
        'txtKCPEMARKS
        '
        Me.txtKCPEMARKS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKCPEMARKS.Location = New System.Drawing.Point(685, 21)
        Me.txtKCPEMARKS.Name = "txtKCPEMARKS"
        Me.txtKCPEMARKS.Size = New System.Drawing.Size(53, 22)
        Me.txtKCPEMARKS.TabIndex = 44
        '
        'LblGENDER
        '
        Me.LblGENDER.AutoSize = True
        Me.LblGENDER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGENDER.Location = New System.Drawing.Point(453, 28)
        Me.LblGENDER.Name = "LblGENDER"
        Me.LblGENDER.Size = New System.Drawing.Size(76, 16)
        Me.LblGENDER.TabIndex = 47
        Me.LblGENDER.Text = "GENDER:"
        '
        'txtGENDER
        '
        Me.txtGENDER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGENDER.Location = New System.Drawing.Point(529, 21)
        Me.txtGENDER.Name = "txtGENDER"
        Me.txtGENDER.Size = New System.Drawing.Size(35, 22)
        Me.txtGENDER.TabIndex = 46
        '
        'LblKCPEGRADE
        '
        Me.LblKCPEGRADE.AutoSize = True
        Me.LblKCPEGRADE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKCPEGRADE.Location = New System.Drawing.Point(744, 27)
        Me.LblKCPEGRADE.Name = "LblKCPEGRADE"
        Me.LblKCPEGRADE.Size = New System.Drawing.Size(108, 16)
        Me.LblKCPEGRADE.TabIndex = 49
        Me.LblKCPEGRADE.Text = "KCPE GRADE:"
        '
        'txtKCPEGRADE
        '
        Me.txtKCPEGRADE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKCPEGRADE.Location = New System.Drawing.Point(855, 20)
        Me.txtKCPEGRADE.Name = "txtKCPEGRADE"
        Me.txtKCPEGRADE.Size = New System.Drawing.Size(28, 22)
        Me.txtKCPEGRADE.TabIndex = 48
        '
        'LblFORMERSCHOOL
        '
        Me.LblFORMERSCHOOL.AutoSize = True
        Me.LblFORMERSCHOOL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFORMERSCHOOL.Location = New System.Drawing.Point(29, 67)
        Me.LblFORMERSCHOOL.Name = "LblFORMERSCHOOL"
        Me.LblFORMERSCHOOL.Size = New System.Drawing.Size(141, 16)
        Me.LblFORMERSCHOOL.TabIndex = 51
        Me.LblFORMERSCHOOL.Text = "FORMER SCHOOL:"
        '
        'txtFORMERSCHOOL
        '
        Me.txtFORMERSCHOOL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFORMERSCHOOL.Location = New System.Drawing.Point(170, 60)
        Me.txtFORMERSCHOOL.Name = "txtFORMERSCHOOL"
        Me.txtFORMERSCHOOL.Size = New System.Drawing.Size(270, 22)
        Me.txtFORMERSCHOOL.TabIndex = 50
        '
        'LblDATEOFADMISSION
        '
        Me.LblDATEOFADMISSION.AutoSize = True
        Me.LblDATEOFADMISSION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDATEOFADMISSION.Location = New System.Drawing.Point(483, 66)
        Me.LblDATEOFADMISSION.Name = "LblDATEOFADMISSION"
        Me.LblDATEOFADMISSION.Size = New System.Drawing.Size(164, 16)
        Me.LblDATEOFADMISSION.TabIndex = 53
        Me.LblDATEOFADMISSION.Text = "DATE OF ADMISSION:"
        '
        'txtDATEOFADMISSION
        '
        Me.txtDATEOFADMISSION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDATEOFADMISSION.Location = New System.Drawing.Point(647, 59)
        Me.txtDATEOFADMISSION.Name = "txtDATEOFADMISSION"
        Me.txtDATEOFADMISSION.Size = New System.Drawing.Size(67, 22)
        Me.txtDATEOFADMISSION.TabIndex = 52
        '
        'LblDoesNotDelete
        '
        Me.LblDoesNotDelete.AutoSize = True
        Me.LblDoesNotDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDoesNotDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblDoesNotDelete.Location = New System.Drawing.Point(31, 492)
        Me.LblDoesNotDelete.Name = "LblDoesNotDelete"
        Me.LblDoesNotDelete.Size = New System.Drawing.Size(429, 15)
        Me.LblDoesNotDelete.TabIndex = 54
        Me.LblDoesNotDelete.Text = "Tip: If a record does not delete, close and open then delete again."
        '
        'LblEnterCurrentDateClassStreamDorm
        '
        Me.LblEnterCurrentDateClassStreamDorm.AutoSize = True
        Me.LblEnterCurrentDateClassStreamDorm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnterCurrentDateClassStreamDorm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblEnterCurrentDateClassStreamDorm.Location = New System.Drawing.Point(19, 110)
        Me.LblEnterCurrentDateClassStreamDorm.Name = "LblEnterCurrentDateClassStreamDorm"
        Me.LblEnterCurrentDateClassStreamDorm.Size = New System.Drawing.Size(701, 15)
        Me.LblEnterCurrentDateClassStreamDorm.TabIndex = 55
        Me.LblEnterCurrentDateClassStreamDorm.Text = "Tip: Ensure you enter Current Date, Term, Class, Stream, Dormitory every time a s" &
    "tudent commits an offence."
        '
        'frmNIDHAMUMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1287, 724)
        Me.Controls.Add(Me.LblEnterCurrentDateClassStreamDorm)
        Me.Controls.Add(Me.LblDoesNotDelete)
        Me.Controls.Add(Me.LblDATEOFADMISSION)
        Me.Controls.Add(Me.txtDATEOFADMISSION)
        Me.Controls.Add(Me.LblFORMERSCHOOL)
        Me.Controls.Add(Me.txtFORMERSCHOOL)
        Me.Controls.Add(Me.LblKCPEGRADE)
        Me.Controls.Add(Me.txtKCPEGRADE)
        Me.Controls.Add(Me.LblGENDER)
        Me.Controls.Add(Me.txtGENDER)
        Me.Controls.Add(Me.LblKCPEMARKS)
        Me.Controls.Add(Me.txtKCPEMARKS)
        Me.Controls.Add(Me.LblADMNO)
        Me.Controls.Add(Me.txtADMISSIONNUMBER)
        Me.Controls.Add(Me.LblNAME)
        Me.Controls.Add(Me.txtNAMEOFSTUDENT)
        Me.Controls.Add(Me.LlbOR)
        Me.Controls.Add(Me.LblAdmissionNoDescription2)
        Me.Controls.Add(Me.LblAdmissionNoDescription1)
        Me.Controls.Add(Me.BtnDeleteCurrentRecord)
        Me.Controls.Add(Me.LblDoubleclickonStudent)
        Me.Controls.Add(Me.txtNameToSearch)
        Me.Controls.Add(Me.BtnSearchByName)
        Me.Controls.Add(Me.dgvSearchName)
        Me.Controls.Add(Me.BtnOpenStatisticalAnalysis)
        Me.Controls.Add(Me.LblNullPhoto)
        Me.Controls.Add(Me.PictureBoxStudentPhoto)
        Me.Controls.Add(Me.txtOffenseDescription)
        Me.Controls.Add(Me.txtOFFENSECOMMITED)
        Me.Controls.Add(Me.LblSelectaStudent)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.ComboADMNO)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.DataGridViewFirstStudentDetails)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmNIDHAMUMain"
        Me.ShowIcon = False
        Me.Text = "NIDHAMU YA WANAFUNZI DATA MANAGEMENT SYSTEM -Version 1.0.0 - EMUSIRE HIGH SCHOOL"
        CType(Me.DataGridViewFirstStudentDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxStudentPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSearchName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnUpdate As Button
    Friend WithEvents DataGridViewFirstStudentDetails As DataGridView
    Friend WithEvents ComboADMNO As ComboBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblSelectaStudent As Label
    Friend WithEvents txtOFFENSECOMMITED As TextBox
    Friend WithEvents txtOffenseDescription As TextBox
    Friend WithEvents PictureBoxStudentPhoto As PictureBox
    Friend WithEvents LblNullPhoto As Label
    Friend WithEvents BtnOpenStatisticalAnalysis As Button
    Friend WithEvents dgvSearchName As DataGridView
    Friend WithEvents BtnSearchByName As Button
    Friend WithEvents txtNameToSearch As TextBox
    Friend WithEvents LblDoubleclickonStudent As Label
    Friend WithEvents BtnDeleteCurrentRecord As Button
    Friend WithEvents LblAdmissionNoDescription2 As Label
    Friend WithEvents LblAdmissionNoDescription1 As Label
    Friend WithEvents LlbOR As Label
    Friend WithEvents txtNAMEOFSTUDENT As TextBox
    Friend WithEvents LblNAME As Label
    Friend WithEvents LblADMNO As Label
    Friend WithEvents txtADMISSIONNUMBER As TextBox
    Friend WithEvents LblKCPEMARKS As Label
    Friend WithEvents txtKCPEMARKS As TextBox
    Friend WithEvents LblGENDER As Label
    Friend WithEvents txtGENDER As TextBox
    Friend WithEvents LblKCPEGRADE As Label
    Friend WithEvents txtKCPEGRADE As TextBox
    Friend WithEvents LblFORMERSCHOOL As Label
    Friend WithEvents txtFORMERSCHOOL As TextBox
    Friend WithEvents LblDATEOFADMISSION As Label
    Friend WithEvents txtDATEOFADMISSION As TextBox
    Friend WithEvents LblDoesNotDelete As Label
    Friend WithEvents LblEnterCurrentDateClassStreamDorm As Label
End Class
