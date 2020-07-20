<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMajorOffencesReportViewerForm
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
        Me.RvMajorOffencesReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RvMajorOffencesReportViewer
        '
        Me.RvMajorOffencesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RvMajorOffencesReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.RvMajorOffencesReportViewer.Name = "RvMajorOffencesReportViewer"
        Me.RvMajorOffencesReportViewer.Size = New System.Drawing.Size(1188, 523)
        Me.RvMajorOffencesReportViewer.TabIndex = 0
        '
        'frmMajorOffencesReportViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 523)
        Me.Controls.Add(Me.RvMajorOffencesReportViewer)
        Me.Name = "frmMajorOffencesReportViewerForm"
        Me.ShowIcon = False
        Me.Text = "frmMajorOffencesReportViewerForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RvMajorOffencesReportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
