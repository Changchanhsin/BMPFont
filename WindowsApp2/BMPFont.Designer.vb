﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.lblBackColor = New System.Windows.Forms.Label()
        Me.lblForeColor = New System.Windows.Forms.Label()
        Me.chkRound = New System.Windows.Forms.CheckBox()
        Me.chkGrid = New System.Windows.Forms.CheckBox()
        Me.cboCopyType = New System.Windows.Forms.ComboBox()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tagCreate = New System.Windows.Forms.TabPage()
        Me.txtFontName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkBlack = New System.Windows.Forms.CheckBox()
        Me.chkMax = New System.Windows.Forms.CheckBox()
        Me.cboCodepage = New System.Windows.Forms.ComboBox()
        Me.btnInitCharactors = New System.Windows.Forms.Button()
        Me.txtCharSize = New System.Windows.Forms.TextBox()
        Me.txtCharOffsetY = New System.Windows.Forms.TextBox()
        Me.txtCharOffsetX = New System.Windows.Forms.TextBox()
        Me.txtNewSizeH = New System.Windows.Forms.TextBox()
        Me.txtNewSizeW = New System.Windows.Forms.TextBox()
        Me.txtNewHeight = New System.Windows.Forms.TextBox()
        Me.txtNewWidth = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.tagOpen = New System.Windows.Forms.TabPage()
        Me.chkInverse = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboImportType = New System.Windows.Forms.ComboBox()
        Me.txtImportOffset = New System.Windows.Forms.TextBox()
        Me.txtImportSizeH = New System.Windows.Forms.TextBox()
        Me.txtImportSizeW = New System.Windows.Forms.TextBox()
        Me.txtImportHeight = New System.Windows.Forms.TextBox()
        Me.txtImportWidth = New System.Windows.Forms.TextBox()
        Me.txtImportFileName = New System.Windows.Forms.TextBox()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.tagSave = New System.Windows.Forms.TabPage()
        Me.txtCodeRangeEnd = New System.Windows.Forms.TextBox()
        Me.txtCodeRangeStart = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.picSave = New System.Windows.Forms.PictureBox()
        Me.btnOpenFolder = New System.Windows.Forms.Button()
        Me.txtSaveImagePath = New System.Windows.Forms.TextBox()
        Me.cboSaveFileType = New System.Windows.Forms.ComboBox()
        Me.txtSaveImage = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tagEdit = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtMoveY = New System.Windows.Forms.TextBox()
        Me.txtMoveX = New System.Windows.Forms.TextBox()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnToBlackWhite = New System.Windows.Forms.Button()
        Me.btnInverseColor = New System.Windows.Forms.Button()
        Me.btnScale = New System.Windows.Forms.Button()
        Me.txtScale = New System.Windows.Forms.TextBox()
        Me.tagSpecial = New System.Windows.Forms.TabPage()
        Me.btnOutput1 = New System.Windows.Forms.Button()
        Me.btnSpecial = New System.Windows.Forms.Button()
        Me.lblCursor = New System.Windows.Forms.Label()
        Me.lblColRow = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.btnPasteImage = New System.Windows.Forms.Button()
        Me.btnCopyCharImage = New System.Windows.Forms.Button()
        Me.picEdit = New System.Windows.Forms.PictureBox()
        Me.iml35 = New System.Windows.Forms.ImageList(Me.components)
        Me.iml57 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnPic2HZ = New System.Windows.Forms.Button()
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
        Me.tabControl.SuspendLayout()
        Me.tagCreate.SuspendLayout()
        Me.tagOpen.SuspendLayout()
        Me.tagSave.SuspendLayout()
        CType(Me.picSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tagEdit.SuspendLayout()
        Me.tagSpecial.SuspendLayout()
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblBackColor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblForeColor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkRound)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkGrid)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cboCopyType)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tabControl)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCursor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblColRow)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblInfo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCode)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnPasteImage)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCopyCharImage)
        Me.SplitContainer1.Panel2.Controls.Add(Me.picEdit)
        Me.SplitContainer1.Size = New System.Drawing.Size(1241, 779)
        Me.SplitContainer1.SplitterDistance = 794
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
        Me.pnlH.Size = New System.Drawing.Size(771, 19)
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
        Me.pnlV.Size = New System.Drawing.Size(19, 760)
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
        Me.pnlMain.Size = New System.Drawing.Size(738, 673)
        Me.pnlMain.TabIndex = 3
        '
        'picMain
        '
        Me.picMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.picMain.Location = New System.Drawing.Point(0, 0)
        Me.picMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(408, 143)
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
        'lblBackColor
        '
        Me.lblBackColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBackColor.AutoSize = True
        Me.lblBackColor.BackColor = System.Drawing.Color.White
        Me.lblBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBackColor.ForeColor = System.Drawing.Color.Black
        Me.lblBackColor.Location = New System.Drawing.Point(401, 750)
        Me.lblBackColor.Name = "lblBackColor"
        Me.lblBackColor.Size = New System.Drawing.Size(19, 20)
        Me.lblBackColor.TabIndex = 43
        Me.lblBackColor.Text = "B"
        '
        'lblForeColor
        '
        Me.lblForeColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblForeColor.AutoSize = True
        Me.lblForeColor.BackColor = System.Drawing.Color.Black
        Me.lblForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblForeColor.ForeColor = System.Drawing.Color.White
        Me.lblForeColor.Location = New System.Drawing.Point(376, 750)
        Me.lblForeColor.Name = "lblForeColor"
        Me.lblForeColor.Size = New System.Drawing.Size(19, 20)
        Me.lblForeColor.TabIndex = 42
        Me.lblForeColor.Text = "F"
        '
        'chkRound
        '
        Me.chkRound.AutoSize = True
        Me.chkRound.Location = New System.Drawing.Point(84, 751)
        Me.chkRound.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkRound.Name = "chkRound"
        Me.chkRound.Size = New System.Drawing.Size(79, 22)
        Me.chkRound.TabIndex = 41
        Me.chkRound.Text = "round"
        Me.chkRound.UseVisualStyleBackColor = True
        '
        'chkGrid
        '
        Me.chkGrid.AutoSize = True
        Me.chkGrid.Location = New System.Drawing.Point(7, 751)
        Me.chkGrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkGrid.Name = "chkGrid"
        Me.chkGrid.Size = New System.Drawing.Size(70, 22)
        Me.chkGrid.TabIndex = 41
        Me.chkGrid.Text = "grid"
        Me.chkGrid.UseVisualStyleBackColor = True
        '
        'cboCopyType
        '
        Me.cboCopyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCopyType.Items.AddRange(New Object() {"editor image", "image", "SVG", "BIN", "HEX", "OCT", "DEC"})
        Me.cboCopyType.Location = New System.Drawing.Point(240, 373)
        Me.cboCopyType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboCopyType.Name = "cboCopyType"
        Me.cboCopyType.Size = New System.Drawing.Size(94, 26)
        Me.cboCopyType.TabIndex = 36
        '
        'tabControl
        '
        Me.tabControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl.Controls.Add(Me.tagCreate)
        Me.tabControl.Controls.Add(Me.tagOpen)
        Me.tabControl.Controls.Add(Me.tagSave)
        Me.tabControl.Controls.Add(Me.tagEdit)
        Me.tabControl.Controls.Add(Me.tagSpecial)
        Me.tabControl.Location = New System.Drawing.Point(3, 0)
        Me.tabControl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(407, 358)
        Me.tabControl.TabIndex = 30
        '
        'tagCreate
        '
        Me.tagCreate.BackColor = System.Drawing.SystemColors.Control
        Me.tagCreate.Controls.Add(Me.txtFontName)
        Me.tagCreate.Controls.Add(Me.Label2)
        Me.tagCreate.Controls.Add(Me.Label24)
        Me.tagCreate.Controls.Add(Me.Label22)
        Me.tagCreate.Controls.Add(Me.Label4)
        Me.tagCreate.Controls.Add(Me.Label20)
        Me.tagCreate.Controls.Add(Me.Label6)
        Me.tagCreate.Controls.Add(Me.Label5)
        Me.tagCreate.Controls.Add(Me.Label21)
        Me.tagCreate.Controls.Add(Me.Label3)
        Me.tagCreate.Controls.Add(Me.Label8)
        Me.tagCreate.Controls.Add(Me.Label7)
        Me.tagCreate.Controls.Add(Me.Label1)
        Me.tagCreate.Controls.Add(Me.chkBlack)
        Me.tagCreate.Controls.Add(Me.chkMax)
        Me.tagCreate.Controls.Add(Me.cboCodepage)
        Me.tagCreate.Controls.Add(Me.btnInitCharactors)
        Me.tagCreate.Controls.Add(Me.txtCharSize)
        Me.tagCreate.Controls.Add(Me.txtCharOffsetY)
        Me.tagCreate.Controls.Add(Me.txtCharOffsetX)
        Me.tagCreate.Controls.Add(Me.txtNewSizeH)
        Me.tagCreate.Controls.Add(Me.txtNewSizeW)
        Me.tagCreate.Controls.Add(Me.txtNewHeight)
        Me.tagCreate.Controls.Add(Me.txtNewWidth)
        Me.tagCreate.Controls.Add(Me.btnCreate)
        Me.tagCreate.Location = New System.Drawing.Point(4, 28)
        Me.tagCreate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tagCreate.Name = "tagCreate"
        Me.tagCreate.Size = New System.Drawing.Size(399, 326)
        Me.tagCreate.TabIndex = 4
        Me.tagCreate.Text = "Create"
        '
        'txtFontName
        '
        Me.txtFontName.FormattingEnabled = True
        Me.txtFontName.Location = New System.Drawing.Point(102, 156)
        Me.txtFontName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFontName.Name = "txtFontName"
        Me.txtFontName.Size = New System.Drawing.Size(400, 26)
        Me.txtFontName.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 18)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Height:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(332, 222)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 18)
        Me.Label24.TabIndex = 39
        Me.Label24.Text = "Size:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(219, 222)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(26, 18)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Y:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(222, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "High:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 222)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 18)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Offset:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 18)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Font:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 18)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Codepage:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(99, 222)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(26, 18)
        Me.Label21.TabIndex = 39
        Me.Label21.Text = "X:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Low:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 18)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Code Size"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 18)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Char Size"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Width:"
        '
        'chkBlack
        '
        Me.chkBlack.AutoSize = True
        Me.chkBlack.Location = New System.Drawing.Point(189, 192)
        Me.chkBlack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkBlack.Name = "chkBlack"
        Me.chkBlack.Size = New System.Drawing.Size(79, 22)
        Me.chkBlack.TabIndex = 37
        Me.chkBlack.Text = "Black"
        Me.chkBlack.UseVisualStyleBackColor = True
        '
        'chkMax
        '
        Me.chkMax.AutoSize = True
        Me.chkMax.Location = New System.Drawing.Point(99, 192)
        Me.chkMax.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkMax.Name = "chkMax"
        Me.chkMax.Size = New System.Drawing.Size(61, 22)
        Me.chkMax.TabIndex = 38
        Me.chkMax.Text = "Max"
        Me.chkMax.UseVisualStyleBackColor = True
        '
        'cboCodepage
        '
        Me.cboCodepage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCodepage.FormattingEnabled = True
        Me.cboCodepage.Items.AddRange(New Object() {"Unknown(0)", "ASCII-7(1252)", "ASCII-8(1252)", "UnicodeUCS16(1200)", "ISO/IEC10646BMP(1200)", "ISO/IEC10646SMP(65005)", "ISO/IEC10646SIP(65005)", "ISO/IEC10646TIP(65005)", "ISO/IEC10646-Fxxxx(65005)", "GB2312双字节(936)", "GBK双字节(936)", "GB18030单字节(936)", "GB18030双字节(936)", "Big-5双字节(950)", "Big-5单字节(950)", "Shift-JIS双字节(932)", "Shift-JIS单字节(932)"})
        Me.cboCodepage.Location = New System.Drawing.Point(99, 73)
        Me.cboCodepage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboCodepage.Name = "cboCodepage"
        Me.cboCodepage.Size = New System.Drawing.Size(403, 26)
        Me.cboCodepage.TabIndex = 35
        '
        'btnInitCharactors
        '
        Me.btnInitCharactors.Location = New System.Drawing.Point(99, 254)
        Me.btnInitCharactors.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInitCharactors.Name = "btnInitCharactors"
        Me.btnInitCharactors.Size = New System.Drawing.Size(102, 35)
        Me.btnInitCharactors.TabIndex = 34
        Me.btnInitCharactors.Text = "Init"
        Me.btnInitCharactors.UseVisualStyleBackColor = True
        '
        'txtCharSize
        '
        Me.txtCharSize.Location = New System.Drawing.Point(392, 218)
        Me.txtCharSize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCharSize.Name = "txtCharSize"
        Me.txtCharSize.Size = New System.Drawing.Size(73, 28)
        Me.txtCharSize.TabIndex = 32
        '
        'txtCharOffsetY
        '
        Me.txtCharOffsetY.Location = New System.Drawing.Point(252, 218)
        Me.txtCharOffsetY.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCharOffsetY.Name = "txtCharOffsetY"
        Me.txtCharOffsetY.Size = New System.Drawing.Size(50, 28)
        Me.txtCharOffsetY.TabIndex = 32
        '
        'txtCharOffsetX
        '
        Me.txtCharOffsetX.Location = New System.Drawing.Point(132, 218)
        Me.txtCharOffsetX.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCharOffsetX.Name = "txtCharOffsetX"
        Me.txtCharOffsetX.Size = New System.Drawing.Size(49, 28)
        Me.txtCharOffsetX.TabIndex = 33
        '
        'txtNewSizeH
        '
        Me.txtNewSizeH.Location = New System.Drawing.Point(300, 42)
        Me.txtNewSizeH.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNewSizeH.Name = "txtNewSizeH"
        Me.txtNewSizeH.Size = New System.Drawing.Size(50, 28)
        Me.txtNewSizeH.TabIndex = 32
        Me.txtNewSizeH.Text = "256"
        '
        'txtNewSizeW
        '
        Me.txtNewSizeW.Location = New System.Drawing.Point(165, 41)
        Me.txtNewSizeW.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNewSizeW.Name = "txtNewSizeW"
        Me.txtNewSizeW.Size = New System.Drawing.Size(49, 28)
        Me.txtNewSizeW.TabIndex = 33
        Me.txtNewSizeW.Text = "256"
        '
        'txtNewHeight
        '
        Me.txtNewHeight.Location = New System.Drawing.Point(300, 7)
        Me.txtNewHeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNewHeight.Name = "txtNewHeight"
        Me.txtNewHeight.Size = New System.Drawing.Size(49, 28)
        Me.txtNewHeight.TabIndex = 30
        Me.txtNewHeight.Text = "48"
        '
        'txtNewWidth
        '
        Me.txtNewWidth.Location = New System.Drawing.Point(165, 7)
        Me.txtNewWidth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNewWidth.Name = "txtNewWidth"
        Me.txtNewWidth.Size = New System.Drawing.Size(49, 28)
        Me.txtNewWidth.TabIndex = 31
        Me.txtNewWidth.Text = "48"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(99, 106)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(102, 35)
        Me.btnCreate.TabIndex = 29
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'tagOpen
        '
        Me.tagOpen.BackColor = System.Drawing.SystemColors.Control
        Me.tagOpen.Controls.Add(Me.chkInverse)
        Me.tagOpen.Controls.Add(Me.Label9)
        Me.tagOpen.Controls.Add(Me.Label10)
        Me.tagOpen.Controls.Add(Me.Label17)
        Me.tagOpen.Controls.Add(Me.Label16)
        Me.tagOpen.Controls.Add(Me.Label11)
        Me.tagOpen.Controls.Add(Me.Label12)
        Me.tagOpen.Controls.Add(Me.Label13)
        Me.tagOpen.Controls.Add(Me.Label14)
        Me.tagOpen.Controls.Add(Me.Label15)
        Me.tagOpen.Controls.Add(Me.cboImportType)
        Me.tagOpen.Controls.Add(Me.txtImportOffset)
        Me.tagOpen.Controls.Add(Me.txtImportSizeH)
        Me.tagOpen.Controls.Add(Me.txtImportSizeW)
        Me.tagOpen.Controls.Add(Me.txtImportHeight)
        Me.tagOpen.Controls.Add(Me.txtImportWidth)
        Me.tagOpen.Controls.Add(Me.txtImportFileName)
        Me.tagOpen.Controls.Add(Me.btnImport)
        Me.tagOpen.Location = New System.Drawing.Point(4, 28)
        Me.tagOpen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tagOpen.Name = "tagOpen"
        Me.tagOpen.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tagOpen.Size = New System.Drawing.Size(399, 326)
        Me.tagOpen.TabIndex = 0
        Me.tagOpen.Text = "Open"
        '
        'chkInverse
        '
        Me.chkInverse.AutoSize = True
        Me.chkInverse.Location = New System.Drawing.Point(228, 114)
        Me.chkInverse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkInverse.Name = "chkInverse"
        Me.chkInverse.Size = New System.Drawing.Size(97, 22)
        Me.chkInverse.TabIndex = 47
        Me.chkInverse.Text = "Inverse"
        Me.chkInverse.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(225, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 18)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Height:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(225, 82)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 18)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "High:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 150)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 18)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Type:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 18)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "File:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 18)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Offset:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(104, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 18)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Low:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 18)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Code Size"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 18)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Char Size"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(104, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 18)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Width:"
        '
        'cboImportType
        '
        Me.cboImportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImportType.FormattingEnabled = True
        Me.cboImportType.Items.AddRange(New Object() {"RAW", ".FONT.PNG", ".HZCG6"})
        Me.cboImportType.Location = New System.Drawing.Point(107, 146)
        Me.cboImportType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboImportType.Name = "cboImportType"
        Me.cboImportType.Size = New System.Drawing.Size(391, 26)
        Me.cboImportType.TabIndex = 32
        '
        'txtImportOffset
        '
        Me.txtImportOffset.Location = New System.Drawing.Point(107, 114)
        Me.txtImportOffset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtImportOffset.Name = "txtImportOffset"
        Me.txtImportOffset.Size = New System.Drawing.Size(103, 28)
        Me.txtImportOffset.TabIndex = 29
        Me.txtImportOffset.Text = "0"
        '
        'txtImportSizeH
        '
        Me.txtImportSizeH.Location = New System.Drawing.Point(303, 78)
        Me.txtImportSizeH.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtImportSizeH.Name = "txtImportSizeH"
        Me.txtImportSizeH.Size = New System.Drawing.Size(44, 28)
        Me.txtImportSizeH.TabIndex = 30
        Me.txtImportSizeH.Text = "256"
        '
        'txtImportSizeW
        '
        Me.txtImportSizeW.Location = New System.Drawing.Point(165, 78)
        Me.txtImportSizeW.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtImportSizeW.Name = "txtImportSizeW"
        Me.txtImportSizeW.Size = New System.Drawing.Size(44, 28)
        Me.txtImportSizeW.TabIndex = 31
        Me.txtImportSizeW.Text = "64"
        '
        'txtImportHeight
        '
        Me.txtImportHeight.Location = New System.Drawing.Point(303, 42)
        Me.txtImportHeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtImportHeight.Name = "txtImportHeight"
        Me.txtImportHeight.Size = New System.Drawing.Size(44, 28)
        Me.txtImportHeight.TabIndex = 27
        Me.txtImportHeight.Text = "16"
        '
        'txtImportWidth
        '
        Me.txtImportWidth.Location = New System.Drawing.Point(165, 42)
        Me.txtImportWidth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtImportWidth.Name = "txtImportWidth"
        Me.txtImportWidth.Size = New System.Drawing.Size(44, 28)
        Me.txtImportWidth.TabIndex = 28
        Me.txtImportWidth.Text = "8"
        '
        'txtImportFileName
        '
        Me.txtImportFileName.Location = New System.Drawing.Point(107, 6)
        Me.txtImportFileName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtImportFileName.Name = "txtImportFileName"
        Me.txtImportFileName.Size = New System.Drawing.Size(391, 28)
        Me.txtImportFileName.TabIndex = 26
        Me.txtImportFileName.Text = "C:\Users\张展新\Desktop\font\[AYUMI]N.FNT"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(107, 179)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(190, 35)
        Me.btnImport.TabIndex = 25
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'tagSave
        '
        Me.tagSave.BackColor = System.Drawing.SystemColors.Control
        Me.tagSave.Controls.Add(Me.txtCodeRangeEnd)
        Me.tagSave.Controls.Add(Me.txtCodeRangeStart)
        Me.tagSave.Controls.Add(Me.Label30)
        Me.tagSave.Controls.Add(Me.Label29)
        Me.tagSave.Controls.Add(Me.Label19)
        Me.tagSave.Controls.Add(Me.Label23)
        Me.tagSave.Controls.Add(Me.Label18)
        Me.tagSave.Controls.Add(Me.picSave)
        Me.tagSave.Controls.Add(Me.btnOpenFolder)
        Me.tagSave.Controls.Add(Me.txtSaveImagePath)
        Me.tagSave.Controls.Add(Me.cboSaveFileType)
        Me.tagSave.Controls.Add(Me.txtSaveImage)
        Me.tagSave.Controls.Add(Me.btnSave)
        Me.tagSave.Location = New System.Drawing.Point(4, 28)
        Me.tagSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tagSave.Name = "tagSave"
        Me.tagSave.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tagSave.Size = New System.Drawing.Size(399, 326)
        Me.tagSave.TabIndex = 1
        Me.tagSave.Text = "Save"
        '
        'txtCodeRangeEnd
        '
        Me.txtCodeRangeEnd.Location = New System.Drawing.Point(225, 153)
        Me.txtCodeRangeEnd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodeRangeEnd.Name = "txtCodeRangeEnd"
        Me.txtCodeRangeEnd.Size = New System.Drawing.Size(102, 28)
        Me.txtCodeRangeEnd.TabIndex = 48
        Me.txtCodeRangeEnd.Text = "FF"
        '
        'txtCodeRangeStart
        '
        Me.txtCodeRangeStart.Location = New System.Drawing.Point(225, 110)
        Me.txtCodeRangeStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCodeRangeStart.Name = "txtCodeRangeStart"
        Me.txtCodeRangeStart.Size = New System.Drawing.Size(102, 28)
        Me.txtCodeRangeStart.TabIndex = 47
        Me.txtCodeRangeStart.Text = "0"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(64, 150)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(134, 18)
        Me.Label30.TabIndex = 46
        Me.Label30.Text = "CodeRange End:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(63, 116)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(152, 18)
        Me.Label29.TabIndex = 45
        Me.Label29.Text = "CodeRange Start:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 78)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 18)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Type:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 12)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 18)
        Me.Label23.TabIndex = 43
        Me.Label23.Text = "Path:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 18)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "File:"
        '
        'picSave
        '
        Me.picSave.Location = New System.Drawing.Point(4, 191)
        Me.picSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picSave.Name = "picSave"
        Me.picSave.Size = New System.Drawing.Size(46, 35)
        Me.picSave.TabIndex = 34
        Me.picSave.TabStop = False
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Location = New System.Drawing.Point(66, 191)
        Me.btnOpenFolder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOpenFolder.Name = "btnOpenFolder"
        Me.btnOpenFolder.Size = New System.Drawing.Size(150, 35)
        Me.btnOpenFolder.TabIndex = 33
        Me.btnOpenFolder.Text = "Open folder"
        Me.btnOpenFolder.UseVisualStyleBackColor = True
        '
        'txtSaveImagePath
        '
        Me.txtSaveImagePath.Location = New System.Drawing.Point(66, 10)
        Me.txtSaveImagePath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSaveImagePath.Name = "txtSaveImagePath"
        Me.txtSaveImagePath.Size = New System.Drawing.Size(261, 28)
        Me.txtSaveImagePath.TabIndex = 31
        Me.txtSaveImagePath.Text = "256"
        '
        'cboSaveFileType
        '
        Me.cboSaveFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSaveFileType.FormattingEnabled = True
        Me.cboSaveFileType.Items.AddRange(New Object() {".FONT.PNG", "RAW", ".HZCG6", ".CODE.PNG(多个)"})
        Me.cboSaveFileType.Location = New System.Drawing.Point(66, 77)
        Me.cboSaveFileType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboSaveFileType.Name = "cboSaveFileType"
        Me.cboSaveFileType.Size = New System.Drawing.Size(261, 26)
        Me.cboSaveFileType.TabIndex = 32
        '
        'txtSaveImage
        '
        Me.txtSaveImage.Location = New System.Drawing.Point(66, 42)
        Me.txtSaveImage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSaveImage.Name = "txtSaveImage"
        Me.txtSaveImage.Size = New System.Drawing.Size(261, 28)
        Me.txtSaveImage.TabIndex = 31
        Me.txtSaveImage.Text = "256"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(225, 191)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 35)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tagEdit
        '
        Me.tagEdit.BackColor = System.Drawing.SystemColors.Control
        Me.tagEdit.Controls.Add(Me.Label25)
        Me.tagEdit.Controls.Add(Me.Label28)
        Me.tagEdit.Controls.Add(Me.Label26)
        Me.tagEdit.Controls.Add(Me.Label27)
        Me.tagEdit.Controls.Add(Me.txtMoveY)
        Me.tagEdit.Controls.Add(Me.txtMoveX)
        Me.tagEdit.Controls.Add(Me.btnMove)
        Me.tagEdit.Controls.Add(Me.btnToBlackWhite)
        Me.tagEdit.Controls.Add(Me.btnInverseColor)
        Me.tagEdit.Controls.Add(Me.btnScale)
        Me.tagEdit.Controls.Add(Me.txtScale)
        Me.tagEdit.Location = New System.Drawing.Point(4, 28)
        Me.tagEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tagEdit.Name = "tagEdit"
        Me.tagEdit.Size = New System.Drawing.Size(399, 326)
        Me.tagEdit.TabIndex = 2
        Me.tagEdit.Text = "Edit"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(222, 142)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(26, 18)
        Me.Label25.TabIndex = 42
        Me.Label25.Text = "Y:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(8, 6)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(62, 18)
        Me.Label28.TabIndex = 43
        Me.Label28.Text = "Scale:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(8, 142)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(71, 18)
        Me.Label26.TabIndex = 43
        Me.Label26.Text = "Offset:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(100, 142)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(26, 18)
        Me.Label27.TabIndex = 44
        Me.Label27.Text = "X:"
        '
        'txtMoveY
        '
        Me.txtMoveY.Location = New System.Drawing.Point(255, 138)
        Me.txtMoveY.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMoveY.Name = "txtMoveY"
        Me.txtMoveY.Size = New System.Drawing.Size(50, 28)
        Me.txtMoveY.TabIndex = 40
        '
        'txtMoveX
        '
        Me.txtMoveX.Location = New System.Drawing.Point(134, 138)
        Me.txtMoveX.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMoveX.Name = "txtMoveX"
        Me.txtMoveX.Size = New System.Drawing.Size(49, 28)
        Me.txtMoveX.TabIndex = 41
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(90, 174)
        Me.btnMove.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(190, 35)
        Me.btnMove.TabIndex = 28
        Me.btnMove.Text = "Move"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'btnToBlackWhite
        '
        Me.btnToBlackWhite.Location = New System.Drawing.Point(210, 84)
        Me.btnToBlackWhite.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnToBlackWhite.Name = "btnToBlackWhite"
        Me.btnToBlackWhite.Size = New System.Drawing.Size(190, 35)
        Me.btnToBlackWhite.TabIndex = 28
        Me.btnToBlackWhite.Text = "To Black/White"
        Me.btnToBlackWhite.UseVisualStyleBackColor = True
        '
        'btnInverseColor
        '
        Me.btnInverseColor.Location = New System.Drawing.Point(10, 84)
        Me.btnInverseColor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnInverseColor.Name = "btnInverseColor"
        Me.btnInverseColor.Size = New System.Drawing.Size(190, 35)
        Me.btnInverseColor.TabIndex = 28
        Me.btnInverseColor.Text = "Inverse Color"
        Me.btnInverseColor.UseVisualStyleBackColor = True
        '
        'btnScale
        '
        Me.btnScale.Location = New System.Drawing.Point(90, 38)
        Me.btnScale.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnScale.Name = "btnScale"
        Me.btnScale.Size = New System.Drawing.Size(190, 35)
        Me.btnScale.TabIndex = 28
        Me.btnScale.Text = "Scale up/down"
        Me.btnScale.UseVisualStyleBackColor = True
        '
        'txtScale
        '
        Me.txtScale.Location = New System.Drawing.Point(90, 5)
        Me.txtScale.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtScale.Name = "txtScale"
        Me.txtScale.Size = New System.Drawing.Size(192, 28)
        Me.txtScale.TabIndex = 27
        Me.txtScale.Text = "100%"
        '
        'tagSpecial
        '
        Me.tagSpecial.BackColor = System.Drawing.SystemColors.Control
        Me.tagSpecial.Controls.Add(Me.btnPic2HZ)
        Me.tagSpecial.Controls.Add(Me.btnOutput1)
        Me.tagSpecial.Controls.Add(Me.btnSpecial)
        Me.tagSpecial.Location = New System.Drawing.Point(4, 28)
        Me.tagSpecial.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tagSpecial.Name = "tagSpecial"
        Me.tagSpecial.Size = New System.Drawing.Size(399, 326)
        Me.tagSpecial.TabIndex = 3
        Me.tagSpecial.Text = "Special"
        '
        'btnOutput1
        '
        Me.btnOutput1.Location = New System.Drawing.Point(9, 49)
        Me.btnOutput1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOutput1.Name = "btnOutput1"
        Me.btnOutput1.Size = New System.Drawing.Size(396, 35)
        Me.btnOutput1.TabIndex = 31
        Me.btnOutput1.Text = "Output by GB Zones"
        Me.btnOutput1.UseVisualStyleBackColor = True
        '
        'btnSpecial
        '
        Me.btnSpecial.Location = New System.Drawing.Point(9, 5)
        Me.btnSpecial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSpecial.Name = "btnSpecial"
        Me.btnSpecial.Size = New System.Drawing.Size(396, 35)
        Me.btnSpecial.TabIndex = 30
        Me.btnSpecial.Text = "Compare"
        Me.btnSpecial.UseVisualStyleBackColor = True
        '
        'lblCursor
        '
        Me.lblCursor.AutoSize = True
        Me.lblCursor.Location = New System.Drawing.Point(14, 433)
        Me.lblCursor.Name = "lblCursor"
        Me.lblCursor.Size = New System.Drawing.Size(71, 18)
        Me.lblCursor.TabIndex = 21
        Me.lblCursor.Text = "Cursor:"
        '
        'lblColRow
        '
        Me.lblColRow.AutoSize = True
        Me.lblColRow.Location = New System.Drawing.Point(14, 415)
        Me.lblColRow.Name = "lblColRow"
        Me.lblColRow.Size = New System.Drawing.Size(53, 18)
        Me.lblColRow.TabIndex = 21
        Me.lblColRow.Text = "Edit:"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(14, 371)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(44, 18)
        Me.lblInfo.TabIndex = 21
        Me.lblInfo.Text = "Info"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(14, 394)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(44, 18)
        Me.lblCode.TabIndex = 21
        Me.lblCode.Text = "Code"
        '
        'btnPasteImage
        '
        Me.btnPasteImage.Location = New System.Drawing.Point(240, 415)
        Me.btnPasteImage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPasteImage.Name = "btnPasteImage"
        Me.btnPasteImage.Size = New System.Drawing.Size(190, 35)
        Me.btnPasteImage.TabIndex = 18
        Me.btnPasteImage.Text = "Paste"
        Me.btnPasteImage.UseVisualStyleBackColor = True
        '
        'btnCopyCharImage
        '
        Me.btnCopyCharImage.Location = New System.Drawing.Point(343, 371)
        Me.btnCopyCharImage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCopyCharImage.Name = "btnCopyCharImage"
        Me.btnCopyCharImage.Size = New System.Drawing.Size(89, 35)
        Me.btnCopyCharImage.TabIndex = 17
        Me.btnCopyCharImage.Text = "Copy"
        Me.btnCopyCharImage.UseVisualStyleBackColor = True
        '
        'picEdit
        '
        Me.picEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picEdit.Cursor = System.Windows.Forms.Cursors.Cross
        Me.picEdit.InitialImage = Nothing
        Me.picEdit.Location = New System.Drawing.Point(8, 461)
        Me.picEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picEdit.Name = "picEdit"
        Me.picEdit.Size = New System.Drawing.Size(360, 264)
        Me.picEdit.TabIndex = 6
        Me.picEdit.TabStop = False
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
        'btnPic2HZ
        '
        Me.btnPic2HZ.Location = New System.Drawing.Point(10, 94)
        Me.btnPic2HZ.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPic2HZ.Name = "btnPic2HZ"
        Me.btnPic2HZ.Size = New System.Drawing.Size(396, 35)
        Me.btnPic2HZ.TabIndex = 32
        Me.btnPic2HZ.Text = "pic to HZ"
        Me.btnPic2HZ.UseVisualStyleBackColor = True
        '
        'frmBMPFont
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 779)
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
        Me.tabControl.ResumeLayout(False)
        Me.tagCreate.ResumeLayout(False)
        Me.tagCreate.PerformLayout()
        Me.tagOpen.ResumeLayout(False)
        Me.tagOpen.PerformLayout()
        Me.tagSave.ResumeLayout(False)
        Me.tagSave.PerformLayout()
        CType(Me.picSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tagEdit.ResumeLayout(False)
        Me.tagEdit.PerformLayout()
        Me.tagSpecial.ResumeLayout(False)
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents iml35 As ImageList
    Friend WithEvents iml57 As ImageList
    Friend WithEvents picEdit As PictureBox
    Friend WithEvents btnPasteImage As Button
    Friend WithEvents btnCopyCharImage As Button
    Friend WithEvents lblColRow As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblCursor As Label
    Friend WithEvents tabControl As TabControl
    Friend WithEvents tagCreate As TabPage
    Friend WithEvents chkBlack As CheckBox
    Friend WithEvents chkMax As CheckBox
    Friend WithEvents cboCodepage As ComboBox
    Friend WithEvents btnInitCharactors As Button
    Friend WithEvents txtNewSizeH As TextBox
    Friend WithEvents txtNewSizeW As TextBox
    Friend WithEvents txtNewHeight As TextBox
    Friend WithEvents txtNewWidth As TextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents tagOpen As TabPage
    Friend WithEvents cboImportType As ComboBox
    Friend WithEvents txtImportOffset As TextBox
    Friend WithEvents txtImportSizeH As TextBox
    Friend WithEvents txtImportSizeW As TextBox
    Friend WithEvents txtImportHeight As TextBox
    Friend WithEvents txtImportWidth As TextBox
    Friend WithEvents txtImportFileName As TextBox
    Friend WithEvents btnImport As Button
    Friend WithEvents tagSave As TabPage
    Friend WithEvents picSave As PictureBox
    Friend WithEvents btnOpenFolder As Button
    Friend WithEvents cboSaveFileType As ComboBox
    Friend WithEvents txtSaveImage As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents tagEdit As TabPage
    Friend WithEvents btnScale As Button
    Friend WithEvents txtScale As TextBox
    Friend WithEvents tagSpecial As TabPage
    Friend WithEvents btnSpecial As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtCharOffsetY As TextBox
    Friend WithEvents txtCharOffsetX As TextBox
    Friend WithEvents txtFontName As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtSaveImagePath As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtCharSize As TextBox
    Friend WithEvents chkInverse As CheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txtMoveY As TextBox
    Friend WithEvents txtMoveX As TextBox
    Friend WithEvents btnMove As Button
    Friend WithEvents btnInverseColor As Button
    Friend WithEvents btnToBlackWhite As Button
    Friend WithEvents cboCopyType As ComboBox
    Friend WithEvents chkRound As CheckBox
    Friend WithEvents chkGrid As CheckBox
    Friend WithEvents btnOutput1 As Button
    Friend WithEvents lblBackColor As Label
    Friend WithEvents lblForeColor As Label
    Friend WithEvents txtCodeRangeEnd As TextBox
    Friend WithEvents txtCodeRangeStart As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents btnPic2HZ As Button
End Class
