<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOFFENSETYPE
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
        Me.DGVOFFENSETYPES = New System.Windows.Forms.DataGridView()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDeleteCurrentRecord = New System.Windows.Forms.Button()
        Me.LblNONE = New System.Windows.Forms.Label()
        Me.LblOffenceType = New System.Windows.Forms.Label()
        CType(Me.DGVOFFENSETYPES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVOFFENSETYPES
        '
        Me.DGVOFFENSETYPES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOFFENSETYPES.Location = New System.Drawing.Point(12, 78)
        Me.DGVOFFENSETYPES.Name = "DGVOFFENSETYPES"
        Me.DGVOFFENSETYPES.Size = New System.Drawing.Size(318, 258)
        Me.DGVOFFENSETYPES.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.LightYellow
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(45, 378)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(116, 23)
        Me.BtnClose.TabIndex = 10
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.LightYellow
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(197, 378)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(116, 23)
        Me.BtnUpdate.TabIndex = 9
        Me.BtnUpdate.Text = "Save"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnDeleteCurrentRecord
        '
        Me.BtnDeleteCurrentRecord.BackColor = System.Drawing.Color.LightYellow
        Me.BtnDeleteCurrentRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteCurrentRecord.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnDeleteCurrentRecord.Location = New System.Drawing.Point(340, 378)
        Me.BtnDeleteCurrentRecord.Name = "BtnDeleteCurrentRecord"
        Me.BtnDeleteCurrentRecord.Size = New System.Drawing.Size(170, 23)
        Me.BtnDeleteCurrentRecord.TabIndex = 28
        Me.BtnDeleteCurrentRecord.Text = "Delete Current Record"
        Me.BtnDeleteCurrentRecord.UseVisualStyleBackColor = False
        '
        'LblNONE
        '
        Me.LblNONE.AutoSize = True
        Me.LblNONE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNONE.ForeColor = System.Drawing.Color.Maroon
        Me.LblNONE.Location = New System.Drawing.Point(42, 9)
        Me.LblNONE.Name = "LblNONE"
        Me.LblNONE.Size = New System.Drawing.Size(308, 16)
        Me.LblNONE.TabIndex = 30
        Me.LblNONE.Text = "N/B: Never delete the special word ""NONE"""
        '
        'LblOffenceType
        '
        Me.LblOffenceType.AutoSize = True
        Me.LblOffenceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOffenceType.ForeColor = System.Drawing.Color.Maroon
        Me.LblOffenceType.Location = New System.Drawing.Point(42, 38)
        Me.LblOffenceType.Name = "LblOffenceType"
        Me.LblOffenceType.Size = New System.Drawing.Size(313, 16)
        Me.LblOffenceType.TabIndex = 31
        Me.LblOffenceType.Text = "N/B: Offence Types: ""Major, Minor or NONE"""
        '
        'frmOFFENSETYPE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(522, 413)
        Me.Controls.Add(Me.LblOffenceType)
        Me.Controls.Add(Me.LblNONE)
        Me.Controls.Add(Me.BtnDeleteCurrentRecord)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.DGVOFFENSETYPES)
        Me.Name = "frmOFFENSETYPE"
        Me.ShowIcon = False
        Me.Text = "OFFENSE TYPES"
        CType(Me.DGVOFFENSETYPES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVOFFENSETYPES As DataGridView
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDeleteCurrentRecord As Button
    Friend WithEvents LblNONE As Label
    Friend WithEvents LblOffenceType As Label
End Class
