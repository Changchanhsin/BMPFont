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
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(806, 572)
        Me.SplitContainer1.SplitterDistance = 539
        Me.SplitContainer1.TabIndex = 0
        '
        'pnlH
        '
        Me.pnlH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlH.Controls.Add(Me.picH)
        Me.pnlH.Location = New System.Drawing.Point(13, 0)
        Me.pnlH.Name = "pnlH"
        Me.pnlH.Size = New System.Drawing.Size(523, 13)
        Me.pnlH.TabIndex = 5
        '
        'picH
        '
        Me.picH.Location = New System.Drawing.Point(0, 0)
        Me.picH.Name = "picH"
        Me.picH.Size = New System.Drawing.Size(125, 15)
        Me.picH.TabIndex = 0
        Me.picH.TabStop = False
        '
        'pnlV
        '
        Me.pnlV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlV.Controls.Add(Me.picV)
        Me.pnlV.Location = New System.Drawing.Point(0, 13)
        Me.pnlV.Name = "pnlV"
        Me.pnlV.Size = New System.Drawing.Size(13, 559)
        Me.pnlV.TabIndex = 4
        '
        'picV
        '
        Me.picV.Location = New System.Drawing.Point(0, 0)
        Me.picV.Name = "picV"
        Me.picV.Size = New System.Drawing.Size(13, 145)
        Me.picV.TabIndex = 0
        Me.picV.TabStop = False
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.Controls.Add(Me.picMain)
        Me.pnlMain.Location = New System.Drawing.Point(13, 13)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(523, 559)
        Me.pnlMain.TabIndex = 3
        '
        'picMain
        '
        Me.picMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.picMain.Location = New System.Drawing.Point(0, 0)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(15, 15)
        Me.picMain.TabIndex = 0
        Me.picMain.TabStop = False
        '
        'picHead
        '
        Me.picHead.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.picHead.Location = New System.Drawing.Point(0, 0)
        Me.picHead.Name = "picHead"
        Me.picHead.Size = New System.Drawing.Size(13, 13)
        Me.picHead.TabIndex = 0
        Me.picHead.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Big5"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtImportOffset
        '
        Me.txtImportOffset.Location = New System.Drawing.Point(151, 87)
        Me.txtImportOffset.Name = "txtImportOffset"
        Me.txtImportOffset.Size = New System.Drawing.Size(83, 21)
        Me.txtImportOffset.TabIndex = 11
        Me.txtImportOffset.Text = "0"
        '
        'txtImportSizeH
        '
        Me.txtImportSizeH.Location = New System.Drawing.Point(114, 87)
        Me.txtImportSizeH.Name = "txtImportSizeH"
        Me.txtImportSizeH.Size = New System.Drawing.Size(31, 21)
        Me.txtImportSizeH.TabIndex = 11
        Me.txtImportSizeH.Text = "256"
        '
        'txtImportSizeW
        '
        Me.txtImportSizeW.Location = New System.Drawing.Point(77, 87)
        Me.txtImportSizeW.Name = "txtImportSizeW"
        Me.txtImportSizeW.Size = New System.Drawing.Size(31, 21)
        Me.txtImportSizeW.TabIndex = 12
        Me.txtImportSizeW.Text = "256"
        '
        'txtImportHeight
        '
        Me.txtImportHeight.Location = New System.Drawing.Point(40, 87)
        Me.txtImportHeight.Name = "txtImportHeight"
        Me.txtImportHeight.Size = New System.Drawing.Size(31, 21)
        Me.txtImportHeight.TabIndex = 9
        Me.txtImportHeight.Text = "15"
        '
        'txtImportWidth
        '
        Me.txtImportWidth.Location = New System.Drawing.Point(3, 87)
        Me.txtImportWidth.Name = "txtImportWidth"
        Me.txtImportWidth.Size = New System.Drawing.Size(31, 21)
        Me.txtImportWidth.TabIndex = 10
        Me.txtImportWidth.Text = "16"
        '
        'txtImportFileName
        '
        Me.txtImportFileName.Location = New System.Drawing.Point(3, 114)
        Me.txtImportFileName.Name = "txtImportFileName"
        Me.txtImportFileName.Size = New System.Drawing.Size(231, 21)
        Me.txtImportFileName.TabIndex = 8
        Me.txtImportFileName.Text = "Y:\个人\张展新\设计\字体\Font\[AYUMI]N.FNT"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(159, 141)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
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
        Me.picEditor.Location = New System.Drawing.Point(4, 170)
        Me.picEditor.Name = "picEditor"
        Me.picEditor.Size = New System.Drawing.Size(256, 256)
        Me.picEditor.TabIndex = 6
        Me.picEditor.TabStop = False
        '
        'txtSaveImage
        '
        Me.txtSaveImage.Location = New System.Drawing.Point(3, 39)
        Me.txtSaveImage.Name = "txtSaveImage"
        Me.txtSaveImage.Size = New System.Drawing.Size(142, 21)
        Me.txtSaveImage.TabIndex = 5
        Me.txtSaveImage.Text = "256"
        '
        'picSave
        '
        Me.picSave.Location = New System.Drawing.Point(114, 39)
        Me.picSave.Name = "picSave"
        Me.picSave.Size = New System.Drawing.Size(31, 23)
        Me.picSave.TabIndex = 4
        Me.picSave.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(159, 39)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save PNG"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtNewSizeH
        '
        Me.txtNewSizeH.Location = New System.Drawing.Point(114, 12)
        Me.txtNewSizeH.Name = "txtNewSizeH"
        Me.txtNewSizeH.Size = New System.Drawing.Size(31, 21)
        Me.txtNewSizeH.TabIndex = 2
        Me.txtNewSizeH.Text = "256"
        '
        'txtNewSizeW
        '
        Me.txtNewSizeW.Location = New System.Drawing.Point(77, 12)
        Me.txtNewSizeW.Name = "txtNewSizeW"
        Me.txtNewSizeW.Size = New System.Drawing.Size(31, 21)
        Me.txtNewSizeW.TabIndex = 2
        Me.txtNewSizeW.Text = "256"
        '
        'txtNewHeight
        '
        Me.txtNewHeight.Location = New System.Drawing.Point(40, 12)
        Me.txtNewHeight.Name = "txtNewHeight"
        Me.txtNewHeight.Size = New System.Drawing.Size(31, 21)
        Me.txtNewHeight.TabIndex = 1
        Me.txtNewHeight.Text = "48"
        '
        'txtNewWidth
        '
        Me.txtNewWidth.Location = New System.Drawing.Point(3, 12)
        Me.txtNewWidth.Name = "txtNewWidth"
        Me.txtNewWidth.Size = New System.Drawing.Size(31, 21)
        Me.txtNewWidth.TabIndex = 1
        Me.txtNewWidth.Text = "48"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(159, 10)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
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
        'frmBMPFont
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 572)
        Me.Controls.Add(Me.SplitContainer1)
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
    Friend WithEvents Button1 As Button
End Class
