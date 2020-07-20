<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCLASSSTREAMS
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.DGVCLASSSTREAMS = New System.Windows.Forms.DataGridView()
        Me.DGVSTREAMS = New System.Windows.Forms.DataGridView()
        Me.BtnSaveStreams = New System.Windows.Forms.Button()
        Me.LblClasses = New System.Windows.Forms.Label()
        Me.LblStream = New System.Windows.Forms.Label()
        Me.BtnDeleteCurrentClass = New System.Windows.Forms.Button()
        Me.BtnDeleteStream = New System.Windows.Forms.Button()
        CType(Me.DGVCLASSSTREAMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVSTREAMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.LightYellow
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(12, 360)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(62, 23)
        Me.BtnClose.TabIndex = 10
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.LightYellow
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(102, 360)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(116, 23)
        Me.BtnUpdate.TabIndex = 9
        Me.BtnUpdate.Text = "Save Classes"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        Me.BtnUpdate.Visible = False
        '
        'DGVCLASSSTREAMS
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Fuchsia
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Magenta
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCLASSSTREAMS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVCLASSSTREAMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCLASSSTREAMS.Location = New System.Drawing.Point(12, 62)
        Me.DGVCLASSSTREAMS.Name = "DGVCLASSSTREAMS"
        Me.DGVCLASSSTREAMS.Size = New System.Drawing.Size(373, 279)
        Me.DGVCLASSSTREAMS.TabIndex = 11
        Me.DGVCLASSSTREAMS.Visible = False
        '
        'DGVSTREAMS
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Fuchsia
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Magenta
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVSTREAMS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVSTREAMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSTREAMS.Location = New System.Drawing.Point(458, 62)
        Me.DGVSTREAMS.Name = "DGVSTREAMS"
        Me.DGVSTREAMS.Size = New System.Drawing.Size(228, 279)
        Me.DGVSTREAMS.TabIndex = 12
        '
        'BtnSaveStreams
        '
        Me.BtnSaveStreams.BackColor = System.Drawing.Color.LightYellow
        Me.BtnSaveStreams.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveStreams.Location = New System.Drawing.Point(469, 360)
        Me.BtnSaveStreams.Name = "BtnSaveStreams"
        Me.BtnSaveStreams.Size = New System.Drawing.Size(113, 23)
        Me.BtnSaveStreams.TabIndex = 13
        Me.BtnSaveStreams.Text = "Save Streams"
        Me.BtnSaveStreams.UseVisualStyleBackColor = False
        '
        'LblClasses
        '
        Me.LblClasses.AutoSize = True
        Me.LblClasses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClasses.ForeColor = System.Drawing.Color.Blue
        Me.LblClasses.Location = New System.Drawing.Point(37, 30)
        Me.LblClasses.Name = "LblClasses"
        Me.LblClasses.Size = New System.Drawing.Size(181, 16)
        Me.LblClasses.TabIndex = 14
        Me.LblClasses.Text = "Enter Classes e.g Form 1"
        Me.LblClasses.Visible = False
        '
        'LblStream
        '
        Me.LblStream.AutoSize = True
        Me.LblStream.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStream.ForeColor = System.Drawing.Color.Blue
        Me.LblStream.Location = New System.Drawing.Point(425, 30)
        Me.LblStream.Name = "LblStream"
        Me.LblStream.Size = New System.Drawing.Size(261, 16)
        Me.LblStream.TabIndex = 15
        Me.LblStream.Text = "Enter Streams e.g North, East, Green"
        '
        'BtnDeleteCurrentClass
        '
        Me.BtnDeleteCurrentClass.BackColor = System.Drawing.Color.LightYellow
        Me.BtnDeleteCurrentClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteCurrentClass.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnDeleteCurrentClass.Location = New System.Drawing.Point(224, 360)
        Me.BtnDeleteCurrentClass.Name = "BtnDeleteCurrentClass"
        Me.BtnDeleteCurrentClass.Size = New System.Drawing.Size(170, 23)
        Me.BtnDeleteCurrentClass.TabIndex = 28
        Me.BtnDeleteCurrentClass.Text = "Delete Current Class"
        Me.BtnDeleteCurrentClass.UseVisualStyleBackColor = False
        Me.BtnDeleteCurrentClass.Visible = False
        '
        'BtnDeleteStream
        '
        Me.BtnDeleteStream.BackColor = System.Drawing.Color.LightYellow
        Me.BtnDeleteStream.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteStream.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnDeleteStream.Location = New System.Drawing.Point(605, 360)
        Me.BtnDeleteStream.Name = "BtnDeleteStream"
        Me.BtnDeleteStream.Size = New System.Drawing.Size(170, 23)
        Me.BtnDeleteStream.TabIndex = 29
        Me.BtnDeleteStream.Text = "Delete Current Stream"
        Me.BtnDeleteStream.UseVisualStyleBackColor = False
        '
        'frmCLASSSTREAMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1076, 395)
        Me.Controls.Add(Me.BtnDeleteStream)
        Me.Controls.Add(Me.BtnDeleteCurrentClass)
        Me.Controls.Add(Me.LblStream)
        Me.Controls.Add(Me.LblClasses)
        Me.Controls.Add(Me.BtnSaveStreams)
        Me.Controls.Add(Me.DGVSTREAMS)
        Me.Controls.Add(Me.DGVCLASSSTREAMS)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Name = "frmCLASSSTREAMS"
        Me.ShowIcon = False
        Me.Text = "DEFINE CLASSES AND STREAMS"
        CType(Me.DGVCLASSSTREAMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVSTREAMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents DGVCLASSSTREAMS As DataGridView
    Friend WithEvents DGVSTREAMS As DataGridView
    Friend WithEvents BtnSaveStreams As Button
    Friend WithEvents LblClasses As Label
    Friend WithEvents LblStream As Label
    Friend WithEvents BtnDeleteCurrentClass As Button
    Friend WithEvents BtnDeleteStream As Button
End Class
