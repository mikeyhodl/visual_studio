<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDormitory
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
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.dgvDORMITORY = New System.Windows.Forms.DataGridView()
        Me.BtnDeleteCurrentRecord = New System.Windows.Forms.Button()
        CType(Me.dgvDORMITORY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.LightYellow
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(69, 401)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(116, 23)
        Me.BtnClose.TabIndex = 11
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.LightYellow
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(221, 401)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(116, 23)
        Me.BtnUpdate.TabIndex = 10
        Me.BtnUpdate.Text = "Save"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'dgvDORMITORY
        '
        Me.dgvDORMITORY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDORMITORY.Location = New System.Drawing.Point(69, 33)
        Me.dgvDORMITORY.Name = "dgvDORMITORY"
        Me.dgvDORMITORY.Size = New System.Drawing.Size(416, 340)
        Me.dgvDORMITORY.TabIndex = 9
        '
        'BtnDeleteCurrentRecord
        '
        Me.BtnDeleteCurrentRecord.BackColor = System.Drawing.Color.LightYellow
        Me.BtnDeleteCurrentRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteCurrentRecord.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnDeleteCurrentRecord.Location = New System.Drawing.Point(372, 401)
        Me.BtnDeleteCurrentRecord.Name = "BtnDeleteCurrentRecord"
        Me.BtnDeleteCurrentRecord.Size = New System.Drawing.Size(170, 23)
        Me.BtnDeleteCurrentRecord.TabIndex = 28
        Me.BtnDeleteCurrentRecord.Text = "Delete Current Record"
        Me.BtnDeleteCurrentRecord.UseVisualStyleBackColor = False
        '
        'frmDormitory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(589, 457)
        Me.Controls.Add(Me.BtnDeleteCurrentRecord)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.dgvDORMITORY)
        Me.Name = "frmDormitory"
        Me.ShowIcon = False
        Me.Text = "Dormitories"
        CType(Me.dgvDORMITORY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents dgvDORMITORY As DataGridView
    Friend WithEvents BtnDeleteCurrentRecord As Button
End Class
