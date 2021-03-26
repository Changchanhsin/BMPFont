<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSubFolder = New System.Windows.Forms.TextBox()
        Me.txtCodeRange = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFileNames = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItemPerPage = New System.Windows.Forms.TextBox()
        Me.txtStartupFolder = New System.Windows.Forms.TextBox()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'picMain
        '
        Me.picMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.picMain.Location = New System.Drawing.Point(0, 3)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(612, 200)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMain.TabIndex = 0
        Me.picMain.TabStop = False
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlMain.Controls.Add(Me.picMain)
        Me.pnlMain.Location = New System.Drawing.Point(0, 112)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(795, 504)
        Me.pnlMain.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(720, 622)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSubFolder
        '
        Me.txtSubFolder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubFolder.Location = New System.Drawing.Point(0, 622)
        Me.txtSubFolder.Name = "txtSubFolder"
        Me.txtSubFolder.Size = New System.Drawing.Size(714, 21)
        Me.txtSubFolder.TabIndex = 6
        Me.txtSubFolder.Text = "SubFolderName"
        '
        'txtCodeRange
        '
        Me.txtCodeRange.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodeRange.Location = New System.Drawing.Point(89, 2)
        Me.txtCodeRange.Name = "txtCodeRange"
        Me.txtCodeRange.Size = New System.Drawing.Size(706, 21)
        Me.txtCodeRange.TabIndex = 7
        Me.txtCodeRange.Text = "20000-2A6D6"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 12)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Code range:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "HZ files:"
        '
        'txtFileNames
        '
        Me.txtFileNames.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileNames.Location = New System.Drawing.Point(375, 29)
        Me.txtFileNames.Name = "txtFileNames"
        Me.txtFileNames.Size = New System.Drawing.Size(420, 21)
        Me.txtFileNames.TabIndex = 7
        Me.txtFileNames.Text = "gb5s1516.hz,GB5s2424.hz,gb5s4848.hz"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(89, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Rander"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Items/Page:"
        '
        'txtItemPerPage
        '
        Me.txtItemPerPage.Location = New System.Drawing.Point(89, 56)
        Me.txtItemPerPage.Name = "txtItemPerPage"
        Me.txtItemPerPage.Size = New System.Drawing.Size(49, 21)
        Me.txtItemPerPage.TabIndex = 7
        Me.txtItemPerPage.Text = "12"
        '
        'txtStartupFolder
        '
        Me.txtStartupFolder.Location = New System.Drawing.Point(89, 29)
        Me.txtStartupFolder.Name = "txtStartupFolder"
        Me.txtStartupFolder.Size = New System.Drawing.Size(280, 21)
        Me.txtStartupFolder.TabIndex = 7
        Me.txtStartupFolder.Text = "C:\Users\cesi\Desktop\扩 C.D.E.F(17606)\"
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 647)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStartupFolder)
        Me.Controls.Add(Me.txtItemPerPage)
        Me.Controls.Add(Me.txtFileNames)
        Me.Controls.Add(Me.txtCodeRange)
        Me.Controls.Add(Me.txtSubFolder)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmPrint"
        Me.Text = "Form2"
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMain As PictureBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSubFolder As TextBox
    Friend WithEvents txtCodeRange As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFileNames As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemPerPage As TextBox
    Friend WithEvents txtStartupFolder As TextBox
End Class
