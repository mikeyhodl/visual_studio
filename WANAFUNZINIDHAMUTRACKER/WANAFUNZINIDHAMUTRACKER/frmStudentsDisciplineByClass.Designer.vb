<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentsDisciplineByClassReportViewer
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
        Me.dtStudentsDisciplineByClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsStudentsDisciplineByClass = New WANAFUNZINIDHAMUTRACKER.dsStudentsDisciplineByClass()
        Me.RvStudentsDisciplineByClass = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.dtStudentsDisciplineByClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsStudentsDisciplineByClass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtStudentsDisciplineByClassBindingSource
        '
        Me.dtStudentsDisciplineByClassBindingSource.DataMember = "dtStudentsDisciplineByClass"
        Me.dtStudentsDisciplineByClassBindingSource.DataSource = Me.dsStudentsDisciplineByClass
        '
        'dsStudentsDisciplineByClass
        '
        Me.dsStudentsDisciplineByClass.DataSetName = "dsStudentsDisciplineByClass"
        Me.dsStudentsDisciplineByClass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RvStudentsDisciplineByClass
        '
        Me.RvStudentsDisciplineByClass.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsStudentsDisciplineByClass_dtStudentsDisciplineByClass"
        ReportDataSource1.Value = Me.dtStudentsDisciplineByClassBindingSource
        Me.RvStudentsDisciplineByClass.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RvStudentsDisciplineByClass.LocalReport.ReportEmbeddedResource = "WANAFUNZINIDHAMUTRACKER.StudentsDisciplineByClass.rdlc"
        Me.RvStudentsDisciplineByClass.Location = New System.Drawing.Point(0, 0)
        Me.RvStudentsDisciplineByClass.Name = "RvStudentsDisciplineByClass"
        Me.RvStudentsDisciplineByClass.Size = New System.Drawing.Size(1197, 503)
        Me.RvStudentsDisciplineByClass.TabIndex = 0
        '
        'frmStudentsDisciplineByClassReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 503)
        Me.Controls.Add(Me.RvStudentsDisciplineByClass)
        Me.Name = "frmStudentsDisciplineByClassReportViewer"
        Me.ShowIcon = False
        Me.Text = "frmStudentsDisciplineByClassReportViewer"
        CType(Me.dtStudentsDisciplineByClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsStudentsDisciplineByClass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RvStudentsDisciplineByClass As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtStudentsDisciplineByClassBindingSource As BindingSource
    Friend WithEvents dsStudentsDisciplineByClass As dsStudentsDisciplineByClass
End Class
