<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBMPFont
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.cboImportType = New System.Windows.Forms.ComboBox()
        Me.cboSaveFileType = New System.Windows.Forms.ComboBox()
        Me.cboCodepage = New System.Windows.Forms.ComboBox()
        Me.lblColRow = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.btnPasteImage = New System.Windows.Forms.Button()
        Me.btnCopyCharImage = New System.Windows.Forms.Button()
        Me.btbInitCharactors = New System.Windows.Forms.Button()
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
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.cboImportType)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cboSaveFileType)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cboCodepage)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblColRow)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCode)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnPasteImage)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCopyCharImage)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btbInitCharactors)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1479, 791)
        Me.SplitContainer1.SplitterDistance = 1027
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 0
        '
        'pnlH
        '
        Me.pnlH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlH.Controls.Add(Me.picH)
        Me.pnlH.Location = New System.Drawing.Point(19, 0)
        Me.pnlH.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlH.Name = "pnlH"
        Me.pnlH.Size = New System.Drawing.Size(1003, 19)
        Me.pnlH.TabIndex = 5
        '
        'picH
        '
        Me.picH.Location = New System.Drawing.Point(0, 0)
        Me.picH.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picH.Name = "picH"
        Me.picH.Size = New System.Drawing.Size(188, 23)
        Me.picH.TabIndex = 0
        Me.picH.TabStop = False
        '
        'pnlV
        '
        Me.pnlV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlV.Controls.Add(Me.picV)
        Me.pnlV.Location = New System.Drawing.Point(0, 19)
        Me.pnlV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlV.Name = "pnlV"
        Me.pnlV.Size = New System.Drawing.Size(19, 772)
        Me.pnlV.TabIndex = 4
        '
        'picV
        '
        Me.picV.Location = New System.Drawing.Point(0, 0)
        Me.picV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picV.Name = "picV"
        Me.picV.Size = New System.Drawing.Size(19, 217)
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
        Me.pnlMain.Location = New System.Drawing.Point(19, 19)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(969, 686)
        Me.pnlMain.TabIndex = 3
        '
        'picMain
        '
        Me.picMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.picMain.Location = New System.Drawing.Point(0, 0)
        Me.picMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(408, 142)
        Me.picMain.TabIndex = 0
        Me.picMain.TabStop = False
        '
        'picHead
        '
        Me.picHead.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.picHead.Location = New System.Drawing.Point(0, 0)
        Me.picHead.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picHead.Name = "picHead"
        Me.picHead.Size = New System.Drawing.Size(19, 19)
        Me.picHead.TabIndex = 0
        Me.picHead.TabStop = False
        '
        'cboImportType
        '
        Me.cboImportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImportType.FormattingEnabled = True
        Me.cboImportType.Items.AddRange(New Object() {"RAW", ".FONT.PNG", ".HZCG6"})
        Me.cboImportType.Location = New System.Drawing.Point(4, 311)
        Me.cboImportType.Name = "cboImportType"
        Me.cboImportType.Size = New System.Drawing.Size(229, 26)
        Me.cboImportType.TabIndex = 24
        '
        'cboSaveFileType
        '
        Me.cboSaveFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSaveFileType.FormattingEnabled = True
        Me.cboSaveFileType.Items.AddRange(New Object() {".FONT.PNG", "RAW", ".HZCG6"})
        Me.cboSaveFileType.Location = New System.Drawing.Point(223, 120)
        Me.cboSaveFileType.Name = "cboSaveFileType"
        Me.cboSaveFileType.Size = New System.Drawing.Size(209, 26)
        Me.cboSaveFileType.TabIndex = 23
        '
        'cboCodepage
        '
        Me.cboCodepage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCodepage.FormattingEnabled = True
        Me.cboCodepage.Items.AddRange(New Object() {"Unknown(0)", "ASCII-7(0)", "ASCII-8(0)", "Unicode(0)", "ISO/IEC13000BMP(0)", "GB2312双字节(936)", "GBK双字节(936)", "GB18030双字节(936)", "Big-5(950)", "Shift-JIS(932)"})
        Me.cboCodepage.Location = New System.Drawing.Point(223, 19)
        Me.cboCodepage.Name = "cboCodepage"
        Me.cboCodepage.Size = New System.Drawing.Size(209, 26)
        Me.cboCodepage.TabIndex = 22
        '
        'lblColRow
        '
        Me.lblColRow.AutoSize = True
        Me.lblColRow.Location = New System.Drawing.Point(4, 433)
        Me.lblColRow.Name = "lblColRow"
        Me.lblColRow.Size = New System.Drawing.Size(143, 18)
        Me.lblColRow.TabIndex = 21
        Me.lblColRow.Text = "Col:      ;Row:"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(4, 416)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(53, 18)
        Me.lblCode.TabIndex = 21
        Me.lblCode.Text = "Code:"
        '
        'btnPasteImage
        '
        Me.btnPasteImage.Location = New System.Drawing.Point(240, 416)
        Me.btnPasteImage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPasteImage.Name = "btnPasteImage"
        Me.btnPasteImage.Size = New System.Drawing.Size(191, 35)
        Me.btnPasteImage.TabIndex = 18
        Me.btnPasteImage.Text = "Paste"
        Me.btnPasteImage.UseVisualStyleBackColor = True
        '
        'btnCopyCharImage
        '
        Me.btnCopyCharImage.Location = New System.Drawing.Point(241, 371)
        Me.btnCopyCharImage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCopyCharImage.Name = "btnCopyCharImage"
        Me.btnCopyCharImage.Size = New System.Drawing.Size(191, 35)
        Me.btnCopyCharImage.TabIndex = 17
        Me.btnCopyCharImage.Text = "Copy"
        Me.btnCopyCharImage.UseVisualStyleBackColor = True
        '
        'btbInitCharactors
        '
        Me.btbInitCharactors.Location = New System.Drawing.Point(60, 53)
        Me.btbInitCharactors.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btbInitCharactors.Name = "btbInitCharactors"
        Me.btbInitCharactors.Size = New System.Drawing.Size(173, 35)
        Me.btbInitCharactors.TabIndex = 16
        Me.btbInitCharactors.Text = "Init Charactors"
        Me.btbInitCharactors.UseVisualStyleBackColor = True
        '
        'txtImportOffset
        '
        Me.txtImportOffset.Location = New System.Drawing.Point(229, 233)
        Me.txtImportOffset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtImportOffset.Name = "txtImportOffset"
        Me.txtImportOffset.Size = New System.Drawing.Size(202, 28)
        Me.txtImportOffset.TabIndex = 11
        Me.txtImportOffset.Text = "0"
        '
        'txtImportSizeH
        '
        Me.txtImportSizeH.Location = New System.Drawing.Point(174, 233)
        Me.txtImportSizeH.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtImportSizeH.Name = "txtImportSizeH"
        Me.txtImportSizeH.Size = New System.Drawing.Size(44, 28)
        Me.txtImportSizeH.TabIndex = 11
        Me.txtImportSizeH.Text = "256"
        '
        'txtImportSizeW
        '
        Me.txtImportSizeW.Location = New System.Drawing.Point(119, 233)
        Me.txtImportSizeW.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtImportSizeW.Name = "txtImportSizeW"
        Me.txtImportSizeW.Size = New System.Drawing.Size(44, 28)
        Me.txtImportSizeW.TabIndex = 12
        Me.txtImportSizeW.Text = "64"
        '
        'txtImportHeight
        '
        Me.txtImportHeight.Location = New System.Drawing.Point(63, 233)
        Me.txtImportHeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtImportHeight.Name = "txtImportHeight"
        Me.txtImportHeight.Size = New System.Drawing.Size(44, 28)
        Me.txtImportHeight.TabIndex = 9
        Me.txtImportHeight.Text = "16"
        '
        'txtImportWidth
        '
        Me.txtImportWidth.Location = New System.Drawing.Point(7, 233)
        Me.txtImportWidth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtImportWidth.Name = "txtImportWidth"
        Me.txtImportWidth.Size = New System.Drawing.Size(44, 28)
        Me.txtImportWidth.TabIndex = 10
        Me.txtImportWidth.Text = "8"
        '
        'txtImportFileName
        '
        Me.txtImportFileName.Location = New System.Drawing.Point(7, 273)
        Me.txtImportFileName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtImportFileName.Name = "txtImportFileName"
        Me.txtImportFileName.Size = New System.Drawing.Size(425, 28)
        Me.txtImportFileName.TabIndex = 8
        Me.txtImportFileName.Text = "C:\Users\张展新\Desktop\font\[AYUMI]N.FNT"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(242, 311)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(191, 35)
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
        Me.picEditor.Location = New System.Drawing.Point(4, 461)
        Me.picEditor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picEditor.Name = "picEditor"
        Me.picEditor.Size = New System.Drawing.Size(402, 306)
        Me.picEditor.TabIndex = 6
        Me.picEditor.TabStop = False
        '
        'txtSaveImage
        '
        Me.txtSaveImage.Location = New System.Drawing.Point(4, 120)
        Me.txtSaveImage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSaveImage.Name = "txtSaveImage"
        Me.txtSaveImage.Size = New System.Drawing.Size(211, 28)
        Me.txtSaveImage.TabIndex = 5
        Me.txtSaveImage.Text = "256"
        '
        'picSave
        '
        Me.picSave.Location = New System.Drawing.Point(171, 120)
        Me.picSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picSave.Name = "picSave"
        Me.picSave.Size = New System.Drawing.Size(46, 35)
        Me.picSave.TabIndex = 4
        Me.picSave.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(241, 158)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(191, 35)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtNewSizeH
        '
        Me.txtNewSizeH.Location = New System.Drawing.Point(171, 18)
        Me.txtNewSizeH.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNewSizeH.Name = "txtNewSizeH"
        Me.txtNewSizeH.Size = New System.Drawing.Size(44, 28)
        Me.txtNewSizeH.TabIndex = 2
        Me.txtNewSizeH.Text = "256"
        '
        'txtNewSizeW
        '
        Me.txtNewSizeW.Location = New System.Drawing.Point(116, 18)
        Me.txtNewSizeW.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNewSizeW.Name = "txtNewSizeW"
        Me.txtNewSizeW.Size = New System.Drawing.Size(44, 28)
        Me.txtNewSizeW.TabIndex = 2
        Me.txtNewSizeW.Text = "256"
        '
        'txtNewHeight
        '
        Me.txtNewHeight.Location = New System.Drawing.Point(60, 18)
        Me.txtNewHeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNewHeight.Name = "txtNewHeight"
        Me.txtNewHeight.Size = New System.Drawing.Size(44, 28)
        Me.txtNewHeight.TabIndex = 1
        Me.txtNewHeight.Text = "48"
        '
        'txtNewWidth
        '
        Me.txtNewWidth.Location = New System.Drawing.Point(4, 18)
        Me.txtNewWidth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNewWidth.Name = "txtNewWidth"
        Me.txtNewWidth.Size = New System.Drawing.Size(44, 28)
        Me.txtNewWidth.TabIndex = 1
        Me.txtNewWidth.Text = "48"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(241, 53)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(191, 35)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1479, 791)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents btbInitCharactors As Button
    Friend WithEvents btnPasteImage As Button
    Friend WithEvents btnCopyCharImage As Button
    Friend WithEvents lblColRow As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents cboCodepage As ComboBox
    Friend WithEvents cboSaveFileType As ComboBox
    Friend WithEvents cboImportType As ComboBox
End Class
