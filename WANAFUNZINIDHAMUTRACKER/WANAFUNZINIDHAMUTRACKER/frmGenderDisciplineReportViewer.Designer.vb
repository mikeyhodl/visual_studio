<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenderDisciplineReportViewer
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
        Me.rvGenderDiscipline = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rvGenderDiscipline
        '
        Me.rvGenderDiscipline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvGenderDiscipline.Location = New System.Drawing.Point(0, 0)
        Me.rvGenderDiscipline.Name = "rvGenderDiscipline"
        Me.rvGenderDiscipline.Size = New System.Drawing.Size(1271, 511)
        Me.rvGenderDiscipline.TabIndex = 0
        '
        'frmGenderDisciplineReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 511)
        Me.Controls.Add(Me.rvGenderDiscipline)
        Me.Name = "frmGenderDisciplineReportViewer"
        Me.ShowIcon = False
        Me.Text = "frmGenderDisciplineReportViewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvGenderDiscipline As Microsoft.Reporting.WinForms.ReportViewer
End Class
