<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOffensesCategStatisticsChartReportViewer
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
        Me.dtOffensesCategStatisticsChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsOffensesCategStatisticsChart = New WANAFUNZINIDHAMUTRACKER.dsOffensesCategStatisticsChart()
        Me.RvOffensesCategStatisticsChartReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.dtOffensesCategStatisticsChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsOffensesCategStatisticsChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtOffensesCategStatisticsChartBindingSource
        '
        Me.dtOffensesCategStatisticsChartBindingSource.DataMember = "dtOffensesCategStatisticsChart"
        Me.dtOffensesCategStatisticsChartBindingSource.DataSource = Me.dsOffensesCategStatisticsChart
        '
        'dsOffensesCategStatisticsChart
        '
        Me.dsOffensesCategStatisticsChart.DataSetName = "dsOffensesCategStatisticsChart"
        Me.dsOffensesCategStatisticsChart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RvOffensesCategStatisticsChartReportViewer
        '
        Me.RvOffensesCategStatisticsChartReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsOffensesCategStatisticsChart_dtOffensesCategStatisticsChart"
        ReportDataSource1.Value = Me.dtOffensesCategStatisticsChartBindingSource
        Me.RvOffensesCategStatisticsChartReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RvOffensesCategStatisticsChartReportViewer.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptOffensesCategStatisticsChart.rdlc"
        Me.RvOffensesCategStatisticsChartReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.RvOffensesCategStatisticsChartReportViewer.Name = "RvOffensesCategStatisticsChartReportViewer"
        Me.RvOffensesCategStatisticsChartReportViewer.Size = New System.Drawing.Size(1124, 455)
        Me.RvOffensesCategStatisticsChartReportViewer.TabIndex = 0
        '
        'frmOffensesCategStatisticsChartReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 455)
        Me.Controls.Add(Me.RvOffensesCategStatisticsChartReportViewer)
        Me.Name = "frmOffensesCategStatisticsChartReportViewer"
        Me.ShowIcon = False
        Me.Text = "frmOffensesCategStatisticsChart"
        CType(Me.dtOffensesCategStatisticsChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsOffensesCategStatisticsChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RvOffensesCategStatisticsChartReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtOffensesCategStatisticsChartBindingSource As BindingSource
    Friend WithEvents dsOffensesCategStatisticsChart As dsOffensesCategStatisticsChart
End Class
