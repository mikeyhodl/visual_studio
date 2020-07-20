<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenderIndisciplinePercentagesReportViewer
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.dtGenderIndisciplinePercentagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsGenderIndisciplinePercentages = New WANAFUNZINIDHAMUTRACKER.dsGenderIndisciplinePercentages()
        Me.RvGenderIndisciplinePercentagesReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.dtGenderIndisciplinePercentagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsGenderIndisciplinePercentages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtGenderIndisciplinePercentagesBindingSource
        '
        Me.dtGenderIndisciplinePercentagesBindingSource.DataMember = "dtGenderIndisciplinePercentages"
        Me.dtGenderIndisciplinePercentagesBindingSource.DataSource = Me.dsGenderIndisciplinePercentages
        '
        'dsGenderIndisciplinePercentages
        '
        Me.dsGenderIndisciplinePercentages.DataSetName = "dsGenderIndisciplinePercentages"
        Me.dsGenderIndisciplinePercentages.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RvGenderIndisciplinePercentagesReportViewer
        '
        Me.RvGenderIndisciplinePercentagesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsGenderIndisciplinePercentages_dtGenderIndisciplinePercentages"
        ReportDataSource1.Value = Me.dtGenderIndisciplinePercentagesBindingSource
        Me.RvGenderIndisciplinePercentagesReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RvGenderIndisciplinePercentagesReportViewer.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptGenderIndisciplinePercentages.rdlc"
        Me.RvGenderIndisciplinePercentagesReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.RvGenderIndisciplinePercentagesReportViewer.Name = "RvGenderIndisciplinePercentagesReportViewer"
        Me.RvGenderIndisciplinePercentagesReportViewer.Size = New System.Drawing.Size(1250, 520)
        Me.RvGenderIndisciplinePercentagesReportViewer.TabIndex = 0
        '
        'frmGenderIndisciplinePercentagesReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 520)
        Me.Controls.Add(Me.RvGenderIndisciplinePercentagesReportViewer)
        Me.Name = "frmGenderIndisciplinePercentagesReportViewer"
        Me.ShowIcon = False
        Me.Text = "frmGenderIndisciplinePercentagesReportViewer"
        CType(Me.dtGenderIndisciplinePercentagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsGenderIndisciplinePercentages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RvGenderIndisciplinePercentagesReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtGenderIndisciplinePercentagesBindingSource As BindingSource
    Friend WithEvents dsGenderIndisciplinePercentages As dsGenderIndisciplinePercentages
End Class
