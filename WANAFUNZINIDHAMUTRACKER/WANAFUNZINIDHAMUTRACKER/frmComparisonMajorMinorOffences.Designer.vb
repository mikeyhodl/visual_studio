<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComparisonMajorMinorOffences
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
        Me.rvComparisonMajorMinorOffences = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rvComparisonMajorMinorOffences
        '
        Me.rvComparisonMajorMinorOffences.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvComparisonMajorMinorOffences.Location = New System.Drawing.Point(0, 0)
        Me.rvComparisonMajorMinorOffences.Name = "rvComparisonMajorMinorOffences"
        Me.rvComparisonMajorMinorOffences.Size = New System.Drawing.Size(1126, 495)
        Me.rvComparisonMajorMinorOffences.TabIndex = 0
        '
        'frmComparisonMajorMinorOffences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 495)
        Me.Controls.Add(Me.rvComparisonMajorMinorOffences)
        Me.Name = "frmComparisonMajorMinorOffences"
        Me.ShowIcon = False
        Me.Text = "Comparison Of Major Minor Offences"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvComparisonMajorMinorOffences As Microsoft.Reporting.WinForms.ReportViewer
End Class
