<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintOuts
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
        Me.DtpBeginningDate = New System.Windows.Forms.DateTimePicker()
        Me.DtpEndingDate = New System.Windows.Forms.DateTimePicker()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnALLIndisciplineCases = New System.Windows.Forms.Button()
        Me.BtnGenerateIndisciplineCases2report = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DtpBeginningDate
        '
        Me.DtpBeginningDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpBeginningDate.Location = New System.Drawing.Point(12, 76)
        Me.DtpBeginningDate.Name = "DtpBeginningDate"
        Me.DtpBeginningDate.Size = New System.Drawing.Size(200, 20)
        Me.DtpBeginningDate.TabIndex = 0
        '
        'DtpEndingDate
        '
        Me.DtpEndingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpEndingDate.Location = New System.Drawing.Point(405, 76)
        Me.DtpEndingDate.Name = "DtpEndingDate"
        Me.DtpEndingDate.Size = New System.Drawing.Size(200, 20)
        Me.DtpEndingDate.TabIndex = 1
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.LightYellow
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(12, 326)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(116, 23)
        Me.BtnClose.TabIndex = 9
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnALLIndisciplineCases
        '
        Me.BtnALLIndisciplineCases.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnALLIndisciplineCases.Location = New System.Drawing.Point(405, 212)
        Me.BtnALLIndisciplineCases.Name = "BtnALLIndisciplineCases"
        Me.BtnALLIndisciplineCases.Size = New System.Drawing.Size(204, 23)
        Me.BtnALLIndisciplineCases.TabIndex = 10
        Me.BtnALLIndisciplineCases.Text = "View All Indiscipline Cases"
        Me.BtnALLIndisciplineCases.UseVisualStyleBackColor = True
        '
        'BtnGenerateIndisciplineCases2report
        '
        Me.BtnGenerateIndisciplineCases2report.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenerateIndisciplineCases2report.Location = New System.Drawing.Point(401, 326)
        Me.BtnGenerateIndisciplineCases2report.Name = "BtnGenerateIndisciplineCases2report"
        Me.BtnGenerateIndisciplineCases2report.Size = New System.Drawing.Size(204, 23)
        Me.BtnGenerateIndisciplineCases2report.TabIndex = 11
        Me.BtnGenerateIndisciplineCases2report.Text = "View All Indiscipline Cases2"
        Me.BtnGenerateIndisciplineCases2report.UseVisualStyleBackColor = True
        '
        'frmPrintOuts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 385)
        Me.Controls.Add(Me.BtnGenerateIndisciplineCases2report)
        Me.Controls.Add(Me.BtnALLIndisciplineCases)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.DtpEndingDate)
        Me.Controls.Add(Me.DtpBeginningDate)
        Me.Name = "frmPrintOuts"
        Me.ShowIcon = False
        Me.Text = "Report PrintOuts"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DtpBeginningDate As DateTimePicker
    Friend WithEvents DtpEndingDate As DateTimePicker
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnALLIndisciplineCases As Button
    Friend WithEvents BtnGenerateIndisciplineCases2report As Button
End Class
