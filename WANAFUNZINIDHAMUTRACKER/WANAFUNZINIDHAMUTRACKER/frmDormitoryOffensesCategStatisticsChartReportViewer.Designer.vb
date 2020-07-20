<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDormitoryOffensesCategStatisticsChartReportViewer
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
        Me.dtDormitoryOffensesCategStatisticsChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsDormitoryOffensesCategStatisticsChart = New WANAFUNZINIDHAMUTRACKER.dsDormitoryOffensesCategStatisticsChart()
        Me.RvDormitoryOffensesCategStatisticsChart = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.dtDormitoryOffensesCategStatisticsChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsDormitoryOffensesCategStatisticsChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtDormitoryOffensesCategStatisticsChartBindingSource
        '
        Me.dtDormitoryOffensesCategStatisticsChartBindingSource.DataMember = "dtDormitoryOffensesCategStatisticsChart"
        Me.dtDormitoryOffensesCategStatisticsChartBindingSource.DataSource = Me.dsDormitoryOffensesCategStatisticsChart
        '
        'dsDormitoryOffensesCategStatisticsChart
        '
        Me.dsDormitoryOffensesCategStatisticsChart.DataSetName = "dsDormitoryOffensesCategStatisticsChart"
        Me.dsDormitoryOffensesCategStatisticsChart.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RvDormitoryOffensesCategStatisticsChart
        '
        Me.RvDormitoryOffensesCategStatisticsChart.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsDormitoryOffensesCategStatisticsChart_dtDormitoryOffensesCategStatisticsChart"
        ReportDataSource1.Value = Me.dtDormitoryOffensesCategStatisticsChartBindingSource
        Me.RvDormitoryOffensesCategStatisticsChart.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RvDormitoryOffensesCategStatisticsChart.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptDormitoryOffensesCategStatisticsChart.rdlc"
        Me.RvDormitoryOffensesCategStatisticsChart.Location = New System.Drawing.Point(0, 0)
        Me.RvDormitoryOffensesCategStatisticsChart.Name = "RvDormitoryOffensesCategStatisticsChart"
        Me.RvDormitoryOffensesCategStatisticsChart.Size = New System.Drawing.Size(1226, 502)
        Me.RvDormitoryOffensesCategStatisticsChart.TabIndex = 0
        '
        'frmDormitoryOffensesCategStatisticsChartReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 502)
        Me.Controls.Add(Me.RvDormitoryOffensesCategStatisticsChart)
        Me.Name = "frmDormitoryOffensesCategStatisticsChartReportViewer"
        Me.ShowIcon = False
        Me.Text = "frmDormitoryOffensesCategStatisticsChartReportViewer"
        CType(Me.dtDormitoryOffensesCategStatisticsChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsDormitoryOffensesCategStatisticsChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RvDormitoryOffensesCategStatisticsChart As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtDormitoryOffensesCategStatisticsChartBindingSource As BindingSource
    Friend WithEvents dsDormitoryOffensesCategStatisticsChart As dsDormitoryOffensesCategStatisticsChart
End Class
