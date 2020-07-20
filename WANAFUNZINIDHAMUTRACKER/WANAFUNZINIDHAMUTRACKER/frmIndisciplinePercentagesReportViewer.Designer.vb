<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndisciplinePercentagesReportViewer
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
        Me.dtIndisciplinePercentagesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsIndisciplinePercentages = New WANAFUNZINIDHAMUTRACKER.dsIndisciplinePercentages()
        Me.dtOverallOffenseAnalysisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsOverallOffenseAnalysis = New WANAFUNZINIDHAMUTRACKER.dsOverallOffenseAnalysis()
        Me.RvIndisciplinePercentagesReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.dtIndisciplinePercentagesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsIndisciplinePercentages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOverallOffenseAnalysisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsOverallOffenseAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtIndisciplinePercentagesBindingSource
        '
        Me.dtIndisciplinePercentagesBindingSource.DataMember = "dtIndisciplinePercentages"
        Me.dtIndisciplinePercentagesBindingSource.DataSource = Me.dsIndisciplinePercentages
        '
        'dsIndisciplinePercentages
        '
        Me.dsIndisciplinePercentages.DataSetName = "dsIndisciplinePercentages"
        Me.dsIndisciplinePercentages.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtOverallOffenseAnalysisBindingSource
        '
        Me.dtOverallOffenseAnalysisBindingSource.DataMember = "dtOverallOffenseAnalysis"
        Me.dtOverallOffenseAnalysisBindingSource.DataSource = Me.dsOverallOffenseAnalysis
        '
        'dsOverallOffenseAnalysis
        '
        Me.dsOverallOffenseAnalysis.DataSetName = "dsOverallOffenseAnalysis"
        Me.dsOverallOffenseAnalysis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RvIndisciplinePercentagesReportViewer
        '
        Me.RvIndisciplinePercentagesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsIndisciplinePercentages_dtIndisciplinePercentages"
        ReportDataSource1.Value = Me.dtIndisciplinePercentagesBindingSource
        Me.RvIndisciplinePercentagesReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RvIndisciplinePercentagesReportViewer.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptIndisciplinePercentages.rdlc"
        Me.RvIndisciplinePercentagesReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.RvIndisciplinePercentagesReportViewer.Name = "RvIndisciplinePercentagesReportViewer"
        Me.RvIndisciplinePercentagesReportViewer.Size = New System.Drawing.Size(1236, 511)
        Me.RvIndisciplinePercentagesReportViewer.TabIndex = 0
        '
        'frmIndisciplinePercentagesReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 511)
        Me.Controls.Add(Me.RvIndisciplinePercentagesReportViewer)
        Me.Name = "frmIndisciplinePercentagesReportViewer"
        Me.ShowIcon = False
        Me.Text = "frmIndisciplinePercentagesReportViewer"
        CType(Me.dtIndisciplinePercentagesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsIndisciplinePercentages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOverallOffenseAnalysisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsOverallOffenseAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RvIndisciplinePercentagesReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtIndisciplinePercentagesBindingSource As BindingSource
    Friend WithEvents dsIndisciplinePercentages As dsIndisciplinePercentages
    Friend WithEvents dtOverallOffenseAnalysisBindingSource As BindingSource
    Friend WithEvents dsOverallOffenseAnalysis As dsOverallOffenseAnalysis
End Class
