<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDataEntryNIDHAMU
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
        Me.DataGridViewDISCIPLINEREGISTRATION = New System.Windows.Forms.DataGridView()
        Me.BtnViewaStudent = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnUpdateNewStudents = New System.Windows.Forms.Button()
        Me.BtnGetPhoto = New System.Windows.Forms.Button()
        Me.BtnSavePhoto = New System.Windows.Forms.Button()
        Me.OFGSelectImageStudentPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBoxStudentPhoto = New System.Windows.Forms.PictureBox()
        Me.BtnEditData = New System.Windows.Forms.Button()
        Me.BtnDeleteCurrentRecord = New System.Windows.Forms.Button()
        Me.LblPhotoSizes = New System.Windows.Forms.Label()
        Me.LblPhotoSizes2 = New System.Windows.Forms.Label()
        Me.LblREGDATE = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblEnterCurrentDateClassStreamDorm = New System.Windows.Forms.Label()
        Me.BtnRefreshRecords = New System.Windows.Forms.Button()
        Me.LblAvoidDuplicateADMNO = New System.Windows.Forms.Label()
        CType(Me.DataGridViewDISCIPLINEREGISTRATION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxStudentPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewDISCIPLINEREGISTRATION
        '
        Me.DataGridViewDISCIPLINEREGISTRATION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDISCIPLINEREGISTRATION.Location = New System.Drawing.Point(243, 41)
        Me.DataGridViewDISCIPLINEREGISTRATION.Name = "DataGridViewDISCIPLINEREGISTRATION"
        Me.DataGridViewDISCIPLINEREGISTRATION.Size = New System.Drawing.Size(981, 439)
        Me.DataGridViewDISCIPLINEREGISTRATION.TabIndex = 3
        '
        'BtnViewaStudent
        '
        Me.BtnViewaStudent.BackColor = System.Drawing.Color.Linen
        Me.BtnViewaStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewaStudent.Location = New System.Drawing.Point(979, 546)
        Me.BtnViewaStudent.Name = "BtnViewaStudent"
        Me.BtnViewaStudent.Size = New System.Drawing.Size(281, 23)
        Me.BtnViewaStudent.TabIndex = 4
        Me.BtnViewaStudent.Text = "View or Enter Student's discipline data"
        Me.BtnViewaStudent.UseVisualStyleBackColor = False
        Me.BtnViewaStudent.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.LightYellow
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(129, 520)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(99, 23)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.LightYellow
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(297, 520)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(149, 23)
        Me.BtnUpdate.TabIndex = 9
        Me.BtnUpdate.Text = "Save Record"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnUpdateNewStudents
        '
        Me.BtnUpdateNewStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateNewStudents.Location = New System.Drawing.Point(519, 520)
        Me.BtnUpdateNewStudents.Name = "BtnUpdateNewStudents"
        Me.BtnUpdateNewStudents.Size = New System.Drawing.Size(166, 23)
        Me.BtnUpdateNewStudents.TabIndex = 13
        Me.BtnUpdateNewStudents.Text = "Upload New Students"
        Me.BtnUpdateNewStudents.UseVisualStyleBackColor = True
        '
        'BtnGetPhoto
        '
        Me.BtnGetPhoto.BackColor = System.Drawing.Color.Linen
        Me.BtnGetPhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGetPhoto.Location = New System.Drawing.Point(65, 61)
        Me.BtnGetPhoto.Name = "BtnGetPhoto"
        Me.BtnGetPhoto.Size = New System.Drawing.Size(129, 23)
        Me.BtnGetPhoto.TabIndex = 17
        Me.BtnGetPhoto.Text = "Get Photo"
        Me.BtnGetPhoto.UseVisualStyleBackColor = False
        '
        'BtnSavePhoto
        '
        Me.BtnSavePhoto.BackColor = System.Drawing.Color.Linen
        Me.BtnSavePhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSavePhoto.Location = New System.Drawing.Point(65, 228)
        Me.BtnSavePhoto.Name = "BtnSavePhoto"
        Me.BtnSavePhoto.Size = New System.Drawing.Size(129, 23)
        Me.BtnSavePhoto.TabIndex = 18
        Me.BtnSavePhoto.Text = "Send  Photo"
        Me.BtnSavePhoto.UseVisualStyleBackColor = False
        '
        'OFGSelectImageStudentPhoto
        '
        Me.OFGSelectImageStudentPhoto.Filter = "JPEG Files| *.JPG|GIF Files|*.GIF|WIndows Bitmaps|*.BMP"
        '
        'PictureBoxStudentPhoto
        '
        Me.PictureBoxStudentPhoto.Location = New System.Drawing.Point(65, 90)
        Me.PictureBoxStudentPhoto.Name = "PictureBoxStudentPhoto"
        Me.PictureBoxStudentPhoto.Size = New System.Drawing.Size(116, 121)
        Me.PictureBoxStudentPhoto.TabIndex = 19
        Me.PictureBoxStudentPhoto.TabStop = False
        '
        'BtnEditData
        '
        Me.BtnEditData.BackColor = System.Drawing.Color.LightYellow
        Me.BtnEditData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditData.Location = New System.Drawing.Point(1154, 491)
        Me.BtnEditData.Name = "BtnEditData"
        Me.BtnEditData.Size = New System.Drawing.Size(106, 23)
        Me.BtnEditData.TabIndex = 29
        Me.BtnEditData.Text = "Edit Data"
        Me.BtnEditData.UseVisualStyleBackColor = False
        Me.BtnEditData.Visible = False
        '
        'BtnDeleteCurrentRecord
        '
        Me.BtnDeleteCurrentRecord.BackColor = System.Drawing.Color.LightYellow
        Me.BtnDeleteCurrentRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteCurrentRecord.Location = New System.Drawing.Point(986, 520)
        Me.BtnDeleteCurrentRecord.Name = "BtnDeleteCurrentRecord"
        Me.BtnDeleteCurrentRecord.Size = New System.Drawing.Size(236, 23)
        Me.BtnDeleteCurrentRecord.TabIndex = 30
        Me.BtnDeleteCurrentRecord.Text = "Delete Current Record"
        Me.BtnDeleteCurrentRecord.UseVisualStyleBackColor = False
        '
        'LblPhotoSizes
        '
        Me.LblPhotoSizes.AutoSize = True
        Me.LblPhotoSizes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhotoSizes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblPhotoSizes.Location = New System.Drawing.Point(12, 9)
        Me.LblPhotoSizes.Name = "LblPhotoSizes"
        Me.LblPhotoSizes.Size = New System.Drawing.Size(157, 16)
        Me.LblPhotoSizes.TabIndex = 31
        Me.LblPhotoSizes.Text = "N/B: Use photo sizes:"
        '
        'LblPhotoSizes2
        '
        Me.LblPhotoSizes2.AutoSize = True
        Me.LblPhotoSizes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhotoSizes2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblPhotoSizes2.Location = New System.Drawing.Point(12, 25)
        Me.LblPhotoSizes2.Name = "LblPhotoSizes2"
        Me.LblPhotoSizes2.Size = New System.Drawing.Size(216, 16)
        Me.LblPhotoSizes2.TabIndex = 32
        Me.LblPhotoSizes2.Text = "(Width: 110, height: 115) pixels"
        '
        'LblREGDATE
        '
        Me.LblREGDATE.AutoSize = True
        Me.LblREGDATE.Location = New System.Drawing.Point(510, 23)
        Me.LblREGDATE.Name = "LblREGDATE"
        Me.LblREGDATE.Size = New System.Drawing.Size(0, 13)
        Me.LblREGDATE.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(353, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(732, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "STUDENTS' REGISTRATION MANDATORY FIELDS: DATE, NAME, ADMNO, GENDER, CLASS, STREAM" &
    ", DORMITORY, KCPE"
        '
        'LblEnterCurrentDateClassStreamDorm
        '
        Me.LblEnterCurrentDateClassStreamDorm.AutoSize = True
        Me.LblEnterCurrentDateClassStreamDorm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnterCurrentDateClassStreamDorm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblEnterCurrentDateClassStreamDorm.Location = New System.Drawing.Point(240, 483)
        Me.LblEnterCurrentDateClassStreamDorm.Name = "LblEnterCurrentDateClassStreamDorm"
        Me.LblEnterCurrentDateClassStreamDorm.Size = New System.Drawing.Size(894, 15)
        Me.LblEnterCurrentDateClassStreamDorm.TabIndex = 56
        Me.LblEnterCurrentDateClassStreamDorm.Text = "Tip: The highlighted record in red means that either there is duplicate admission" &
    " number or has not been saved. Click on Refresh Records."
        '
        'BtnRefreshRecords
        '
        Me.BtnRefreshRecords.BackColor = System.Drawing.Color.LightYellow
        Me.BtnRefreshRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefreshRecords.Location = New System.Drawing.Point(831, 520)
        Me.BtnRefreshRecords.Name = "BtnRefreshRecords"
        Me.BtnRefreshRecords.Size = New System.Drawing.Size(149, 23)
        Me.BtnRefreshRecords.TabIndex = 57
        Me.BtnRefreshRecords.Text = "Refresh Records"
        Me.BtnRefreshRecords.UseVisualStyleBackColor = False
        '
        'LblAvoidDuplicateADMNO
        '
        Me.LblAvoidDuplicateADMNO.AutoSize = True
        Me.LblAvoidDuplicateADMNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAvoidDuplicateADMNO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblAvoidDuplicateADMNO.Location = New System.Drawing.Point(3, 337)
        Me.LblAvoidDuplicateADMNO.Name = "LblAvoidDuplicateADMNO"
        Me.LblAvoidDuplicateADMNO.Size = New System.Drawing.Size(0, 16)
        Me.LblAvoidDuplicateADMNO.TabIndex = 58
        '
        'frmDataEntryNIDHAMU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1272, 581)
        Me.Controls.Add(Me.LblAvoidDuplicateADMNO)
        Me.Controls.Add(Me.BtnRefreshRecords)
        Me.Controls.Add(Me.LblEnterCurrentDateClassStreamDorm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblREGDATE)
        Me.Controls.Add(Me.LblPhotoSizes2)
        Me.Controls.Add(Me.LblPhotoSizes)
        Me.Controls.Add(Me.BtnDeleteCurrentRecord)
        Me.Controls.Add(Me.BtnEditData)
        Me.Controls.Add(Me.PictureBoxStudentPhoto)
        Me.Controls.Add(Me.BtnSavePhoto)
        Me.Controls.Add(Me.BtnGetPhoto)
        Me.Controls.Add(Me.BtnUpdateNewStudents)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnViewaStudent)
        Me.Controls.Add(Me.DataGridViewDISCIPLINEREGISTRATION)
        Me.Name = "frmDataEntryNIDHAMU"
        Me.ShowIcon = False
        Me.Text = "NIDHAMU YA WANAFUNZI DATA MANAGEMENT SYSTEM -Version 1.0.0 - EMUSIRE HIGH SCHOOL"
        CType(Me.DataGridViewDISCIPLINEREGISTRATION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxStudentPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewDISCIPLINEREGISTRATION As DataGridView
    Friend WithEvents BtnViewaStudent As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnUpdateNewStudents As Button
    Friend WithEvents BtnGetPhoto As Button
    Friend WithEvents BtnSavePhoto As Button
    Friend WithEvents OFGSelectImageStudentPhoto As OpenFileDialog
    Friend WithEvents PictureBoxStudentPhoto As PictureBox
    Friend WithEvents BtnEditData As Button
    Friend WithEvents BtnDeleteCurrentRecord As Button
    Friend WithEvents LblPhotoSizes As Label
    Friend WithEvents LblPhotoSizes2 As Label
    Friend WithEvents LblREGDATE As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblEnterCurrentDateClassStreamDorm As Label
    Friend WithEvents BtnRefreshRecords As Button
    Friend WithEvents LblAvoidDuplicateADMNO As Label
End Class
