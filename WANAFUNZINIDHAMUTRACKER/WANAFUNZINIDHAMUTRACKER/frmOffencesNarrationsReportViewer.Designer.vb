<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOffencesNarrationsReportViewerNotusable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim rvOffencesNarrationsReportViewerNotusable As Microsoft.Reporting.WinForms.ReportViewer
        rvOffencesNarrationsReportViewerNotusable = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rvOffencesNarrationsReportViewerNotusable
        '
        rvOffencesNarrationsReportViewerNotusable.Dock = System.Windows.Forms.DockStyle.Fill
        rvOffencesNarrationsReportViewerNotusable.Location = New System.Drawing.Point(0, 0)
        rvOffencesNarrationsReportViewerNotusable.Name = "rvOffencesNarrationsReportViewerNotusable"
        rvOffencesNarrationsReportViewerNotusable.Size = New System.Drawing.Size(1017, 440)
        rvOffencesNarrationsReportViewerNotusable.TabIndex = 0
        AddHandler rvOffencesNarrationsReportViewerNotusable.Load, AddressOf Me.rvOffencesNarrationsReportViewer_Load
        '
        'frmOffencesNarrationsReportViewerNotusable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 440)
        Me.Controls.Add(rvOffencesNarrationsReportViewerNotusable)
        Me.Name = "frmOffencesNarrationsReportViewerNotusable"
        Me.ShowIcon = False
        Me.Text = "Offences Narrations ReportViewer"
        Me.ResumeLayout(False)

    End Sub
End Class
