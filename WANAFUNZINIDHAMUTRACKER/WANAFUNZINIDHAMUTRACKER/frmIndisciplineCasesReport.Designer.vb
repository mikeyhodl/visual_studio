<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndisciplineCasesReportVewer
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
        Me.dtIndisciplineCases2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsIndisciplineCases2 = New WANAFUNZINIDHAMUTRACKER.dsIndisciplineCases2()
        Me.dtIndisciplineCasesRptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsIndisciplineCasesRpt = New WANAFUNZINIDHAMUTRACKER.dsIndisciplineCasesRpt()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.dtIndisciplineCases2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsIndisciplineCases2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtIndisciplineCasesRptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsIndisciplineCasesRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtIndisciplineCases2BindingSource
        '
        Me.dtIndisciplineCases2BindingSource.DataMember = "dtIndisciplineCases2"
        Me.dtIndisciplineCases2BindingSource.DataSource = Me.dsIndisciplineCases2
        '
        'dsIndisciplineCases2
        '
        Me.dsIndisciplineCases2.DataSetName = "dsIndisciplineCases2"
        Me.dsIndisciplineCases2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtIndisciplineCasesRptBindingSource
        '
        Me.dtIndisciplineCasesRptBindingSource.DataMember = "dtIndisciplineCasesRpt"
        Me.dtIndisciplineCasesRptBindingSource.DataSource = Me.dsIndisciplineCasesRpt
        '
        'dsIndisciplineCasesRpt
        '
        Me.dsIndisciplineCasesRpt.DataSetName = "dsIndisciplineCasesRpt"
        Me.dsIndisciplineCasesRpt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsIndisciplineCases2_dtIndisciplineCases2"
        ReportDataSource1.Value = Me.dtIndisciplineCases2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptIndisciplineCases2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1099, 431)
        Me.ReportViewer1.TabIndex = 0
        '
        'frmIndisciplineCasesReportVewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 431)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmIndisciplineCasesReportVewer"
        Me.ShowIcon = False
        Me.Text = "Indiscipline Cases Report Viewer"
        CType(Me.dtIndisciplineCases2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsIndisciplineCases2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtIndisciplineCasesRptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsIndisciplineCasesRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtIndisciplineCasesRptBindingSource As BindingSource
    Friend WithEvents dsIndisciplineCasesRpt As dsIndisciplineCasesRpt
    Friend WithEvents dtIndisciplineCases2BindingSource As BindingSource
    Friend WithEvents dsIndisciplineCases2 As dsIndisciplineCases2
End Class
