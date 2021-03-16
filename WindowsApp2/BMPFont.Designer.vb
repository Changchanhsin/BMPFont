<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBMPFont
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBMPFont))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pnlH = New System.Windows.Forms.Panel()
        Me.picH = New System.Windows.Forms.PictureBox()
        Me.pnlV = New System.Windows.Forms.Panel()
        Me.picV = New System.Windows.Forms.PictureBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.picHead = New System.Windows.Forms.PictureBox()
        Me.btnBIG5 = New System.Windows.Forms.Button()
        Me.txtImportOffset = New System.Windows.Forms.TextBox()
        Me.txtImportSizeH = New System.Windows.Forms.TextBox()
        Me.txtImportSizeW = New System.Windows.Forms.TextBox()
        Me.txtImportHeight = New System.Windows.Forms.TextBox()
        Me.txtImportWidth = New System.Windows.Forms.TextBox()
        Me.txtImportFileName = New System.Windows.Forms.TextBox()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.picEditor = New System.Windows.Forms.PictureBox()
        Me.txtSaveImage = New System.Windows.Forms.TextBox()
        Me.picSave = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtNewSizeH = New System.Windows.Forms.TextBox()
        Me.txtNewSizeW = New System.Windows.Forms.TextBox()
        Me.txtNewHeight = New System.Windows.Forms.TextBox()
        Me.txtNewWidth = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.iml35 = New System.Windows.Forms.ImageList(Me.components)
        Me.iml57 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSJIS = New System.Windows.Forms.Button()
        Me.btnGB2312 = New System.Windows.Forms.Button()
        Me.btbGBK = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlH.SuspendLayout()
        CType(Me.picH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlV.SuspendLayout()
        CType(Me.picV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlH)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlV)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlMain)
        Me.SplitContainer1.Panel1.Controls.Add(Me.picHead)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btbGBK)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnGB2312)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSJIS)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnBIG5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtImportOffset)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtImportSizeH)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtImportSizeW)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtImportHeight)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtImportWidth)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtImportFileName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnImport)
        Me.SplitContainer1.Panel2.Controls.Add(Me.picEditor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSaveImage)
        Me.SplitContainer1.Panel2.Controls.Add(Me.picSave)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtNewSizeH)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtNewSizeW)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtNewHeight)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtNewWidth)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCreate)
        Me.SplitContainer1.Size = New System.Drawing.Size(1075, 659)
        Me.SplitContainer1.SplitterDistance = 747
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 0
        '
        'pnlH
        '
        Me.pnlH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlH.Controls.Add(Me.picH)
        Me.pnlH.Location = New System.Drawing.Point(17, 0)
        Me.pnlH.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlH.Name = "pnlH"
        Me.pnlH.Size = New System.Drawing.Size(725, 16)
        Me.pnlH.TabIndex = 5
        '
        'picH
        '
        Me.picH.Location = New System.Drawing.Point(0, 0)
        Me.picH.Margin = New System.Windows.Forms.Padding(4)
        Me.picH.Name = "picH"
        Me.picH.Size = New System.Drawing.Size(167, 19)
        Me.picH.TabIndex = 0
        Me.picH.TabStop = False
        '
        'pnlV
        '
        Me.pnlV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlV.Controls.Add(Me.picV)
        Me.pnlV.Location = New System.Drawing.Point(0, 16)
        Me.pnlV.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlV.Name = "pnlV"
        Me.pnlV.Size = New System.Drawing.Size(17, 643)
        Me.pnlV.TabIndex = 4
        '
        'picV
        '
        Me.picV.Location = New System.Drawing.Point(0, 0)
        Me.picV.Margin = New System.Windows.Forms.Padding(4)
        Me.picV.Name = "picV"
        Me.picV.Size = New System.Drawing.Size(17, 181)
        Me.picV.TabIndex = 0
        Me.picV.TabStop = False
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlMain.Controls.Add(Me.picMain)
        Me.pnlMain.Location = New System.Drawing.Point(17, 16)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(695, 572)
        Me.pnlMain.TabIndex = 3
        '
        'picMain
        '
        Me.picMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.picMain.Location = New System.Drawing.Point(0, 0)
        Me.picMain.Margin = New System.Windows.Forms.Padding(4)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(363, 118)
        Me.picMain.TabIndex = 0
        Me.picMain.TabStop = False
        '
        'picHead
        '
        Me.picHead.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.picHead.Location = New System.Drawing.Point(0, 0)
        Me.picHead.Margin = New System.Windows.Forms.Padding(4)
        Me.picHead.Name = "picHead"
        Me.picHead.Size = New System.Drawing.Size(17, 16)
        Me.picHead.TabIndex = 0
        Me.picHead.TabStop = False
        '
        'btnBIG5
        '
        Me.btnBIG5.Location = New System.Drawing.Point(178, 48)
        Me.btnBIG5.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBIG5.Name = "btnBIG5"
        Me.btnBIG5.Size = New System.Drawing.Size(63, 29)
        Me.btnBIG5.TabIndex = 13
        Me.btnBIG5.Text = "Big5"
        Me.btnBIG5.UseVisualStyleBackColor = True
        '
        'txtImportOffset
        '
        Me.txtImportOffset.Location = New System.Drawing.Point(201, 156)
        Me.txtImportOffset.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImportOffset.Name = "txtImportOffset"
        Me.txtImportOffset.Size = New System.Drawing.Size(109, 25)
        Me.txtImportOffset.TabIndex = 11
        Me.txtImportOffset.Text = "0"
        '
        'txtImportSizeH
        '
        Me.txtImportSizeH.Location = New System.Drawing.Point(152, 156)
        Me.txtImportSizeH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImportSizeH.Name = "txtImportSizeH"
        Me.txtImportSizeH.Size = New System.Drawing.Size(40, 25)
        Me.txtImportSizeH.TabIndex = 11
        Me.txtImportSizeH.Text = "256"
        '
        'txtImportSizeW
        '
        Me.txtImportSizeW.Location = New System.Drawing.Point(103, 156)
        Me.txtImportSizeW.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImportSizeW.Name = "txtImportSizeW"
        Me.txtImportSizeW.Size = New System.Drawing.Size(40, 25)
        Me.txtImportSizeW.TabIndex = 12
        Me.txtImportSizeW.Text = "64"
        '
        'txtImportHeight
        '
        Me.txtImportHeight.Location = New System.Drawing.Point(53, 156)
        Me.txtImportHeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImportHeight.Name = "txtImportHeight"
        Me.txtImportHeight.Size = New System.Drawing.Size(40, 25)
        Me.txtImportHeight.TabIndex = 9
        Me.txtImportHeight.Text = "16"
        '
        'txtImportWidth
        '
        Me.txtImportWidth.Location = New System.Drawing.Point(4, 156)
        Me.txtImportWidth.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImportWidth.Name = "txtImportWidth"
        Me.txtImportWidth.Size = New System.Drawing.Size(40, 25)
        Me.txtImportWidth.TabIndex = 10
        Me.txtImportWidth.Text = "8"
        '
        'txtImportFileName
        '
        Me.txtImportFileName.Location = New System.Drawing.Point(4, 189)
        Me.txtImportFileName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImportFileName.Name = "txtImportFileName"
        Me.txtImportFileName.Size = New System.Drawing.Size(307, 25)
        Me.txtImportFileName.TabIndex = 8
        Me.txtImportFileName.Text = "C:\Users\张展新\Desktop\font\[AYUMI]N.FNT"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(212, 223)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(100, 29)
        Me.btnImport.TabIndex = 7
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'picEditor
        '
        Me.picEditor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picEditor.Cursor = System.Windows.Forms.Cursors.Default
        Me.picEditor.Location = New System.Drawing.Point(4, 278)
        Me.picEditor.Margin = New System.Windows.Forms.Padding(4)
        Me.picEditor.Name = "picEditor"
        Me.picEditor.Size = New System.Drawing.Size(303, 288)
        Me.picEditor.TabIndex = 6
        Me.picEditor.TabStop = False
        '
        'txtSaveImage
        '
        Me.txtSaveImage.Location = New System.Drawing.Point(4, 100)
        Me.txtSaveImage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSaveImage.Name = "txtSaveImage"
        Me.txtSaveImage.Size = New System.Drawing.Size(188, 25)
        Me.txtSaveImage.TabIndex = 5
        Me.txtSaveImage.Text = "256"
        '
        'picSave
        '
        Me.picSave.Location = New System.Drawing.Point(152, 100)
        Me.picSave.Margin = New System.Windows.Forms.Padding(4)
        Me.picSave.Name = "picSave"
        Me.picSave.Size = New System.Drawing.Size(41, 29)
        Me.picSave.TabIndex = 4
        Me.picSave.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(212, 100)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 29)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save PNG"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtNewSizeH
        '
        Me.txtNewSizeH.Location = New System.Drawing.Point(152, 15)
        Me.txtNewSizeH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewSizeH.Name = "txtNewSizeH"
        Me.txtNewSizeH.Size = New System.Drawing.Size(40, 25)
        Me.txtNewSizeH.TabIndex = 2
        Me.txtNewSizeH.Text = "256"
        '
        'txtNewSizeW
        '
        Me.txtNewSizeW.Location = New System.Drawing.Point(103, 15)
        Me.txtNewSizeW.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewSizeW.Name = "txtNewSizeW"
        Me.txtNewSizeW.Size = New System.Drawing.Size(40, 25)
        Me.txtNewSizeW.TabIndex = 2
        Me.txtNewSizeW.Text = "256"
        '
        'txtNewHeight
        '
        Me.txtNewHeight.Location = New System.Drawing.Point(53, 15)
        Me.txtNewHeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewHeight.Name = "txtNewHeight"
        Me.txtNewHeight.Size = New System.Drawing.Size(40, 25)
        Me.txtNewHeight.TabIndex = 1
        Me.txtNewHeight.Text = "48"
        '
        'txtNewWidth
        '
        Me.txtNewWidth.Location = New System.Drawing.Point(4, 15)
        Me.txtNewWidth.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewWidth.Name = "txtNewWidth"
        Me.txtNewWidth.Size = New System.Drawing.Size(40, 25)
        Me.txtNewWidth.TabIndex = 1
        Me.txtNewWidth.Text = "48"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(212, 12)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(100, 29)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'iml35
        '
        Me.iml35.ImageStream = CType(resources.GetObject("iml35.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iml35.TransparentColor = System.Drawing.Color.Transparent
        Me.iml35.Images.SetKeyName(0, "3x5.png")
        '
        'iml57
        '
        Me.iml57.ImageStream = CType(resources.GetObject("iml57.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.iml57.TransparentColor = System.Drawing.Color.Transparent
        Me.iml57.Images.SetKeyName(0, "5x7.png")
        '
        'btnSJIS
        '
        Me.btnSJIS.Location = New System.Drawing.Point(249, 48)
        Me.btnSJIS.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSJIS.Name = "btnSJIS"
        Me.btnSJIS.Size = New System.Drawing.Size(63, 29)
        Me.btnSJIS.TabIndex = 14
        Me.btnSJIS.Text = "S-JIS"
        Me.btnSJIS.UseVisualStyleBackColor = True
        '
        'btnGB2312
        '
        Me.btnGB2312.Location = New System.Drawing.Point(17, 48)
        Me.btnGB2312.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGB2312.Name = "btnGB2312"
        Me.btnGB2312.Size = New System.Drawing.Size(82, 29)
        Me.btnGB2312.TabIndex = 15
        Me.btnGB2312.Text = "GB 2312"
        Me.btnGB2312.UseVisualStyleBackColor = True
        '
        'btbGBK
        '
        Me.btbGBK.Location = New System.Drawing.Point(107, 48)
        Me.btbGBK.Margin = New System.Windows.Forms.Padding(4)
        Me.btbGBK.Name = "btbGBK"
        Me.btbGBK.Size = New System.Drawing.Size(63, 29)
        Me.btbGBK.TabIndex = 16
        Me.btbGBK.Text = "GBK"
        Me.btbGBK.UseVisualStyleBackColor = True
        '
        'frmBMPFont
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 659)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmBMPFont"
        Me.Text = "BMP Font"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlH.ResumeLayout(False)
        CType(Me.picH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlV.ResumeLayout(False)
        CType(Me.picV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEditor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents pnlH As Panel
    Friend WithEvents picH As PictureBox
    Friend WithEvents pnlV As Panel
    Friend WithEvents picV As PictureBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents picMain As PictureBox
    Friend WithEvents picHead As PictureBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents iml35 As ImageList
    Friend WithEvents iml57 As ImageList
    Friend WithEvents txtNewHeight As TextBox
    Friend WithEvents txtNewWidth As TextBox
    Friend WithEvents txtNewSizeH As TextBox
    Friend WithEvents txtNewSizeW As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents picSave As PictureBox
    Friend WithEvents txtSaveImage As TextBox
    Friend WithEvents picEditor As PictureBox
    Friend WithEvents txtImportFileName As TextBox
    Friend WithEvents btnImport As Button
    Friend WithEvents txtImportOffset As TextBox
    Friend WithEvents txtImportSizeH As TextBox
    Friend WithEvents txtImportSizeW As TextBox
    Friend WithEvents txtImportHeight As TextBox
    Friend WithEvents txtImportWidth As TextBox
    Friend WithEvents btnBIG5 As Button
    Friend WithEvents btbGBK As Button
    Friend WithEvents btnGB2312 As Button
    Friend WithEvents btnSJIS As Button
End Class
