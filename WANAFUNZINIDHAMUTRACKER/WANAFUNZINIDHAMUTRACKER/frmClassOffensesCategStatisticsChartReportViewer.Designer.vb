<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassOffensesCategStatisticsChartReportViewer
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
        Me.dtClassOffensesCategStatisticsChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsClassOffensesCategStatisticsChart = New WANAFUNZINIDHAMUTRACKER.dsClassOffensesCategStatisticsChart()
        Me.RvClassOffensesCategStatisticsChart = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.dtClassOffensesCategStatisticsChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsClassOffensesCategStatisticsChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtClassOffensesCategStatisticsChartBindingSource
        '
        Me.dtClassOffensesCategStatisticsChartBindingSource.DataMember = "dtClassOffensesCategStatisticsChart"
        Me.dtClassOffensesCategStatisticsChartBindingSource.DataSource = Me.dsClassOffensesCategStatisticsChart
        '
        'dsClassOffensesCategStatisticsChart
        '
        Me.dsClassOffensesCategStatisticsChart.DataSetName = "dsClassOffensesCategStatisticsChart"
        Me.dsClassOffensesCategStatisticsChart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RvClassOffensesCategStatisticsChart
        '
        Me.RvClassOffensesCategStatisticsChart.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsClassOffensesCategStatisticsChart_dtClassOffensesCategStatisticsChart"
        ReportDataSource1.Value = Me.dtClassOffensesCategStatisticsChartBindingSource
        Me.RvClassOffensesCategStatisticsChart.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RvClassOffensesCategStatisticsChart.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptClassOffensesCategStatisticsChart.rdlc"
        Me.RvClassOffensesCategStatisticsChart.Location = New System.Drawing.Point(0, 0)
        Me.RvClassOffensesCategStatisticsChart.Name = "RvClassOffensesCategStatisticsChart"
        Me.RvClassOffensesCategStatisticsChart.Size = New System.Drawing.Size(1251, 515)
        Me.RvClassOffensesCategStatisticsChart.TabIndex = 0
        '
        'frmClassOffensesCategStatisticsChartReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 515)
        Me.Controls.Add(Me.RvClassOffensesCategStatisticsChart)
        Me.Name = "frmClassOffensesCategStatisticsChartReportViewer"
        Me.ShowIcon = False
        Me.Text = "frmClassOffensesCategStatisticsChartReportViewer"
        CType(Me.dtClassOffensesCategStatisticsChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsClassOffensesCategStatisticsChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RvClassOffensesCategStatisticsChart As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtClassOffensesCategStatisticsChartBindingSource As BindingSource
    Friend WithEvents dsClassOffensesCategStatisticsChart As dsClassOffensesCategStatisticsChart
End Class
