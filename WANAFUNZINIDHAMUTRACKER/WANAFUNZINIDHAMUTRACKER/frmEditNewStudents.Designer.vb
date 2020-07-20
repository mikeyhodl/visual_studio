<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditNewStudents
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
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.DgvEditNewStudents = New System.Windows.Forms.DataGridView()
        Me.LblSelectaStudent = New System.Windows.Forms.Label()
        Me.ComboADMNO = New System.Windows.Forms.ComboBox()
        Me.LblAdmissionNoDescription2 = New System.Windows.Forms.Label()
        Me.LblAdmissionNoDescription1 = New System.Windows.Forms.Label()
        CType(Me.DgvEditNewStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.LightYellow
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(272, 363)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(116, 23)
        Me.BtnUpdate.TabIndex = 13
        Me.BtnUpdate.Text = "Save"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.LightYellow
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(62, 363)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(116, 23)
        Me.BtnClose.TabIndex = 12
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'DgvEditNewStudents
        '
        Me.DgvEditNewStudents.AllowUserToAddRows = False
        Me.DgvEditNewStudents.AllowUserToDeleteRows = False
        Me.DgvEditNewStudents.AllowUserToOrderColumns = True
        Me.DgvEditNewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEditNewStudents.Location = New System.Drawing.Point(62, 37)
        Me.DgvEditNewStudents.Name = "DgvEditNewStudents"
        Me.DgvEditNewStudents.Size = New System.Drawing.Size(368, 320)
        Me.DgvEditNewStudents.TabIndex = 11
        '
        'LblSelectaStudent
        '
        Me.LblSelectaStudent.AutoSize = True
        Me.LblSelectaStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSelectaStudent.ForeColor = System.Drawing.Color.Fuchsia
        Me.LblSelectaStudent.Location = New System.Drawing.Point(59, 399)
        Me.LblSelectaStudent.Name = "LblSelectaStudent"
        Me.LblSelectaStudent.Size = New System.Drawing.Size(123, 16)
        Me.LblSelectaStudent.TabIndex = 20
        Me.LblSelectaStudent.Text = "Select  ADM NO."
        '
        'ComboADMNO
        '
        Me.ComboADMNO.FormattingEnabled = True
        Me.ComboADMNO.Location = New System.Drawing.Point(62, 418)
        Me.ComboADMNO.Name = "ComboADMNO"
        Me.ComboADMNO.Size = New System.Drawing.Size(124, 21)
        Me.ComboADMNO.TabIndex = 19
        '
        'LblAdmissionNoDescription2
        '
        Me.LblAdmissionNoDescription2.AutoSize = True
        Me.LblAdmissionNoDescription2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdmissionNoDescription2.ForeColor = System.Drawing.Color.Blue
        Me.LblAdmissionNoDescription2.Location = New System.Drawing.Point(17, 458)
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
        Me.LblAdmissionNoDescription1.Location = New System.Drawing.Point(17, 442)
        Me.LblAdmissionNoDescription1.Name = "LblAdmissionNoDescription1"
        Me.LblAdmissionNoDescription1.Size = New System.Drawing.Size(485, 16)
        Me.LblAdmissionNoDescription1.TabIndex = 37
        Me.LblAdmissionNoDescription1.Text = "N/B: You can also type in the Admission Number.  If it exists, it will be "
        '
        'frmEditNewStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1106, 480)
        Me.Controls.Add(Me.LblAdmissionNoDescription2)
        Me.Controls.Add(Me.LblAdmissionNoDescription1)
        Me.Controls.Add(Me.LblSelectaStudent)
        Me.Controls.Add(Me.ComboADMNO)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.DgvEditNewStudents)
        Me.Name = "frmEditNewStudents"
        Me.ShowIcon = False
        Me.Text = "Edit New Students"
        CType(Me.DgvEditNewStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents DgvEditNewStudents As DataGridView
    Friend WithEvents LblSelectaStudent As Label
    Friend WithEvents ComboADMNO As ComboBox
    Friend WithEvents LblAdmissionNoDescription2 As Label
    Friend WithEvents LblAdmissionNoDescription1 As Label
End Class
