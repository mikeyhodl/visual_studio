<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditUploadedStudentsNidhamu
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
        Me.DgvEditUploadedStudents = New System.Windows.Forms.DataGridView()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.PictureBoxStudentPhoto = New System.Windows.Forms.PictureBox()
        Me.BtnSavePhoto = New System.Windows.Forms.Button()
        Me.BtnGetPhoto = New System.Windows.Forms.Button()
        Me.OFGSelectImageStudentPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.LblPhotoSizes2 = New System.Windows.Forms.Label()
        Me.LblPhotoSizes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboADMNO = New System.Windows.Forms.ComboBox()
        Me.DgvEditNewStudents = New System.Windows.Forms.DataGridView()
        CType(Me.DgvEditUploadedStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxStudentPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvEditNewStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvEditUploadedStudents
        '
        Me.DgvEditUploadedStudents.AllowUserToAddRows = False
        Me.DgvEditUploadedStudents.AllowUserToDeleteRows = False
        Me.DgvEditUploadedStudents.AllowUserToOrderColumns = True
        Me.DgvEditUploadedStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEditUploadedStudents.Location = New System.Drawing.Point(806, 75)
        Me.DgvEditUploadedStudents.Name = "DgvEditUploadedStudents"
        Me.DgvEditUploadedStudents.Size = New System.Drawing.Size(217, 227)
        Me.DgvEditUploadedStudents.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.LightYellow
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(57, 383)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(103, 23)
        Me.BtnClose.TabIndex = 9
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.LightYellow
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(244, 383)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(116, 23)
        Me.BtnUpdate.TabIndex = 10
        Me.BtnUpdate.Text = "Save"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'PictureBoxStudentPhoto
        '
        Me.PictureBoxStudentPhoto.Location = New System.Drawing.Point(1055, 167)
        Me.PictureBoxStudentPhoto.Name = "PictureBoxStudentPhoto"
        Me.PictureBoxStudentPhoto.Size = New System.Drawing.Size(116, 107)
        Me.PictureBoxStudentPhoto.TabIndex = 22
        Me.PictureBoxStudentPhoto.TabStop = False
        '
        'BtnSavePhoto
        '
        Me.BtnSavePhoto.BackColor = System.Drawing.Color.Linen
        Me.BtnSavePhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSavePhoto.Location = New System.Drawing.Point(1042, 300)
        Me.BtnSavePhoto.Name = "BtnSavePhoto"
        Me.BtnSavePhoto.Size = New System.Drawing.Size(129, 23)
        Me.BtnSavePhoto.TabIndex = 21
        Me.BtnSavePhoto.Text = "Send  Photo"
        Me.BtnSavePhoto.UseVisualStyleBackColor = False
        '
        'BtnGetPhoto
        '
        Me.BtnGetPhoto.BackColor = System.Drawing.Color.Linen
        Me.BtnGetPhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGetPhoto.Location = New System.Drawing.Point(1055, 138)
        Me.BtnGetPhoto.Name = "BtnGetPhoto"
        Me.BtnGetPhoto.Size = New System.Drawing.Size(129, 23)
        Me.BtnGetPhoto.TabIndex = 20
        Me.BtnGetPhoto.Text = "Get Photo"
        Me.BtnGetPhoto.UseVisualStyleBackColor = False
        '
        'OFGSelectImageStudentPhoto
        '
        Me.OFGSelectImageStudentPhoto.Filter = "JPEG Files| *.JPG|GIF Files|*.GIF|WIndows Bitmaps|*.BMP"
        '
        'LblPhotoSizes2
        '
        Me.LblPhotoSizes2.AutoSize = True
        Me.LblPhotoSizes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhotoSizes2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblPhotoSizes2.Location = New System.Drawing.Point(1029, 100)
        Me.LblPhotoSizes2.Name = "LblPhotoSizes2"
        Me.LblPhotoSizes2.Size = New System.Drawing.Size(216, 16)
        Me.LblPhotoSizes2.TabIndex = 34
        Me.LblPhotoSizes2.Text = "(Width: 110, height: 115) pixels"
        '
        'LblPhotoSizes
        '
        Me.LblPhotoSizes.AutoSize = True
        Me.LblPhotoSizes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhotoSizes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblPhotoSizes.Location = New System.Drawing.Point(1029, 75)
        Me.LblPhotoSizes.Name = "LblPhotoSizes"
        Me.LblPhotoSizes.Size = New System.Drawing.Size(157, 16)
        Me.LblPhotoSizes.TabIndex = 33
        Me.LblPhotoSizes.Text = "N/B: Use photo sizes:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(492, 425)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(473, 16)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "highlighted in blue when you click the drop down arrow and select it."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(492, 409)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(485, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "N/B: You can also type in the Admission Number.  If it exists, it will be "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label3.Location = New System.Drawing.Point(534, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Select  ADM NO."
        '
        'ComboADMNO
        '
        Me.ComboADMNO.FormattingEnabled = True
        Me.ComboADMNO.Location = New System.Drawing.Point(537, 385)
        Me.ComboADMNO.Name = "ComboADMNO"
        Me.ComboADMNO.Size = New System.Drawing.Size(124, 21)
        Me.ComboADMNO.TabIndex = 42
        '
        'DgvEditNewStudents
        '
        Me.DgvEditNewStudents.AllowUserToAddRows = False
        Me.DgvEditNewStudents.AllowUserToDeleteRows = False
        Me.DgvEditNewStudents.AllowUserToOrderColumns = True
        Me.DgvEditNewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEditNewStudents.Location = New System.Drawing.Point(57, 75)
        Me.DgvEditNewStudents.Name = "DgvEditNewStudents"
        Me.DgvEditNewStudents.Size = New System.Drawing.Size(748, 228)
        Me.DgvEditNewStudents.TabIndex = 39
        '
        'frmEditUploadedStudentsNidhamu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1255, 458)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboADMNO)
        Me.Controls.Add(Me.DgvEditNewStudents)
        Me.Controls.Add(Me.LblPhotoSizes2)
        Me.Controls.Add(Me.LblPhotoSizes)
        Me.Controls.Add(Me.PictureBoxStudentPhoto)
        Me.Controls.Add(Me.BtnSavePhoto)
        Me.Controls.Add(Me.BtnGetPhoto)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.DgvEditUploadedStudents)
        Me.Name = "frmEditUploadedStudentsNidhamu"
        Me.ShowIcon = False
        Me.Text = "Edit Uploaded Students "
        CType(Me.DgvEditUploadedStudents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxStudentPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvEditNewStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvEditUploadedStudents As DataGridView
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents PictureBoxStudentPhoto As PictureBox
    Friend WithEvents BtnSavePhoto As Button
    Friend WithEvents BtnGetPhoto As Button
    Friend WithEvents OFGSelectImageStudentPhoto As OpenFileDialog
    Friend WithEvents LblPhotoSizes2 As Label
    Friend WithEvents LblPhotoSizes As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboADMNO As ComboBox
    Friend WithEvents DgvEditNewStudents As DataGridView
End Class
