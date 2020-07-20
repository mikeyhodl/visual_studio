<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndividualMwanafunziReportViewer
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
        Me.dtIndividualMwanafunziBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsIndividualMwanafunzi = New WANAFUNZINIDHAMUTRACKER.dsIndividualMwanafunzi()
        Me.RvIndividualMwanafunziReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.dtIndividualMwanafunziBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsIndividualMwanafunzi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtIndividualMwanafunziBindingSource
        '
        Me.dtIndividualMwanafunziBindingSource.DataMember = "dtIndividualMwanafunzi"
        Me.dtIndividualMwanafunziBindingSource.DataSource = Me.dsIndividualMwanafunzi
        '
        'dsIndividualMwanafunzi
        '
        Me.dsIndividualMwanafunzi.DataSetName = "dsIndividualMwanafunzi"
        Me.dsIndividualMwanafunzi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RvIndividualMwanafunziReportViewer
        '
        Me.RvIndividualMwanafunziReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsIndividualMwanafunzi_dtIndividualMwanafunzi"
        ReportDataSource1.Value = Me.dtIndividualMwanafunziBindingSource
        Me.RvIndividualMwanafunziReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RvIndividualMwanafunziReportViewer.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptIndividualMwanafunzi.rdlc"
        Me.RvIndividualMwanafunziReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.RvIndividualMwanafunziReportViewer.Name = "RvIndividualMwanafunziReportViewer"
        Me.RvIndividualMwanafunziReportViewer.Size = New System.Drawing.Size(1287, 499)
        Me.RvIndividualMwanafunziReportViewer.TabIndex = 0
        '
        'frmIndividualMwanafunziReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 499)
        Me.Controls.Add(Me.RvIndividualMwanafunziReportViewer)
        Me.Name = "frmIndividualMwanafunziReportViewer"
        Me.ShowIcon = False
        Me.Text = "frmIndividualMwanafunziReportViewer"
        CType(Me.dtIndividualMwanafunziBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsIndividualMwanafunzi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RvIndividualMwanafunziReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtIndividualMwanafunziBindingSource As BindingSource
    Friend WithEvents dsIndividualMwanafunzi As dsIndividualMwanafunzi
End Class
