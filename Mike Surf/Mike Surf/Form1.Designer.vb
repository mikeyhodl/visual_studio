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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.MikeSurf = New System.Windows.Forms.WebBrowser()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnGo = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnForward = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(934, 561)
        Me.WebBrowser1.TabIndex = 0
        '
        'MikeSurf
        '
        Me.MikeSurf.Location = New System.Drawing.Point(12, 56)
        Me.MikeSurf.MinimumSize = New System.Drawing.Size(20, 20)
        Me.MikeSurf.Name = "MikeSurf"
        Me.MikeSurf.Size = New System.Drawing.Size(811, 493)
        Me.MikeSurf.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(230, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(209, 20)
        Me.TextBox1.TabIndex = 2
        '
        'BtnGo
        '
        Me.BtnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnGo.Location = New System.Drawing.Point(468, 27)
        Me.BtnGo.Name = "BtnGo"
        Me.BtnGo.Size = New System.Drawing.Size(75, 23)
        Me.BtnGo.TabIndex = 3
        Me.BtnGo.Text = "Search"
        Me.BtnGo.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(838, 188)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.Text = "Go"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnHome
        '
        Me.BtnHome.Location = New System.Drawing.Point(838, 131)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(75, 23)
        Me.BtnHome.TabIndex = 5
        Me.BtnHome.Text = "Home"
        Me.BtnHome.UseVisualStyleBackColor = True
        '
        'BtnBack
        '
        Me.BtnBack.Location = New System.Drawing.Point(838, 24)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 6
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'BtnForward
        '
        Me.BtnForward.Location = New System.Drawing.Point(838, 79)
        Me.BtnForward.Name = "BtnForward"
        Me.BtnForward.Size = New System.Drawing.Size(75, 23)
        Me.BtnForward.TabIndex = 7
        Me.BtnForward.Text = "Forward"
        Me.BtnForward.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(838, 255)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.BtnRefresh.TabIndex = 8
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 561)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnForward)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnGo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MikeSurf)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Mike Surf"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents MikeSurf As WebBrowser
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnGo As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnHome As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnForward As Button
    Friend WithEvents BtnRefresh As Button
End Class
