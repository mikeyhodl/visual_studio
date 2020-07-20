<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOffenceNarrationsReportViewer
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
        Me.RvOffenceNarrationsReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RvOffenceNarrationsReportViewer
        '
        Me.RvOffenceNarrationsReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RvOffenceNarrationsReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.RvOffenceNarrationsReportViewer.Name = "RvOffenceNarrationsReportViewer"
        Me.RvOffenceNarrationsReportViewer.Size = New System.Drawing.Size(1219, 484)
        Me.RvOffenceNarrationsReportViewer.TabIndex = 0
        '
        'frmOffenceNarrationsReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 484)
        Me.Controls.Add(Me.RvOffenceNarrationsReportViewer)
        Me.Name = "frmOffenceNarrationsReportViewer"
        Me.ShowIcon = False
        Me.Text = "Offence Narrations ReportViewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RvOffenceNarrationsReportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
