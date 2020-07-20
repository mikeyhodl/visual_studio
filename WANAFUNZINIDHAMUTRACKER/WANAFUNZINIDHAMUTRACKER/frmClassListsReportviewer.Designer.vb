<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClassListsReportviewer
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
        Me.dtClassListsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsClassLists = New WANAFUNZINIDHAMUTRACKER.dsClassLists()
        Me.rvClassListsReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.dtClassListsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsClassLists, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtClassListsBindingSource
        '
        Me.dtClassListsBindingSource.DataMember = "dtClassLists"
        Me.dtClassListsBindingSource.DataSource = Me.dsClassLists
        '
        'dsClassLists
        '
        Me.dsClassLists.DataSetName = "dsClassLists"
        Me.dsClassLists.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvClassListsReportViewer
        '
        Me.rvClassListsReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsClassLists_dtClassLists"
        ReportDataSource1.Value = Me.dtClassListsBindingSource
        Me.rvClassListsReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvClassListsReportViewer.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.rptClassLists.rdlc"
        Me.rvClassListsReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.rvClassListsReportViewer.Name = "rvClassListsReportViewer"
        Me.rvClassListsReportViewer.Size = New System.Drawing.Size(1032, 412)
        Me.rvClassListsReportViewer.TabIndex = 0
        '
        'frmClassListsReportviewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 412)
        Me.Controls.Add(Me.rvClassListsReportViewer)
        Me.Name = "frmClassListsReportviewer"
        Me.ShowIcon = False
        Me.Text = "Class Lists Reportviewer"
        CType(Me.dtClassListsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsClassLists, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rvClassListsReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtClassListsBindingSource As BindingSource
    Friend WithEvents dsClassLists As dsClassLists
End Class
