<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassEnrolmentReportViewer
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
        Me.rvClassEnrolmentReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'rvClassEnrolmentReportViewer
        '
        Me.rvClassEnrolmentReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvClassEnrolmentReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.rvClassEnrolmentReportViewer.Name = "rvClassEnrolmentReportViewer"
        Me.rvClassEnrolmentReportViewer.Size = New System.Drawing.Size(1086, 416)
        Me.rvClassEnrolmentReportViewer.TabIndex = 0
        '
        'frmClassEnrolmentReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 416)
        Me.Controls.Add(Me.rvClassEnrolmentReportViewer)
        Me.Name = "frmClassEnrolmentReportViewer"
        Me.ShowIcon = False
        Me.Text = "Class Enrolment ReportViewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvClassEnrolmentReportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
