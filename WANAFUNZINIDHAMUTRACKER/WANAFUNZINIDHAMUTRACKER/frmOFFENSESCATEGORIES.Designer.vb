<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOFFENSESCATEGORIES
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
        Me.DGVOffensesCategories = New System.Windows.Forms.DataGridView()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnDeleteCurrentRecord = New System.Windows.Forms.Button()
        Me.LblDisciplined = New System.Windows.Forms.Label()
        CType(Me.DGVOffensesCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVOffensesCategories
        '
        Me.DGVOffensesCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOffensesCategories.Location = New System.Drawing.Point(44, 37)
        Me.DGVOffensesCategories.Name = "DGVOffensesCategories"
        Me.DGVOffensesCategories.Size = New System.Drawing.Size(416, 340)
        Me.DGVOffensesCategories.TabIndex = 0
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.LightYellow
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(196, 405)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(116, 23)
        Me.BtnUpdate.TabIndex = 4
        Me.BtnUpdate.Text = "Save"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.LightYellow
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(44, 405)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(116, 23)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnDeleteCurrentRecord
        '
        Me.BtnDeleteCurrentRecord.BackColor = System.Drawing.Color.LightYellow
        Me.BtnDeleteCurrentRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteCurrentRecord.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnDeleteCurrentRecord.Location = New System.Drawing.Point(336, 405)
        Me.BtnDeleteCurrentRecord.Name = "BtnDeleteCurrentRecord"
        Me.BtnDeleteCurrentRecord.Size = New System.Drawing.Size(170, 23)
        Me.BtnDeleteCurrentRecord.TabIndex = 28
        Me.BtnDeleteCurrentRecord.Text = "Delete Current Record"
        Me.BtnDeleteCurrentRecord.UseVisualStyleBackColor = False
        '
        'LblDisciplined
        '
        Me.LblDisciplined.AutoSize = True
        Me.LblDisciplined.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisciplined.ForeColor = System.Drawing.Color.Maroon
        Me.LblDisciplined.Location = New System.Drawing.Point(41, 13)
        Me.LblDisciplined.Name = "LblDisciplined"
        Me.LblDisciplined.Size = New System.Drawing.Size(358, 16)
        Me.LblDisciplined.TabIndex = 29
        Me.LblDisciplined.Text = "N/B: Never delete the special word ""DISCIPLINED"""
        '
        'frmOFFENSESCATEGORIES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(518, 440)
        Me.Controls.Add(Me.LblDisciplined)
        Me.Controls.Add(Me.BtnDeleteCurrentRecord)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.DGVOffensesCategories)
        Me.Name = "frmOFFENSESCATEGORIES"
        Me.ShowIcon = False
        Me.Text = "REGISTER OFFENCES"
        CType(Me.DGVOffensesCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVOffensesCategories As DataGridView
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnDeleteCurrentRecord As Button
    Friend WithEvents LblDisciplined As Label
End Class
