<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentDisciplineByDormitoryReportViewer
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
        Me.dtStudentDisciplineByDormitoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsStudentDisciplineByDormitory = New WANAFUNZINIDHAMUTRACKER.dsStudentDisciplineByDormitory()
        Me.RvStudentDisciplineByDormitory = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.dtStudentDisciplineByDormitoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsStudentDisciplineByDormitory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtStudentDisciplineByDormitoryBindingSource
        '
        Me.dtStudentDisciplineByDormitoryBindingSource.DataMember = "dtStudentDisciplineByDormitory"
        Me.dtStudentDisciplineByDormitoryBindingSource.DataSource = Me.dsStudentDisciplineByDormitory
        '
        'dsStudentDisciplineByDormitory
        '
        Me.dsStudentDisciplineByDormitory.DataSetName = "dsStudentDisciplineByDormitory"
        Me.dsStudentDisciplineByDormitory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RvStudentDisciplineByDormitory
        '
        Me.RvStudentDisciplineByDormitory.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsStudentDisciplineByDormitory_dtStudentDisciplineByDormitory"
        ReportDataSource1.Value = Me.dtStudentDisciplineByDormitoryBindingSource
        Me.RvStudentDisciplineByDormitory.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RvStudentDisciplineByDormitory.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.RptStudentDisciplineByDormitory.rdlc"
        Me.RvStudentDisciplineByDormitory.Location = New System.Drawing.Point(0, 0)
        Me.RvStudentDisciplineByDormitory.Name = "RvStudentDisciplineByDormitory"
        Me.RvStudentDisciplineByDormitory.Size = New System.Drawing.Size(1154, 500)
        Me.RvStudentDisciplineByDormitory.TabIndex = 0
        '
        'frmStudentDisciplineByDormitoryReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 500)
        Me.Controls.Add(Me.RvStudentDisciplineByDormitory)
        Me.Name = "frmStudentDisciplineByDormitoryReportViewer"
        Me.ShowIcon = False
        Me.Text = "frmStudentDisciplineByDormitoryReportViewer"
        CType(Me.dtStudentDisciplineByDormitoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsStudentDisciplineByDormitory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RvStudentDisciplineByDormitory As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtStudentDisciplineByDormitoryBindingSource As BindingSource
    Friend WithEvents dsStudentDisciplineByDormitory As dsStudentDisciplineByDormitory
End Class
