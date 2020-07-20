<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainOperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuRegisterStudents = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuEnterStudentsData = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreliminariesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuRegisterPreliminariesInformation = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuEditData = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuEditOrCorrectData = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseUtilitiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuDatabaseBackUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuDatabaseRestoration = New System.Windows.Forms.ToolStripMenuItem()
        Me.PromoteStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuPromoteToNextClass = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuDemoteToLowerClass = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSendToArchive = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCurrentYear = New System.Windows.Forms.TextBox()
        Me.LblConfirmStudentPromotion = New System.Windows.Forms.Label()
        Me.LblUploadStatus = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Thistle
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainOperationsToolStripMenuItem, Me.PreliminariesToolStripMenuItem, Me.MnuEditData, Me.DatabaseUtilitiesToolStripMenuItem, Me.PromoteStudentsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1148, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainOperationsToolStripMenuItem
        '
        Me.MainOperationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuRegisterStudents, Me.MnuEnterStudentsData, Me.MnuExit})
        Me.MainOperationsToolStripMenuItem.Name = "MainOperationsToolStripMenuItem"
        Me.MainOperationsToolStripMenuItem.Size = New System.Drawing.Size(117, 21)
        Me.MainOperationsToolStripMenuItem.Text = "MainOperations"
        '
        'MnuRegisterStudents
        '
        Me.MnuRegisterStudents.Name = "MnuRegisterStudents"
        Me.MnuRegisterStudents.Size = New System.Drawing.Size(294, 22)
        Me.MnuRegisterStudents.Text = "Register Students"
        '
        'MnuEnterStudentsData
        '
        Me.MnuEnterStudentsData.Name = "MnuEnterStudentsData"
        Me.MnuEnterStudentsData.Size = New System.Drawing.Size(294, 22)
        Me.MnuEnterStudentsData.Text = "View/Enter Students' Discipline Data"
        '
        'MnuExit
        '
        Me.MnuExit.Name = "MnuExit"
        Me.MnuExit.Size = New System.Drawing.Size(294, 22)
        Me.MnuExit.Text = "Exit"
        '
        'PreliminariesToolStripMenuItem
        '
        Me.PreliminariesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuRegisterPreliminariesInformation})
        Me.PreliminariesToolStripMenuItem.Name = "PreliminariesToolStripMenuItem"
        Me.PreliminariesToolStripMenuItem.Size = New System.Drawing.Size(97, 21)
        Me.PreliminariesToolStripMenuItem.Text = "Preliminaries"
        '
        'MnuRegisterPreliminariesInformation
        '
        Me.MnuRegisterPreliminariesInformation.Name = "MnuRegisterPreliminariesInformation"
        Me.MnuRegisterPreliminariesInformation.Size = New System.Drawing.Size(274, 22)
        Me.MnuRegisterPreliminariesInformation.Text = "Register Preliminary Information"
        '
        'MnuEditData
        '
        Me.MnuEditData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuEditOrCorrectData})
        Me.MnuEditData.Name = "MnuEditData"
        Me.MnuEditData.Size = New System.Drawing.Size(75, 21)
        Me.MnuEditData.Text = "Edit Data"
        '
        'MnuEditOrCorrectData
        '
        Me.MnuEditOrCorrectData.Name = "MnuEditOrCorrectData"
        Me.MnuEditOrCorrectData.Size = New System.Drawing.Size(198, 22)
        Me.MnuEditOrCorrectData.Text = "Edit Or Correct Data"
        '
        'DatabaseUtilitiesToolStripMenuItem
        '
        Me.DatabaseUtilitiesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuDatabaseBackUp, Me.MnuDatabaseRestoration})
        Me.DatabaseUtilitiesToolStripMenuItem.Name = "DatabaseUtilitiesToolStripMenuItem"
        Me.DatabaseUtilitiesToolStripMenuItem.Size = New System.Drawing.Size(124, 21)
        Me.DatabaseUtilitiesToolStripMenuItem.Text = "Database Utilities"
        '
        'MnuDatabaseBackUp
        '
        Me.MnuDatabaseBackUp.Name = "MnuDatabaseBackUp"
        Me.MnuDatabaseBackUp.Size = New System.Drawing.Size(206, 22)
        Me.MnuDatabaseBackUp.Text = "Database BackUp"
        '
        'MnuDatabaseRestoration
        '
        Me.MnuDatabaseRestoration.Name = "MnuDatabaseRestoration"
        Me.MnuDatabaseRestoration.Size = New System.Drawing.Size(206, 22)
        Me.MnuDatabaseRestoration.Text = "Database Restoration"
        '
        'PromoteStudentsToolStripMenuItem
        '
        Me.PromoteStudentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuPromoteToNextClass, Me.MnuDemoteToLowerClass, Me.MnuSendToArchive})
        Me.PromoteStudentsToolStripMenuItem.Name = "PromoteStudentsToolStripMenuItem"
        Me.PromoteStudentsToolStripMenuItem.Size = New System.Drawing.Size(131, 21)
        Me.PromoteStudentsToolStripMenuItem.Text = "Promote Students"
        Me.PromoteStudentsToolStripMenuItem.Visible = False
        '
        'MnuPromoteToNextClass
        '
        Me.MnuPromoteToNextClass.Name = "MnuPromoteToNextClass"
        Me.MnuPromoteToNextClass.Size = New System.Drawing.Size(215, 22)
        Me.MnuPromoteToNextClass.Text = "Promote to Next Class"
        '
        'MnuDemoteToLowerClass
        '
        Me.MnuDemoteToLowerClass.Name = "MnuDemoteToLowerClass"
        Me.MnuDemoteToLowerClass.Size = New System.Drawing.Size(215, 22)
        Me.MnuDemoteToLowerClass.Text = "Demote to Lower Class"
        '
        'MnuSendToArchive
        '
        Me.MnuSendToArchive.Name = "MnuSendToArchive"
        Me.MnuSendToArchive.Size = New System.Drawing.Size(215, 22)
        Me.MnuSendToArchive.Text = "Send to Archive"
        '
        'txtCurrentYear
        '
        Me.txtCurrentYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentYear.ForeColor = System.Drawing.Color.Fuchsia
        Me.txtCurrentYear.Location = New System.Drawing.Point(738, 661)
        Me.txtCurrentYear.Name = "txtCurrentYear"
        Me.txtCurrentYear.ReadOnly = True
        Me.txtCurrentYear.Size = New System.Drawing.Size(97, 29)
        Me.txtCurrentYear.TabIndex = 48
        '
        'LblConfirmStudentPromotion
        '
        Me.LblConfirmStudentPromotion.AutoSize = True
        Me.LblConfirmStudentPromotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConfirmStudentPromotion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblConfirmStudentPromotion.Location = New System.Drawing.Point(21, 661)
        Me.LblConfirmStudentPromotion.Name = "LblConfirmStudentPromotion"
        Me.LblConfirmStudentPromotion.Size = New System.Drawing.Size(0, 24)
        Me.LblConfirmStudentPromotion.TabIndex = 49
        '
        'LblUploadStatus
        '
        Me.LblUploadStatus.AutoSize = True
        Me.LblUploadStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUploadStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblUploadStatus.Location = New System.Drawing.Point(224, 614)
        Me.LblUploadStatus.Name = "LblUploadStatus"
        Me.LblUploadStatus.Size = New System.Drawing.Size(138, 24)
        Me.LblUploadStatus.TabIndex = 50
        Me.LblUploadStatus.Text = "Upload Status"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1148, 709)
        Me.Controls.Add(Me.LblUploadStatus)
        Me.Controls.Add(Me.LblConfirmStudentPromotion)
        Me.Controls.Add(Me.txtCurrentYear)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.Text = "NIDHAMU YA WANAFUNZI DATA MANAGEMENT SYSTEM -Version 1.0.0 - EMUSIRE HIGH SCHOOL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MainOperationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreliminariesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuEditData As ToolStripMenuItem
    Friend WithEvents MnuEnterStudentsData As ToolStripMenuItem
    Friend WithEvents MnuRegisterPreliminariesInformation As ToolStripMenuItem
    Friend WithEvents MnuExit As ToolStripMenuItem
    Friend WithEvents MnuEditOrCorrectData As ToolStripMenuItem
    Friend WithEvents MnuRegisterStudents As ToolStripMenuItem
    Friend WithEvents DatabaseUtilitiesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuDatabaseBackUp As ToolStripMenuItem
    Friend WithEvents MnuDatabaseRestoration As ToolStripMenuItem
    Friend WithEvents PromoteStudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuPromoteToNextClass As ToolStripMenuItem
    Friend WithEvents MnuDemoteToLowerClass As ToolStripMenuItem
    Friend WithEvents MnuSendToArchive As ToolStripMenuItem
    Friend WithEvents txtCurrentYear As TextBox
    Friend WithEvents LblConfirmStudentPromotion As Label
    Friend WithEvents LblUploadStatus As Label
End Class
