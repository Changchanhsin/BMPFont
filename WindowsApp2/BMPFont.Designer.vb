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
        Me.btnOpenFolder = New System.Windows.Forms.Button()
        Me.chkBlack = New System.Windows.Forms.CheckBox()
        Me.chkMax = New System.Windows.Forms.CheckBox()
        Me.txtFontName = New System.Windows.Forms.TextBox()
        Me.btnScale = New System.Windows.Forms.Button()
        Me.txtScale = New System.Windows.Forms.TextBox()
        Me.cboImportType = New System.Windows.Forms.ComboBox()
        Me.cboSaveFileType = New System.Windows.Forms.ComboBox()
        Me.cboCodepage = New System.Windows.Forms.ComboBox()
        Me.lblCursor = New System.Windows.Forms.Label()
        Me.lblColRow = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
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
        Me.btn = New System.Windows.Forms.PictureBox()
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
        Me.btnSpecial = New System.Windows.Forms.Button()
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
        CType(Me.btn, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSpecial)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnOpenFolder)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkBlack)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkMax)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtFontName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnScale)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtScale)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cboImportType)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cboSaveFileType)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cboCodepage)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCursor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblColRow)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblInfo)
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtSaveImage)
        Me.SplitContainer1.Panel2.Controls.Add(Me.picSave)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtNewSizeH)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtNewSizeW)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtNewHeight)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtNewWidth)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCreate)
        Me.SplitContainer1.Size = New System.Drawing.Size(986, 527)
        Me.SplitContainer1.SplitterDistance = 684
        Me.SplitContainer1.TabIndex = 0
        '
        'pnlH
        '
        Me.pnlH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlH.Controls.Add(Me.picH)
        Me.pnlH.Location = New System.Drawing.Point(13, 0)
        Me.pnlH.Name = "pnlH"
        Me.pnlH.Size = New System.Drawing.Size(668, 13)
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
        Me.pnlV.Size = New System.Drawing.Size(13, 515)
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
        Me.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlMain.Controls.Add(Me.picMain)
        Me.pnlMain.Location = New System.Drawing.Point(13, 13)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(645, 457)
        Me.pnlMain.TabIndex = 3
        '
        'picMain
        '
        Me.picMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.picMain.Location = New System.Drawing.Point(0, 0)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(272, 95)
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
        'btnOpenFolder
        '
        Me.btnOpenFolder.Location = New System.Drawing.Point(116, 83)
        Me.btnOpenFolder.Name = "btnOpenFolder"
        Me.btnOpenFolder.Size = New System.Drawing.Size(100, 23)
        Me.btnOpenFolder.TabIndex = 29
        Me.btnOpenFolder.Text = "Open folder"
        Me.btnOpenFolder.UseVisualStyleBackColor = True
        '
        'chkBlack
        '
        Me.chkBlack.AutoSize = True
        Me.chkBlack.Location = New System.Drawing.Point(93, 41)
        Me.chkBlack.Name = "chkBlack"
        Me.chkBlack.Size = New System.Drawing.Size(54, 16)
        Me.chkBlack.TabIndex = 28
        Me.chkBlack.Text = "Black"
        Me.chkBlack.UseVisualStyleBackColor = True
        '
        'chkMax
        '
        Me.chkMax.AutoSize = True
        Me.chkMax.Location = New System.Drawing.Point(93, 27)
        Me.chkMax.Name = "chkMax"
        Me.chkMax.Size = New System.Drawing.Size(42, 16)
        Me.chkMax.TabIndex = 28
        Me.chkMax.Text = "Max"
        Me.chkMax.UseVisualStyleBackColor = True
        '
        'txtFontName
        '
        Me.txtFontName.Location = New System.Drawing.Point(5, 27)
        Me.txtFontName.Name = "txtFontName"
        Me.txtFontName.Size = New System.Drawing.Size(82, 21)
        Me.txtFontName.TabIndex = 27
        Me.txtFontName.Text = "宋体"
        '
        'btnScale
        '
        Me.btnScale.Location = New System.Drawing.Point(161, 209)
        Me.btnScale.Name = "btnScale"
        Me.btnScale.Size = New System.Drawing.Size(127, 23)
        Me.btnScale.TabIndex = 26
        Me.btnScale.Text = "Scale up/down"
        Me.btnScale.UseVisualStyleBackColor = True
        '
        'txtScale
        '
        Me.txtScale.Location = New System.Drawing.Point(5, 209)
        Me.txtScale.Name = "txtScale"
        Me.txtScale.Size = New System.Drawing.Size(152, 21)
        Me.txtScale.TabIndex = 25
        Me.txtScale.Text = "100%"
        '
        'cboImportType
        '
        Me.cboImportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImportType.FormattingEnabled = True
        Me.cboImportType.Items.AddRange(New Object() {"RAW", ".FONT.PNG", ".HZCG6"})
        Me.cboImportType.Location = New System.Drawing.Point(5, 174)
        Me.cboImportType.Margin = New System.Windows.Forms.Padding(2)
        Me.cboImportType.Name = "cboImportType"
        Me.cboImportType.Size = New System.Drawing.Size(152, 20)
        Me.cboImportType.TabIndex = 24
        '
        'cboSaveFileType
        '
        Me.cboSaveFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSaveFileType.FormattingEnabled = True
        Me.cboSaveFileType.Items.AddRange(New Object() {".FONT.PNG", "RAW", ".HZCG6", ".CODE.PNG(多个)"})
        Me.cboSaveFileType.Location = New System.Drawing.Point(151, 61)
        Me.cboSaveFileType.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSaveFileType.Name = "cboSaveFileType"
        Me.cboSaveFileType.Size = New System.Drawing.Size(141, 20)
        Me.cboSaveFileType.TabIndex = 23
        '
        'cboCodepage
        '
        Me.cboCodepage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCodepage.FormattingEnabled = True
        Me.cboCodepage.Items.AddRange(New Object() {"Unknown(0)", "ASCII-7(1252)", "ASCII-8(1252)", "UnicodeUCS16(1200)", "ISO/IEC10646BMP(1200)", "ISO/IEC10646SMP(65005)", "ISO/IEC10646SIP(65005)", "ISO/IEC10646TIP(65005)", "GB2312双字节(936)", "GBK双字节(936)", "GB18030单字节(936)", "GB18030双字节(936)", "Big-5双字节(950)", "Big-5单字节(950)", "Shift-JIS双字节(932)", "Shift-JIS单字节(932)"})
        Me.cboCodepage.Location = New System.Drawing.Point(151, 4)
        Me.cboCodepage.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCodepage.Name = "cboCodepage"
        Me.cboCodepage.Size = New System.Drawing.Size(141, 20)
        Me.cboCodepage.TabIndex = 22
        '
        'lblCursor
        '
        Me.lblCursor.AutoSize = True
        Me.lblCursor.Location = New System.Drawing.Point(9, 289)
        Me.lblCursor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCursor.Name = "lblCursor"
        Me.lblCursor.Size = New System.Drawing.Size(47, 12)
        Me.lblCursor.TabIndex = 21
        Me.lblCursor.Text = "Cursor:"
        '
        'lblColRow
        '
        Me.lblColRow.AutoSize = True
        Me.lblColRow.Location = New System.Drawing.Point(9, 277)
        Me.lblColRow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblColRow.Name = "lblColRow"
        Me.lblColRow.Size = New System.Drawing.Size(35, 12)
        Me.lblColRow.TabIndex = 21
        Me.lblColRow.Text = "Edit:"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(9, 247)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(29, 12)
        Me.lblInfo.TabIndex = 21
        Me.lblInfo.Text = "Info"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(9, 262)
        Me.lblCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(29, 12)
        Me.lblCode.TabIndex = 21
        Me.lblCode.Text = "Code"
        '
        'btnPasteImage
        '
        Me.btnPasteImage.Location = New System.Drawing.Point(160, 277)
        Me.btnPasteImage.Name = "btnPasteImage"
        Me.btnPasteImage.Size = New System.Drawing.Size(127, 23)
        Me.btnPasteImage.TabIndex = 18
        Me.btnPasteImage.Text = "Paste"
        Me.btnPasteImage.UseVisualStyleBackColor = True
        '
        'btnCopyCharImage
        '
        Me.btnCopyCharImage.Location = New System.Drawing.Point(161, 247)
        Me.btnCopyCharImage.Name = "btnCopyCharImage"
        Me.btnCopyCharImage.Size = New System.Drawing.Size(127, 23)
        Me.btnCopyCharImage.TabIndex = 17
        Me.btnCopyCharImage.Text = "Copy"
        Me.btnCopyCharImage.UseVisualStyleBackColor = True
        '
        'btbInitCharactors
        '
        Me.btbInitCharactors.Location = New System.Drawing.Point(151, 27)
        Me.btbInitCharactors.Name = "btbInitCharactors"
        Me.btbInitCharactors.Size = New System.Drawing.Size(65, 23)
        Me.btbInitCharactors.TabIndex = 16
        Me.btbInitCharactors.Text = "Init"
        Me.btbInitCharactors.UseVisualStyleBackColor = True
        '
        'txtImportOffset
        '
        Me.txtImportOffset.Location = New System.Drawing.Point(153, 120)
        Me.txtImportOffset.Name = "txtImportOffset"
        Me.txtImportOffset.Size = New System.Drawing.Size(136, 21)
        Me.txtImportOffset.TabIndex = 11
        Me.txtImportOffset.Text = "0"
        '
        'txtImportSizeH
        '
        Me.txtImportSizeH.Location = New System.Drawing.Point(116, 120)
        Me.txtImportSizeH.Name = "txtImportSizeH"
        Me.txtImportSizeH.Size = New System.Drawing.Size(31, 21)
        Me.txtImportSizeH.TabIndex = 11
        Me.txtImportSizeH.Text = "256"
        '
        'txtImportSizeW
        '
        Me.txtImportSizeW.Location = New System.Drawing.Point(79, 120)
        Me.txtImportSizeW.Name = "txtImportSizeW"
        Me.txtImportSizeW.Size = New System.Drawing.Size(31, 21)
        Me.txtImportSizeW.TabIndex = 12
        Me.txtImportSizeW.Text = "64"
        '
        'txtImportHeight
        '
        Me.txtImportHeight.Location = New System.Drawing.Point(42, 120)
        Me.txtImportHeight.Name = "txtImportHeight"
        Me.txtImportHeight.Size = New System.Drawing.Size(31, 21)
        Me.txtImportHeight.TabIndex = 9
        Me.txtImportHeight.Text = "16"
        '
        'txtImportWidth
        '
        Me.txtImportWidth.Location = New System.Drawing.Point(5, 120)
        Me.txtImportWidth.Name = "txtImportWidth"
        Me.txtImportWidth.Size = New System.Drawing.Size(31, 21)
        Me.txtImportWidth.TabIndex = 10
        Me.txtImportWidth.Text = "8"
        '
        'txtImportFileName
        '
        Me.txtImportFileName.Location = New System.Drawing.Point(5, 145)
        Me.txtImportFileName.Name = "txtImportFileName"
        Me.txtImportFileName.Size = New System.Drawing.Size(285, 21)
        Me.txtImportFileName.TabIndex = 8
        Me.txtImportFileName.Text = "C:\Users\张展新\Desktop\font\[AYUMI]N.FNT"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(160, 171)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(127, 23)
        Me.btnImport.TabIndex = 7
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btn
        '
        Me.btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn.Location = New System.Drawing.Point(5, 307)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(264, 204)
        Me.btn.TabIndex = 6
        Me.btn.TabStop = False
        '
        'txtSaveImage
        '
        Me.txtSaveImage.Location = New System.Drawing.Point(5, 61)
        Me.txtSaveImage.Name = "txtSaveImage"
        Me.txtSaveImage.Size = New System.Drawing.Size(142, 21)
        Me.txtSaveImage.TabIndex = 5
        Me.txtSaveImage.Text = "256"
        '
        'picSave
        '
        Me.picSave.Location = New System.Drawing.Point(116, 61)
        Me.picSave.Name = "picSave"
        Me.picSave.Size = New System.Drawing.Size(31, 23)
        Me.picSave.TabIndex = 4
        Me.picSave.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(222, 83)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(68, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtNewSizeH
        '
        Me.txtNewSizeH.Location = New System.Drawing.Point(116, 3)
        Me.txtNewSizeH.Name = "txtNewSizeH"
        Me.txtNewSizeH.Size = New System.Drawing.Size(31, 21)
        Me.txtNewSizeH.TabIndex = 2
        Me.txtNewSizeH.Text = "256"
        '
        'txtNewSizeW
        '
        Me.txtNewSizeW.Location = New System.Drawing.Point(79, 3)
        Me.txtNewSizeW.Name = "txtNewSizeW"
        Me.txtNewSizeW.Size = New System.Drawing.Size(31, 21)
        Me.txtNewSizeW.TabIndex = 2
        Me.txtNewSizeW.Text = "256"
        '
        'txtNewHeight
        '
        Me.txtNewHeight.Location = New System.Drawing.Point(42, 3)
        Me.txtNewHeight.Name = "txtNewHeight"
        Me.txtNewHeight.Size = New System.Drawing.Size(31, 21)
        Me.txtNewHeight.TabIndex = 1
        Me.txtNewHeight.Text = "48"
        '
        'txtNewWidth
        '
        Me.txtNewWidth.Location = New System.Drawing.Point(5, 3)
        Me.txtNewWidth.Name = "txtNewWidth"
        Me.txtNewWidth.Size = New System.Drawing.Size(31, 21)
        Me.txtNewWidth.TabIndex = 1
        Me.txtNewWidth.Text = "48"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(222, 27)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(68, 23)
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
        'btnSpecial
        '
        Me.btnSpecial.Location = New System.Drawing.Point(5, 83)
        Me.btnSpecial.Name = "btnSpecial"
        Me.btnSpecial.Size = New System.Drawing.Size(100, 23)
        Me.btnSpecial.TabIndex = 29
        Me.btnSpecial.Text = "Special"
        Me.btnSpecial.UseVisualStyleBackColor = True
        '
        'frmBMPFont
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 527)
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
        CType(Me.btn, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btn As PictureBox
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
    Friend WithEvents btnScale As Button
    Friend WithEvents txtScale As TextBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblCursor As Label
    Friend WithEvents txtFontName As TextBox
    Friend WithEvents chkMax As CheckBox
    Friend WithEvents chkBlack As CheckBox
    Friend WithEvents btnOpenFolder As Button
    Friend WithEvents btnSpecial As Button
End Class
