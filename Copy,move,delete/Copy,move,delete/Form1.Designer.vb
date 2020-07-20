<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnWritetoFile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCopy
        '
        Me.btnCopy.AccessibleName = "btnCopy"
        Me.btnCopy.Location = New System.Drawing.Point(448, 35)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 0
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleName = "btnDelete"
        Me.btnDelete.Location = New System.Drawing.Point(448, 93)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnMove
        '
        Me.btnMove.AccessibleName = "btnMove"
        Me.btnMove.Location = New System.Drawing.Point(448, 146)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(75, 23)
        Me.btnMove.TabIndex = 2
        Me.btnMove.Text = "Move"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.AccessibleName = "btnOpen"
        Me.btnOpen.Location = New System.Drawing.Point(631, 38)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 4
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(126, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 20)
        Me.TextBox1.TabIndex = 5
        '
        'btnWritetoFile
        '
        Me.btnWritetoFile.AccessibleName = "btnWritetoFile"
        Me.btnWritetoFile.Location = New System.Drawing.Point(631, 93)
        Me.btnWritetoFile.Name = "btnWritetoFile"
        Me.btnWritetoFile.Size = New System.Drawing.Size(75, 23)
        Me.btnWritetoFile.TabIndex = 6
        Me.btnWritetoFile.Text = "Write to File"
        Me.btnWritetoFile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 419)
        Me.Controls.Add(Me.btnWritetoFile)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCopy)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCopy As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnMove As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnWritetoFile As Button
End Class
