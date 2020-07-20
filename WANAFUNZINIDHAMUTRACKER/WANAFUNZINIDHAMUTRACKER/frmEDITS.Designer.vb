<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEDITS
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
        Me.BtnDiscontinueLeavers = New System.Windows.Forms.Button()
        Me.BtnEditNewStudents = New System.Windows.Forms.Button()
        Me.BtnEditUploadedStudents = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnDeleteEntireDataBase = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnDiscontinueLeavers
        '
        Me.BtnDiscontinueLeavers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDiscontinueLeavers.Location = New System.Drawing.Point(729, 223)
        Me.BtnDiscontinueLeavers.Name = "BtnDiscontinueLeavers"
        Me.BtnDiscontinueLeavers.Size = New System.Drawing.Size(217, 23)
        Me.BtnDiscontinueLeavers.TabIndex = 31
        Me.BtnDiscontinueLeavers.Text = "Discontinue Students who left"
        Me.BtnDiscontinueLeavers.UseVisualStyleBackColor = True
        Me.BtnDiscontinueLeavers.Visible = False
        '
        'BtnEditNewStudents
        '
        Me.BtnEditNewStudents.BackColor = System.Drawing.Color.Linen
        Me.BtnEditNewStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditNewStudents.Location = New System.Drawing.Point(507, 223)
        Me.BtnEditNewStudents.Name = "BtnEditNewStudents"
        Me.BtnEditNewStudents.Size = New System.Drawing.Size(191, 23)
        Me.BtnEditNewStudents.TabIndex = 30
        Me.BtnEditNewStudents.Text = "Edit New Students"
        Me.BtnEditNewStudents.UseVisualStyleBackColor = False
        Me.BtnEditNewStudents.Visible = False
        '
        'BtnEditUploadedStudents
        '
        Me.BtnEditUploadedStudents.BackColor = System.Drawing.Color.Linen
        Me.BtnEditUploadedStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditUploadedStudents.Location = New System.Drawing.Point(307, 223)
        Me.BtnEditUploadedStudents.Name = "BtnEditUploadedStudents"
        Me.BtnEditUploadedStudents.Size = New System.Drawing.Size(194, 23)
        Me.BtnEditUploadedStudents.TabIndex = 29
        Me.BtnEditUploadedStudents.Text = "Edit a Student's data"
        Me.BtnEditUploadedStudents.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.LightYellow
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(12, 223)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(99, 23)
        Me.BtnClose.TabIndex = 32
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnDeleteEntireDataBase
        '
        Me.BtnDeleteEntireDataBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteEntireDataBase.ForeColor = System.Drawing.Color.Red
        Me.BtnDeleteEntireDataBase.Location = New System.Drawing.Point(307, 84)
        Me.BtnDeleteEntireDataBase.Name = "BtnDeleteEntireDataBase"
        Me.BtnDeleteEntireDataBase.Size = New System.Drawing.Size(237, 23)
        Me.BtnDeleteEntireDataBase.TabIndex = 33
        Me.BtnDeleteEntireDataBase.Text = "Delete the Entire Database"
        Me.BtnDeleteEntireDataBase.UseVisualStyleBackColor = True
        '
        'frmEDITS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(948, 296)
        Me.Controls.Add(Me.BtnDeleteEntireDataBase)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnDiscontinueLeavers)
        Me.Controls.Add(Me.BtnEditNewStudents)
        Me.Controls.Add(Me.BtnEditUploadedStudents)
        Me.Name = "frmEDITS"
        Me.ShowIcon = False
        Me.Text = "EDIT DATA"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnDiscontinueLeavers As Button
    Friend WithEvents BtnEditNewStudents As Button
    Friend WithEvents BtnEditUploadedStudents As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnDeleteEntireDataBase As Button
End Class
