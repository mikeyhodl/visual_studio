<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSUBJECTS
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
        Me.RvSUBJECTSreportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RvSUBJECTSreportViewer
        '
        Me.RvSUBJECTSreportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RvSUBJECTSreportViewer.Location = New System.Drawing.Point(0, 0)
        Me.RvSUBJECTSreportViewer.Name = "RvSUBJECTSreportViewer"
        Me.RvSUBJECTSreportViewer.Size = New System.Drawing.Size(1131, 449)
        Me.RvSUBJECTSreportViewer.TabIndex = 0
        '
        'frmSUBJECTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 449)
        Me.Controls.Add(Me.RvSUBJECTSreportViewer)
        Me.Name = "frmSUBJECTS"
        Me.ShowIcon = False
        Me.Text = "frmSUBJECTS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RvSUBJECTSreportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
