<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFont
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFont))
        Me.split = New System.Windows.Forms.SplitContainer()
        Me.pnlH = New System.Windows.Forms.Panel()
        Me.picH = New System.Windows.Forms.PictureBox()
        Me.picHead = New System.Windows.Forms.PictureBox()
        Me.pnlV = New System.Windows.Forms.Panel()
        Me.picV = New System.Windows.Forms.PictureBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.btnEditorInverse = New System.Windows.Forms.Button()
        Me.lblCodeArraySize = New System.Windows.Forms.Label()
        Me.lblCodeLength = New System.Windows.Forms.Label()
        Me.lblCodepage = New System.Windows.Forms.Label()
        Me.btnEditorRRight = New System.Windows.Forms.Button()
        Me.btnEditorRLeft = New System.Windows.Forms.Button()
        Me.btnEditorRDown = New System.Windows.Forms.Button()
        Me.btnEditorRUp = New System.Windows.Forms.Button()
        Me.btnEditorRight = New System.Windows.Forms.Button()
        Me.btnEditorLeft = New System.Windows.Forms.Button()
        Me.btnEditorDown = New System.Windows.Forms.Button()
        Me.btnEditorUp = New System.Windows.Forms.Button()
        Me.chkGap = New System.Windows.Forms.CheckBox()
        Me.lblBackColor = New System.Windows.Forms.Label()
        Me.lblForeColor = New System.Windows.Forms.Label()
        Me.chkRound = New System.Windows.Forms.CheckBox()
        Me.chkGrid = New System.Windows.Forms.CheckBox()
        Me.cboCopyType = New System.Windows.Forms.ComboBox()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tagCreate = New System.Windows.Forms.TabPage()
        Me.txtFontName = New System.Windows.Forms.ComboBox()
        Me.lblCharsizeHeight = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCharsize = New System.Windows.Forms.Label()
        Me.lblCharsizeWidth = New System.Windows.Forms.Label()
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
        Me.txtInsertEnd = New System.Windows.Forms.TextBox()
        Me.lblImport = New System.Windows.Forms.Label()
        Me.chkBigEndding = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboImportCodepage = New System.Windows.Forms.ComboBox()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtInsertStart = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
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
        Me.btnOpenSaveimagepath = New System.Windows.Forms.Button()
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
        Me.btnCopyCode = New System.Windows.Forms.Button()
        Me.btnImportClean = New System.Windows.Forms.Button()
        Me.btnCharacterAdjust = New System.Windows.Forms.Button()
        Me.btnMoveCode = New System.Windows.Forms.Button()
        Me.txtMoveTo = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtMoveEnd = New System.Windows.Forms.TextBox()
        Me.txtMoveStart = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtMoveY = New System.Windows.Forms.TextBox()
        Me.txtMoveX = New System.Windows.Forms.TextBox()
        Me.btnToBlackWhite = New System.Windows.Forms.Button()
        Me.btnInverseColor = New System.Windows.Forms.Button()
        Me.btnScale = New System.Windows.Forms.Button()
        Me.txtScale = New System.Windows.Forms.TextBox()
        Me.tagSpecial = New System.Windows.Forms.TabPage()
        Me.btnPic2HZ = New System.Windows.Forms.Button()
        Me.btnOutput1 = New System.Windows.Forms.Button()
        Me.btnSpecial = New System.Windows.Forms.Button()
        Me.lblCursor = New System.Windows.Forms.Label()
        Me.lblColRow = New System.Windows.Forms.Label()
        Me.lblCharacterSize = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.btnPasteImage = New System.Windows.Forms.Button()
        Me.btnCopyCharImage = New System.Windows.Forms.Button()
        Me.picEdit = New System.Windows.Forms.PictureBox()
        Me.iml35 = New System.Windows.Forms.ImageList(Me.components)
        Me.iml57 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.folderSave = New System.Windows.Forms.FolderBrowserDialog()
        Me.fileOpen = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpenSave = New System.Windows.Forms.Button()
        CType(Me.split, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.split.Panel1.SuspendLayout()
        Me.split.Panel2.SuspendLayout()
        Me.split.SuspendLayout()
        Me.pnlH.SuspendLayout()
        CType(Me.picH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlV.SuspendLayout()
        CType(Me.picV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'split
        '
        Me.split.Dock = System.Windows.Forms.DockStyle.Fill
        Me.split.Location = New System.Drawing.Point(0, 0)
        Me.split.Name = "split"
        '
        'split.Panel1
        '
        Me.split.Panel1.Controls.Add(Me.pnlH)
        Me.split.Panel1.Controls.Add(Me.picHead)
        Me.split.Panel1.Controls.Add(Me.pnlV)
        Me.split.Panel1.Controls.Add(Me.pnlMain)
        '
        'split.Panel2
        '
        Me.split.Panel2.Controls.Add(Me.btnEditorInverse)
        Me.split.Panel2.Controls.Add(Me.lblCodeArraySize)
        Me.split.Panel2.Controls.Add(Me.lblCodeLength)
        Me.split.Panel2.Controls.Add(Me.lblCodepage)
        Me.split.Panel2.Controls.Add(Me.btnEditorRRight)
        Me.split.Panel2.Controls.Add(Me.btnEditorRLeft)
        Me.split.Panel2.Controls.Add(Me.btnEditorRDown)
        Me.split.Panel2.Controls.Add(Me.btnEditorRUp)
        Me.split.Panel2.Controls.Add(Me.btnEditorRight)
        Me.split.Panel2.Controls.Add(Me.btnEditorLeft)
        Me.split.Panel2.Controls.Add(Me.btnEditorDown)
        Me.split.Panel2.Controls.Add(Me.btnEditorUp)
        Me.split.Panel2.Controls.Add(Me.chkGap)
        Me.split.Panel2.Controls.Add(Me.lblBackColor)
        Me.split.Panel2.Controls.Add(Me.lblForeColor)
        Me.split.Panel2.Controls.Add(Me.chkRound)
        Me.split.Panel2.Controls.Add(Me.chkGrid)
        Me.split.Panel2.Controls.Add(Me.cboCopyType)
        Me.split.Panel2.Controls.Add(Me.tabControl)
        Me.split.Panel2.Controls.Add(Me.lblCursor)
        Me.split.Panel2.Controls.Add(Me.lblColRow)
        Me.split.Panel2.Controls.Add(Me.lblCharacterSize)
        Me.split.Panel2.Controls.Add(Me.lblCode)
        Me.split.Panel2.Controls.Add(Me.btnPasteImage)
        Me.split.Panel2.Controls.Add(Me.btnCopyCharImage)
        Me.split.Panel2.Controls.Add(Me.picEdit)
        Me.split.Size = New System.Drawing.Size(827, 599)
        Me.split.SplitterDistance = 492
        Me.split.TabIndex = 0
        '
        'pnlH
        '
        Me.pnlH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlH.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlH.Controls.Add(Me.picH)
        Me.pnlH.Location = New System.Drawing.Point(13, 0)
        Me.pnlH.Name = "pnlH"
        Me.pnlH.Size = New System.Drawing.Size(477, 13)
        Me.pnlH.TabIndex = 5
        '
        'picH
        '
        Me.picH.Location = New System.Drawing.Point(0, 0)
        Me.picH.Name = "picH"
        Me.picH.Size = New System.Drawing.Size(55, 13)
        Me.picH.TabIndex = 0
        Me.picH.TabStop = False
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
        'pnlV
        '
        Me.pnlV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlV.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlV.Controls.Add(Me.picV)
        Me.pnlV.Location = New System.Drawing.Point(0, 13)
        Me.pnlV.Name = "pnlV"
        Me.pnlV.Size = New System.Drawing.Size(13, 583)
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
        Me.pnlMain.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnlMain.Controls.Add(Me.picMain)
        Me.pnlMain.Location = New System.Drawing.Point(13, 13)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(477, 583)
        Me.pnlMain.TabIndex = 3
        '
        'picMain
        '
        Me.picMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.picMain.Location = New System.Drawing.Point(0, 0)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(128, 128)
        Me.picMain.TabIndex = 0
        Me.picMain.TabStop = False
        '
        'btnEditorInverse
        '
        Me.btnEditorInverse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorInverse.Location = New System.Drawing.Point(277, 267)
        Me.btnEditorInverse.Name = "btnEditorInverse"
        Me.btnEditorInverse.Size = New System.Drawing.Size(47, 23)
        Me.btnEditorInverse.TabIndex = 56
        Me.btnEditorInverse.Text = "Inverse"
        Me.btnEditorInverse.UseVisualStyleBackColor = True
        '
        'lblCodeArraySize
        '
        Me.lblCodeArraySize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodeArraySize.Location = New System.Drawing.Point(7, 275)
        Me.lblCodeArraySize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodeArraySize.Name = "lblCodeArraySize"
        Me.lblCodeArraySize.Size = New System.Drawing.Size(167, 12)
        Me.lblCodeArraySize.TabIndex = 55
        Me.lblCodeArraySize.Text = "Code array size: "
        '
        'lblCodeLength
        '
        Me.lblCodeLength.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodeLength.Location = New System.Drawing.Point(6, 260)
        Me.lblCodeLength.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodeLength.Name = "lblCodeLength"
        Me.lblCodeLength.Size = New System.Drawing.Size(167, 12)
        Me.lblCodeLength.TabIndex = 54
        Me.lblCodeLength.Text = "Code length: "
        '
        'lblCodepage
        '
        Me.lblCodepage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodepage.Location = New System.Drawing.Point(7, 245)
        Me.lblCodepage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodepage.Name = "lblCodepage"
        Me.lblCodepage.Size = New System.Drawing.Size(167, 12)
        Me.lblCodepage.TabIndex = 53
        Me.lblCodepage.Text = "Codepage: "
        '
        'btnEditorRRight
        '
        Me.btnEditorRRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorRRight.Location = New System.Drawing.Point(297, 305)
        Me.btnEditorRRight.Name = "btnEditorRRight"
        Me.btnEditorRRight.Size = New System.Drawing.Size(27, 23)
        Me.btnEditorRRight.TabIndex = 52
        Me.btnEditorRRight.Text = "RR"
        Me.btnEditorRRight.UseVisualStyleBackColor = True
        '
        'btnEditorRLeft
        '
        Me.btnEditorRLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorRLeft.Location = New System.Drawing.Point(244, 305)
        Me.btnEditorRLeft.Name = "btnEditorRLeft"
        Me.btnEditorRLeft.Size = New System.Drawing.Size(27, 23)
        Me.btnEditorRLeft.TabIndex = 51
        Me.btnEditorRLeft.Text = "RL"
        Me.btnEditorRLeft.UseVisualStyleBackColor = True
        '
        'btnEditorRDown
        '
        Me.btnEditorRDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorRDown.Location = New System.Drawing.Point(270, 320)
        Me.btnEditorRDown.Name = "btnEditorRDown"
        Me.btnEditorRDown.Size = New System.Drawing.Size(27, 23)
        Me.btnEditorRDown.TabIndex = 50
        Me.btnEditorRDown.Text = "RD"
        Me.btnEditorRDown.UseVisualStyleBackColor = True
        '
        'btnEditorRUp
        '
        Me.btnEditorRUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorRUp.Location = New System.Drawing.Point(270, 296)
        Me.btnEditorRUp.Name = "btnEditorRUp"
        Me.btnEditorRUp.Size = New System.Drawing.Size(27, 23)
        Me.btnEditorRUp.TabIndex = 49
        Me.btnEditorRUp.Text = "RU"
        Me.btnEditorRUp.UseVisualStyleBackColor = True
        '
        'btnEditorRight
        '
        Me.btnEditorRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorRight.Location = New System.Drawing.Point(217, 305)
        Me.btnEditorRight.Name = "btnEditorRight"
        Me.btnEditorRight.Size = New System.Drawing.Size(21, 23)
        Me.btnEditorRight.TabIndex = 48
        Me.btnEditorRight.Text = "R"
        Me.btnEditorRight.UseVisualStyleBackColor = True
        '
        'btnEditorLeft
        '
        Me.btnEditorLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorLeft.Location = New System.Drawing.Point(177, 305)
        Me.btnEditorLeft.Name = "btnEditorLeft"
        Me.btnEditorLeft.Size = New System.Drawing.Size(21, 23)
        Me.btnEditorLeft.TabIndex = 47
        Me.btnEditorLeft.Text = "L"
        Me.btnEditorLeft.UseVisualStyleBackColor = True
        '
        'btnEditorDown
        '
        Me.btnEditorDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorDown.Location = New System.Drawing.Point(197, 320)
        Me.btnEditorDown.Name = "btnEditorDown"
        Me.btnEditorDown.Size = New System.Drawing.Size(21, 23)
        Me.btnEditorDown.TabIndex = 46
        Me.btnEditorDown.Text = "D"
        Me.btnEditorDown.UseVisualStyleBackColor = True
        '
        'btnEditorUp
        '
        Me.btnEditorUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorUp.Location = New System.Drawing.Point(197, 295)
        Me.btnEditorUp.Name = "btnEditorUp"
        Me.btnEditorUp.Size = New System.Drawing.Size(21, 23)
        Me.btnEditorUp.TabIndex = 45
        Me.btnEditorUp.Text = "U"
        Me.btnEditorUp.UseVisualStyleBackColor = True
        '
        'chkGap
        '
        Me.chkGap.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkGap.AutoSize = True
        Me.chkGap.Location = New System.Drawing.Point(117, 581)
        Me.chkGap.Name = "chkGap"
        Me.chkGap.Size = New System.Drawing.Size(42, 16)
        Me.chkGap.TabIndex = 44
        Me.chkGap.Text = "gap"
        Me.chkGap.UseVisualStyleBackColor = True
        '
        'lblBackColor
        '
        Me.lblBackColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBackColor.AutoSize = True
        Me.lblBackColor.BackColor = System.Drawing.Color.White
        Me.lblBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBackColor.ForeColor = System.Drawing.Color.Black
        Me.lblBackColor.Location = New System.Drawing.Point(315, 582)
        Me.lblBackColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBackColor.Name = "lblBackColor"
        Me.lblBackColor.Size = New System.Drawing.Size(13, 14)
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
        Me.lblForeColor.Location = New System.Drawing.Point(298, 582)
        Me.lblForeColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblForeColor.Name = "lblForeColor"
        Me.lblForeColor.Size = New System.Drawing.Size(13, 14)
        Me.lblForeColor.TabIndex = 42
        Me.lblForeColor.Text = "F"
        '
        'chkRound
        '
        Me.chkRound.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkRound.AutoSize = True
        Me.chkRound.Location = New System.Drawing.Point(57, 581)
        Me.chkRound.Name = "chkRound"
        Me.chkRound.Size = New System.Drawing.Size(54, 16)
        Me.chkRound.TabIndex = 41
        Me.chkRound.Text = "round"
        Me.chkRound.UseVisualStyleBackColor = True
        '
        'chkGrid
        '
        Me.chkGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkGrid.AutoSize = True
        Me.chkGrid.Location = New System.Drawing.Point(3, 581)
        Me.chkGrid.Name = "chkGrid"
        Me.chkGrid.Size = New System.Drawing.Size(48, 16)
        Me.chkGrid.TabIndex = 41
        Me.chkGrid.Text = "grid"
        Me.chkGrid.UseVisualStyleBackColor = True
        '
        'cboCopyType
        '
        Me.cboCopyType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCopyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCopyType.Items.AddRange(New Object() {"editor image", "image", "SVG", "BIN", "HEX", "OCT", "DEC"})
        Me.cboCopyType.Location = New System.Drawing.Point(177, 242)
        Me.cboCopyType.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cboCopyType.Name = "cboCopyType"
        Me.cboCopyType.Size = New System.Drawing.Size(147, 20)
        Me.cboCopyType.TabIndex = 13
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
        Me.tabControl.Location = New System.Drawing.Point(2, 0)
        Me.tabControl.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(326, 239)
        Me.tabControl.TabIndex = 30
        '
        'tagCreate
        '
        Me.tagCreate.BackColor = System.Drawing.SystemColors.Control
        Me.tagCreate.Controls.Add(Me.txtFontName)
        Me.tagCreate.Controls.Add(Me.lblCharsizeHeight)
        Me.tagCreate.Controls.Add(Me.Label24)
        Me.tagCreate.Controls.Add(Me.Label22)
        Me.tagCreate.Controls.Add(Me.Label4)
        Me.tagCreate.Controls.Add(Me.Label20)
        Me.tagCreate.Controls.Add(Me.Label6)
        Me.tagCreate.Controls.Add(Me.Label5)
        Me.tagCreate.Controls.Add(Me.Label21)
        Me.tagCreate.Controls.Add(Me.Label3)
        Me.tagCreate.Controls.Add(Me.Label8)
        Me.tagCreate.Controls.Add(Me.lblCharsize)
        Me.tagCreate.Controls.Add(Me.lblCharsizeWidth)
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
        Me.tagCreate.Location = New System.Drawing.Point(4, 22)
        Me.tagCreate.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tagCreate.Name = "tagCreate"
        Me.tagCreate.Size = New System.Drawing.Size(318, 213)
        Me.tagCreate.TabIndex = 4
        Me.tagCreate.Text = "Create"
        '
        'txtFontName
        '
        Me.txtFontName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFontName.FormattingEnabled = True
        Me.txtFontName.Location = New System.Drawing.Point(68, 104)
        Me.txtFontName.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtFontName.Name = "txtFontName"
        Me.txtFontName.Size = New System.Drawing.Size(245, 20)
        Me.txtFontName.TabIndex = 6
        '
        'lblCharsizeHeight
        '
        Me.lblCharsizeHeight.AutoSize = True
        Me.lblCharsizeHeight.Location = New System.Drawing.Point(148, 8)
        Me.lblCharsizeHeight.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCharsizeHeight.Name = "lblCharsizeHeight"
        Me.lblCharsizeHeight.Size = New System.Drawing.Size(47, 12)
        Me.lblCharsizeHeight.TabIndex = 39
        Me.lblCharsizeHeight.Text = "Height:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(188, 148)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(35, 12)
        Me.Label24.TabIndex = 39
        Me.Label24.Text = "Size:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(127, 148)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(17, 12)
        Me.Label22.TabIndex = 39
        Me.Label22.Text = "Y:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(148, 57)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Row:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(4, 148)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 12)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Offset:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 105)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 12)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Font:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 30)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 12)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Codepage:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(66, 148)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(17, 12)
        Me.Label21.TabIndex = 39
        Me.Label21.Text = "X:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Col:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 57)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 12)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Code Size"
        '
        'lblCharsize
        '
        Me.lblCharsize.AutoSize = True
        Me.lblCharsize.Location = New System.Drawing.Point(4, 7)
        Me.lblCharsize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCharsize.Name = "lblCharsize"
        Me.lblCharsize.Size = New System.Drawing.Size(59, 12)
        Me.lblCharsize.TabIndex = 39
        Me.lblCharsize.Text = "Char Size"
        '
        'lblCharsizeWidth
        '
        Me.lblCharsizeWidth.AutoSize = True
        Me.lblCharsizeWidth.Location = New System.Drawing.Point(64, 8)
        Me.lblCharsizeWidth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCharsizeWidth.Name = "lblCharsizeWidth"
        Me.lblCharsizeWidth.Size = New System.Drawing.Size(41, 12)
        Me.lblCharsizeWidth.TabIndex = 39
        Me.lblCharsizeWidth.Text = "Width:"
        '
        'chkBlack
        '
        Me.chkBlack.AutoSize = True
        Me.chkBlack.Location = New System.Drawing.Point(126, 128)
        Me.chkBlack.Name = "chkBlack"
        Me.chkBlack.Size = New System.Drawing.Size(54, 16)
        Me.chkBlack.TabIndex = 8
        Me.chkBlack.Text = "Black"
        Me.chkBlack.UseVisualStyleBackColor = True
        '
        'chkMax
        '
        Me.chkMax.AutoSize = True
        Me.chkMax.Location = New System.Drawing.Point(66, 128)
        Me.chkMax.Name = "chkMax"
        Me.chkMax.Size = New System.Drawing.Size(42, 16)
        Me.chkMax.TabIndex = 7
        Me.chkMax.Text = "Max"
        Me.chkMax.UseVisualStyleBackColor = True
        '
        'cboCodepage
        '
        Me.cboCodepage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCodepage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCodepage.FormattingEnabled = True
        Me.cboCodepage.Items.AddRange(New Object() {"Unknown(0)", "ASCII-7(1252)", "ASCII-8(1252)", "UnicodeUCS16(1200)", "ISO/IEC10646BMP(1200)", "ISO/IEC10646SMP(65005)", "ISO/IEC10646SIP(65005)", "ISO/IEC10646TIP(65005)", "ISO/IEC10646-Fxxxx(65005)", "GB2312双字节(936)", "GBK双字节(936)", "GB18030单字节(936)", "GB18030双字节(936)", "Big-5双字节(950)", "Big-5单字节(950)", "Shift-JIS双字节(932)", "Shift-JIS单字节(932)"})
        Me.cboCodepage.Location = New System.Drawing.Point(66, 30)
        Me.cboCodepage.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cboCodepage.Name = "cboCodepage"
        Me.cboCodepage.Size = New System.Drawing.Size(247, 20)
        Me.cboCodepage.TabIndex = 2
        '
        'btnInitCharactors
        '
        Me.btnInitCharactors.Location = New System.Drawing.Point(66, 169)
        Me.btnInitCharactors.Name = "btnInitCharactors"
        Me.btnInitCharactors.Size = New System.Drawing.Size(68, 23)
        Me.btnInitCharactors.TabIndex = 12
        Me.btnInitCharactors.Text = "Init"
        Me.btnInitCharactors.UseVisualStyleBackColor = True
        '
        'txtCharSize
        '
        Me.txtCharSize.Location = New System.Drawing.Point(223, 145)
        Me.txtCharSize.Name = "txtCharSize"
        Me.txtCharSize.Size = New System.Drawing.Size(50, 21)
        Me.txtCharSize.TabIndex = 11
        '
        'txtCharOffsetY
        '
        Me.txtCharOffsetY.Location = New System.Drawing.Point(148, 145)
        Me.txtCharOffsetY.Name = "txtCharOffsetY"
        Me.txtCharOffsetY.Size = New System.Drawing.Size(35, 21)
        Me.txtCharOffsetY.TabIndex = 10
        '
        'txtCharOffsetX
        '
        Me.txtCharOffsetX.Location = New System.Drawing.Point(88, 145)
        Me.txtCharOffsetX.Name = "txtCharOffsetX"
        Me.txtCharOffsetX.Size = New System.Drawing.Size(34, 21)
        Me.txtCharOffsetX.TabIndex = 9
        '
        'txtNewSizeH
        '
        Me.txtNewSizeH.Location = New System.Drawing.Point(200, 54)
        Me.txtNewSizeH.Name = "txtNewSizeH"
        Me.txtNewSizeH.Size = New System.Drawing.Size(35, 21)
        Me.txtNewSizeH.TabIndex = 4
        Me.txtNewSizeH.Text = "256"
        '
        'txtNewSizeW
        '
        Me.txtNewSizeW.Location = New System.Drawing.Point(110, 54)
        Me.txtNewSizeW.Name = "txtNewSizeW"
        Me.txtNewSizeW.Size = New System.Drawing.Size(34, 21)
        Me.txtNewSizeW.TabIndex = 3
        Me.txtNewSizeW.Text = "256"
        '
        'txtNewHeight
        '
        Me.txtNewHeight.Location = New System.Drawing.Point(200, 5)
        Me.txtNewHeight.Name = "txtNewHeight"
        Me.txtNewHeight.Size = New System.Drawing.Size(34, 21)
        Me.txtNewHeight.TabIndex = 1
        Me.txtNewHeight.Text = "48"
        '
        'txtNewWidth
        '
        Me.txtNewWidth.Location = New System.Drawing.Point(110, 5)
        Me.txtNewWidth.Name = "txtNewWidth"
        Me.txtNewWidth.Size = New System.Drawing.Size(34, 21)
        Me.txtNewWidth.TabIndex = 0
        Me.txtNewWidth.Text = "48"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(68, 77)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(68, 23)
        Me.btnCreate.TabIndex = 5
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'tagOpen
        '
        Me.tagOpen.BackColor = System.Drawing.SystemColors.Control
        Me.tagOpen.Controls.Add(Me.btnOpenSave)
        Me.tagOpen.Controls.Add(Me.txtInsertEnd)
        Me.tagOpen.Controls.Add(Me.lblImport)
        Me.tagOpen.Controls.Add(Me.chkBigEndding)
        Me.tagOpen.Controls.Add(Me.Label1)
        Me.tagOpen.Controls.Add(Me.cboImportCodepage)
        Me.tagOpen.Controls.Add(Me.btnOpenFile)
        Me.tagOpen.Controls.Add(Me.btnInsert)
        Me.tagOpen.Controls.Add(Me.txtInsertStart)
        Me.tagOpen.Controls.Add(Me.Label32)
        Me.tagOpen.Controls.Add(Me.Label31)
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
        Me.tagOpen.Location = New System.Drawing.Point(4, 22)
        Me.tagOpen.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tagOpen.Name = "tagOpen"
        Me.tagOpen.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tagOpen.Size = New System.Drawing.Size(318, 213)
        Me.tagOpen.TabIndex = 0
        Me.tagOpen.Text = "Open"
        '
        'txtInsertEnd
        '
        Me.txtInsertEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInsertEnd.Location = New System.Drawing.Point(257, 156)
        Me.txtInsertEnd.Name = "txtInsertEnd"
        Me.txtInsertEnd.Size = New System.Drawing.Size(56, 21)
        Me.txtInsertEnd.TabIndex = 55
        Me.txtInsertEnd.Text = "0"
        '
        'lblImport
        '
        Me.lblImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblImport.AutoSize = True
        Me.lblImport.Location = New System.Drawing.Point(223, 159)
        Me.lblImport.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblImport.Name = "lblImport"
        Me.lblImport.Size = New System.Drawing.Size(29, 12)
        Me.lblImport.TabIndex = 54
        Me.lblImport.Text = "End:"
        '
        'chkBigEndding
        '
        Me.chkBigEndding.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkBigEndding.AutoSize = True
        Me.chkBigEndding.Location = New System.Drawing.Point(205, 131)
        Me.chkBigEndding.Name = "chkBigEndding"
        Me.chkBigEndding.Size = New System.Drawing.Size(108, 16)
        Me.chkBigEndding.TabIndex = 53
        Me.chkBigEndding.Text = "Little endding"
        Me.chkBigEndding.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Codepage:"
        '
        'cboImportCodepage
        '
        Me.cboImportCodepage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboImportCodepage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImportCodepage.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboImportCodepage.FormattingEnabled = True
        Me.cboImportCodepage.Items.AddRange(New Object() {"Unknown(0)", "ASCII-7(1252)", "ASCII-8(1252)", "UnicodeUCS16(1200)", "ISO/IEC10646BMP(1200)", "ISO/IEC10646SMP(65005)", "ISO/IEC10646SIP(65005)", "ISO/IEC10646TIP(65005)", "ISO/IEC10646-Fxxxx(65005)", "GB2312双字节(936)", "GBK双字节(936)", "GB18030单字节(936)", "GB18030双字节(936)", "Big-5双字节(950)", "Big-5单字节(950)", "Shift-JIS双字节(932)", "Shift-JIS单字节(932)"})
        Me.cboImportCodepage.Location = New System.Drawing.Point(69, 78)
        Me.cboImportCodepage.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cboImportCodepage.Name = "cboImportCodepage"
        Me.cboImportCodepage.Size = New System.Drawing.Size(244, 20)
        Me.cboImportCodepage.TabIndex = 51
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenFile.Location = New System.Drawing.Point(266, 2)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(47, 23)
        Me.btnOpenFile.TabIndex = 50
        Me.btnOpenFile.Text = "open"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInsert.Location = New System.Drawing.Point(137, 183)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(86, 23)
        Me.btnInsert.TabIndex = 47
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtInsertStart
        '
        Me.txtInsertStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInsertStart.Location = New System.Drawing.Point(162, 156)
        Me.txtInsertStart.Name = "txtInsertStart"
        Me.txtInsertStart.Size = New System.Drawing.Size(56, 21)
        Me.txtInsertStart.TabIndex = 49
        Me.txtInsertStart.Text = "0"
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(116, 159)
        Me.Label32.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(41, 12)
        Me.Label32.TabIndex = 48
        Me.Label32.Text = "Start:"
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(6, 159)
        Me.Label31.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(83, 17)
        Me.Label31.TabIndex = 47
        Me.Label31.Text = "Code Locate"
        '
        'chkInverse
        '
        Me.chkInverse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkInverse.AutoSize = True
        Me.chkInverse.Location = New System.Drawing.Point(133, 131)
        Me.chkInverse.Name = "chkInverse"
        Me.chkInverse.Size = New System.Drawing.Size(66, 16)
        Me.chkInverse.TabIndex = 23
        Me.chkInverse.Text = "Inverse"
        Me.chkInverse.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(230, 56)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 12)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Height:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(242, 105)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 12)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "High:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 32)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 12)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "Type:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 7)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(35, 12)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "File:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 132)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 12)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Offset:"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(160, 105)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 12)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Low:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 105)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 12)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Code Size"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 56)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 12)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Char Size"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(148, 56)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 12)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Width:"
        '
        'cboImportType
        '
        Me.cboImportType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboImportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImportType.FormattingEnabled = True
        Me.cboImportType.Items.AddRange(New Object() {"RAW", ".FONT.PNG", ".HZCG6"})
        Me.cboImportType.Location = New System.Drawing.Point(46, 29)
        Me.cboImportType.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cboImportType.Name = "cboImportType"
        Me.cboImportType.Size = New System.Drawing.Size(267, 20)
        Me.cboImportType.TabIndex = 17
        '
        'txtImportOffset
        '
        Me.txtImportOffset.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImportOffset.Location = New System.Drawing.Point(71, 129)
        Me.txtImportOffset.Name = "txtImportOffset"
        Me.txtImportOffset.Size = New System.Drawing.Size(56, 21)
        Me.txtImportOffset.TabIndex = 22
        Me.txtImportOffset.Text = "0"
        '
        'txtImportSizeH
        '
        Me.txtImportSizeH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImportSizeH.Location = New System.Drawing.Point(282, 102)
        Me.txtImportSizeH.Name = "txtImportSizeH"
        Me.txtImportSizeH.Size = New System.Drawing.Size(31, 21)
        Me.txtImportSizeH.TabIndex = 21
        Me.txtImportSizeH.Text = "256"
        '
        'txtImportSizeW
        '
        Me.txtImportSizeW.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImportSizeW.Location = New System.Drawing.Point(194, 102)
        Me.txtImportSizeW.Name = "txtImportSizeW"
        Me.txtImportSizeW.Size = New System.Drawing.Size(31, 21)
        Me.txtImportSizeW.TabIndex = 20
        Me.txtImportSizeW.Text = "256"
        '
        'txtImportHeight
        '
        Me.txtImportHeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImportHeight.Location = New System.Drawing.Point(282, 53)
        Me.txtImportHeight.Name = "txtImportHeight"
        Me.txtImportHeight.Size = New System.Drawing.Size(31, 21)
        Me.txtImportHeight.TabIndex = 19
        Me.txtImportHeight.Text = "16"
        '
        'txtImportWidth
        '
        Me.txtImportWidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImportWidth.Location = New System.Drawing.Point(194, 53)
        Me.txtImportWidth.Name = "txtImportWidth"
        Me.txtImportWidth.Size = New System.Drawing.Size(31, 21)
        Me.txtImportWidth.TabIndex = 18
        Me.txtImportWidth.Text = "8"
        '
        'txtImportFileName
        '
        Me.txtImportFileName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImportFileName.Location = New System.Drawing.Point(46, 4)
        Me.txtImportFileName.Name = "txtImportFileName"
        Me.txtImportFileName.Size = New System.Drawing.Size(214, 21)
        Me.txtImportFileName.TabIndex = 16
        Me.txtImportFileName.Text = "C:\Users\张展新\Desktop\font\[AYUMI]N.FNT"
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImport.Location = New System.Drawing.Point(45, 183)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(86, 23)
        Me.btnImport.TabIndex = 24
        Me.btnImport.Text = "Open"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'tagSave
        '
        Me.tagSave.BackColor = System.Drawing.SystemColors.Control
        Me.tagSave.Controls.Add(Me.btnOpenSaveimagepath)
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
        Me.tagSave.Location = New System.Drawing.Point(4, 22)
        Me.tagSave.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tagSave.Name = "tagSave"
        Me.tagSave.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tagSave.Size = New System.Drawing.Size(318, 213)
        Me.tagSave.TabIndex = 1
        Me.tagSave.Text = "Save"
        '
        'btnOpenSaveimagepath
        '
        Me.btnOpenSaveimagepath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenSaveimagepath.Location = New System.Drawing.Point(266, 5)
        Me.btnOpenSaveimagepath.Name = "btnOpenSaveimagepath"
        Me.btnOpenSaveimagepath.Size = New System.Drawing.Size(47, 23)
        Me.btnOpenSaveimagepath.TabIndex = 47
        Me.btnOpenSaveimagepath.Text = "open"
        Me.btnOpenSaveimagepath.UseVisualStyleBackColor = True
        '
        'txtCodeRangeEnd
        '
        Me.txtCodeRangeEnd.Location = New System.Drawing.Point(152, 83)
        Me.txtCodeRangeEnd.Name = "txtCodeRangeEnd"
        Me.txtCodeRangeEnd.Size = New System.Drawing.Size(51, 21)
        Me.txtCodeRangeEnd.TabIndex = 29
        Me.txtCodeRangeEnd.Text = "FF"
        '
        'txtCodeRangeStart
        '
        Me.txtCodeRangeStart.Location = New System.Drawing.Point(74, 83)
        Me.txtCodeRangeStart.Name = "txtCodeRangeStart"
        Me.txtCodeRangeStart.Size = New System.Drawing.Size(51, 21)
        Me.txtCodeRangeStart.TabIndex = 28
        Me.txtCodeRangeStart.Text = "0"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(130, 86)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(17, 12)
        Me.Label30.TabIndex = 46
        Me.Label30.Text = "to"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(4, 86)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(65, 12)
        Me.Label29.TabIndex = 45
        Me.Label29.Text = "CodeRange:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(4, 62)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 12)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Type:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(4, 10)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(35, 12)
        Me.Label23.TabIndex = 43
        Me.Label23.Text = "Path:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(4, 37)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 12)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "File:"
        '
        'picSave
        '
        Me.picSave.Location = New System.Drawing.Point(3, 127)
        Me.picSave.Name = "picSave"
        Me.picSave.Size = New System.Drawing.Size(31, 23)
        Me.picSave.TabIndex = 34
        Me.picSave.TabStop = False
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenFolder.Location = New System.Drawing.Point(172, 139)
        Me.btnOpenFolder.Name = "btnOpenFolder"
        Me.btnOpenFolder.Size = New System.Drawing.Size(141, 23)
        Me.btnOpenFolder.TabIndex = 30
        Me.btnOpenFolder.Text = "Open folder"
        Me.btnOpenFolder.UseVisualStyleBackColor = True
        '
        'txtSaveImagePath
        '
        Me.txtSaveImagePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaveImagePath.Location = New System.Drawing.Point(44, 7)
        Me.txtSaveImagePath.Name = "txtSaveImagePath"
        Me.txtSaveImagePath.Size = New System.Drawing.Size(216, 21)
        Me.txtSaveImagePath.TabIndex = 25
        Me.txtSaveImagePath.Text = "256"
        '
        'cboSaveFileType
        '
        Me.cboSaveFileType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSaveFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSaveFileType.FormattingEnabled = True
        Me.cboSaveFileType.Items.AddRange(New Object() {".FONT.PNG", "RAW", ".CODE.PNG(多个)", ".SVG", ".CODE.SVG(多个)", ".XML", ".HZCG6", ".hz.ww-hh"})
        Me.cboSaveFileType.Location = New System.Drawing.Point(43, 59)
        Me.cboSaveFileType.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cboSaveFileType.Name = "cboSaveFileType"
        Me.cboSaveFileType.Size = New System.Drawing.Size(270, 20)
        Me.cboSaveFileType.TabIndex = 27
        '
        'txtSaveImage
        '
        Me.txtSaveImage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaveImage.Location = New System.Drawing.Point(44, 34)
        Me.txtSaveImage.Name = "txtSaveImage"
        Me.txtSaveImage.Size = New System.Drawing.Size(269, 21)
        Me.txtSaveImage.TabIndex = 26
        Me.txtSaveImage.Text = "256"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(172, 110)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(141, 23)
        Me.btnSave.TabIndex = 31
        Me.btnSave.Text = "Save (as)"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tagEdit
        '
        Me.tagEdit.BackColor = System.Drawing.SystemColors.Control
        Me.tagEdit.Controls.Add(Me.btnCopyCode)
        Me.tagEdit.Controls.Add(Me.btnImportClean)
        Me.tagEdit.Controls.Add(Me.btnCharacterAdjust)
        Me.tagEdit.Controls.Add(Me.btnMoveCode)
        Me.tagEdit.Controls.Add(Me.txtMoveTo)
        Me.tagEdit.Controls.Add(Me.Label34)
        Me.tagEdit.Controls.Add(Me.txtMoveEnd)
        Me.tagEdit.Controls.Add(Me.txtMoveStart)
        Me.tagEdit.Controls.Add(Me.Label33)
        Me.tagEdit.Controls.Add(Me.Label7)
        Me.tagEdit.Controls.Add(Me.Label2)
        Me.tagEdit.Controls.Add(Me.Label25)
        Me.tagEdit.Controls.Add(Me.Label28)
        Me.tagEdit.Controls.Add(Me.Label26)
        Me.tagEdit.Controls.Add(Me.Label27)
        Me.tagEdit.Controls.Add(Me.txtMoveY)
        Me.tagEdit.Controls.Add(Me.txtMoveX)
        Me.tagEdit.Controls.Add(Me.btnToBlackWhite)
        Me.tagEdit.Controls.Add(Me.btnInverseColor)
        Me.tagEdit.Controls.Add(Me.btnScale)
        Me.tagEdit.Controls.Add(Me.txtScale)
        Me.tagEdit.Location = New System.Drawing.Point(4, 22)
        Me.tagEdit.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tagEdit.Name = "tagEdit"
        Me.tagEdit.Size = New System.Drawing.Size(318, 213)
        Me.tagEdit.TabIndex = 2
        Me.tagEdit.Text = "Edit"
        '
        'btnCopyCode
        '
        Me.btnCopyCode.Location = New System.Drawing.Point(254, 117)
        Me.btnCopyCode.Name = "btnCopyCode"
        Me.btnCopyCode.Size = New System.Drawing.Size(50, 23)
        Me.btnCopyCode.TabIndex = 57
        Me.btnCopyCode.Text = "Copy"
        Me.btnCopyCode.UseVisualStyleBackColor = True
        '
        'btnImportClean
        '
        Me.btnImportClean.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportClean.Location = New System.Drawing.Point(278, 90)
        Me.btnImportClean.Name = "btnImportClean"
        Me.btnImportClean.Size = New System.Drawing.Size(37, 23)
        Me.btnImportClean.TabIndex = 56
        Me.btnImportClean.Text = "Clean"
        Me.btnImportClean.UseVisualStyleBackColor = True
        '
        'btnCharacterAdjust
        '
        Me.btnCharacterAdjust.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCharacterAdjust.Location = New System.Drawing.Point(254, 61)
        Me.btnCharacterAdjust.Name = "btnCharacterAdjust"
        Me.btnCharacterAdjust.Size = New System.Drawing.Size(59, 23)
        Me.btnCharacterAdjust.TabIndex = 51
        Me.btnCharacterAdjust.Text = "Adjust"
        Me.btnCharacterAdjust.UseVisualStyleBackColor = True
        '
        'btnMoveCode
        '
        Me.btnMoveCode.Location = New System.Drawing.Point(198, 117)
        Me.btnMoveCode.Name = "btnMoveCode"
        Me.btnMoveCode.Size = New System.Drawing.Size(50, 23)
        Me.btnMoveCode.TabIndex = 50
        Me.btnMoveCode.Text = "Move"
        Me.btnMoveCode.UseVisualStyleBackColor = True
        '
        'txtMoveTo
        '
        Me.txtMoveTo.Location = New System.Drawing.Point(143, 117)
        Me.txtMoveTo.Name = "txtMoveTo"
        Me.txtMoveTo.Size = New System.Drawing.Size(48, 21)
        Me.txtMoveTo.TabIndex = 49
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(55, 120)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(83, 12)
        Me.Label34.TabIndex = 48
        Me.Label34.Text = "to code start"
        '
        'txtMoveEnd
        '
        Me.txtMoveEnd.Location = New System.Drawing.Point(224, 90)
        Me.txtMoveEnd.Name = "txtMoveEnd"
        Me.txtMoveEnd.Size = New System.Drawing.Size(48, 21)
        Me.txtMoveEnd.TabIndex = 47
        '
        'txtMoveStart
        '
        Me.txtMoveStart.Location = New System.Drawing.Point(143, 90)
        Me.txtMoveStart.Name = "txtMoveStart"
        Me.txtMoveStart.Size = New System.Drawing.Size(48, 21)
        Me.txtMoveStart.TabIndex = 46
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(196, 93)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(23, 12)
        Me.Label33.TabIndex = 45
        Me.Label33.Text = "end"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 93)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 12)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "from code start"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Move:"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(191, 66)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(17, 12)
        Me.Label25.TabIndex = 42
        Me.Label25.Text = "Y:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(4, 8)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(41, 12)
        Me.Label28.TabIndex = 43
        Me.Label28.Text = "Scale:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(4, 66)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(107, 12)
        Me.Label26.TabIndex = 43
        Me.Label26.Text = "Character adjust:"
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(130, 66)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(17, 12)
        Me.Label27.TabIndex = 44
        Me.Label27.Text = "X:"
        '
        'txtMoveY
        '
        Me.txtMoveY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMoveY.Location = New System.Drawing.Point(213, 63)
        Me.txtMoveY.Name = "txtMoveY"
        Me.txtMoveY.Size = New System.Drawing.Size(35, 21)
        Me.txtMoveY.TabIndex = 37
        '
        'txtMoveX
        '
        Me.txtMoveX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMoveX.Location = New System.Drawing.Point(152, 63)
        Me.txtMoveX.Name = "txtMoveX"
        Me.txtMoveX.Size = New System.Drawing.Size(34, 21)
        Me.txtMoveX.TabIndex = 36
        '
        'btnToBlackWhite
        '
        Me.btnToBlackWhite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnToBlackWhite.Location = New System.Drawing.Point(186, 32)
        Me.btnToBlackWhite.Name = "btnToBlackWhite"
        Me.btnToBlackWhite.Size = New System.Drawing.Size(127, 23)
        Me.btnToBlackWhite.TabIndex = 35
        Me.btnToBlackWhite.Text = "To Black/White"
        Me.btnToBlackWhite.UseVisualStyleBackColor = True
        '
        'btnInverseColor
        '
        Me.btnInverseColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInverseColor.Location = New System.Drawing.Point(53, 32)
        Me.btnInverseColor.Name = "btnInverseColor"
        Me.btnInverseColor.Size = New System.Drawing.Size(127, 23)
        Me.btnInverseColor.TabIndex = 34
        Me.btnInverseColor.Text = "Inverse Color"
        Me.btnInverseColor.UseVisualStyleBackColor = True
        '
        'btnScale
        '
        Me.btnScale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnScale.Location = New System.Drawing.Point(186, 3)
        Me.btnScale.Name = "btnScale"
        Me.btnScale.Size = New System.Drawing.Size(127, 23)
        Me.btnScale.TabIndex = 33
        Me.btnScale.Text = "Scale up/down"
        Me.btnScale.UseVisualStyleBackColor = True
        '
        'txtScale
        '
        Me.txtScale.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtScale.Location = New System.Drawing.Point(62, 5)
        Me.txtScale.Name = "txtScale"
        Me.txtScale.Size = New System.Drawing.Size(118, 21)
        Me.txtScale.TabIndex = 32
        Me.txtScale.Text = "100%"
        '
        'tagSpecial
        '
        Me.tagSpecial.BackColor = System.Drawing.SystemColors.Control
        Me.tagSpecial.Controls.Add(Me.btnPic2HZ)
        Me.tagSpecial.Controls.Add(Me.btnOutput1)
        Me.tagSpecial.Controls.Add(Me.btnSpecial)
        Me.tagSpecial.Location = New System.Drawing.Point(4, 22)
        Me.tagSpecial.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tagSpecial.Name = "tagSpecial"
        Me.tagSpecial.Size = New System.Drawing.Size(318, 213)
        Me.tagSpecial.TabIndex = 3
        Me.tagSpecial.Text = "Special"
        '
        'btnPic2HZ
        '
        Me.btnPic2HZ.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPic2HZ.Location = New System.Drawing.Point(7, 63)
        Me.btnPic2HZ.Name = "btnPic2HZ"
        Me.btnPic2HZ.Size = New System.Drawing.Size(306, 23)
        Me.btnPic2HZ.TabIndex = 41
        Me.btnPic2HZ.Text = "pic to HZ"
        Me.btnPic2HZ.UseVisualStyleBackColor = True
        '
        'btnOutput1
        '
        Me.btnOutput1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOutput1.Location = New System.Drawing.Point(6, 33)
        Me.btnOutput1.Name = "btnOutput1"
        Me.btnOutput1.Size = New System.Drawing.Size(307, 23)
        Me.btnOutput1.TabIndex = 40
        Me.btnOutput1.Text = "Output by GB Zones"
        Me.btnOutput1.UseVisualStyleBackColor = True
        '
        'btnSpecial
        '
        Me.btnSpecial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSpecial.Location = New System.Drawing.Point(6, 3)
        Me.btnSpecial.Name = "btnSpecial"
        Me.btnSpecial.Size = New System.Drawing.Size(307, 23)
        Me.btnSpecial.TabIndex = 39
        Me.btnSpecial.Text = "Compare"
        Me.btnSpecial.UseVisualStyleBackColor = True
        '
        'lblCursor
        '
        Me.lblCursor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCursor.Location = New System.Drawing.Point(8, 340)
        Me.lblCursor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCursor.Name = "lblCursor"
        Me.lblCursor.Size = New System.Drawing.Size(166, 12)
        Me.lblCursor.TabIndex = 21
        Me.lblCursor.Text = "Dot:"
        '
        'lblColRow
        '
        Me.lblColRow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblColRow.Location = New System.Drawing.Point(7, 325)
        Me.lblColRow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblColRow.Name = "lblColRow"
        Me.lblColRow.Size = New System.Drawing.Size(167, 12)
        Me.lblColRow.TabIndex = 21
        Me.lblColRow.Text = "Location:"
        '
        'lblCharacterSize
        '
        Me.lblCharacterSize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCharacterSize.Location = New System.Drawing.Point(7, 290)
        Me.lblCharacterSize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCharacterSize.Name = "lblCharacterSize"
        Me.lblCharacterSize.Size = New System.Drawing.Size(167, 12)
        Me.lblCharacterSize.TabIndex = 21
        Me.lblCharacterSize.Text = "Character size:"
        '
        'lblCode
        '
        Me.lblCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCode.Location = New System.Drawing.Point(7, 310)
        Me.lblCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(167, 12)
        Me.lblCode.TabIndex = 21
        Me.lblCode.Text = "Code:"
        '
        'btnPasteImage
        '
        Me.btnPasteImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPasteImage.Location = New System.Drawing.Point(224, 266)
        Me.btnPasteImage.Name = "btnPasteImage"
        Me.btnPasteImage.Size = New System.Drawing.Size(47, 23)
        Me.btnPasteImage.TabIndex = 15
        Me.btnPasteImage.Text = "Paste"
        Me.btnPasteImage.UseVisualStyleBackColor = True
        '
        'btnCopyCharImage
        '
        Me.btnCopyCharImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopyCharImage.Location = New System.Drawing.Point(177, 266)
        Me.btnCopyCharImage.Name = "btnCopyCharImage"
        Me.btnCopyCharImage.Size = New System.Drawing.Size(41, 23)
        Me.btnCopyCharImage.TabIndex = 14
        Me.btnCopyCharImage.Text = "Copy"
        Me.btnCopyCharImage.UseVisualStyleBackColor = True
        '
        'picEdit
        '
        Me.picEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picEdit.BackColor = System.Drawing.SystemColors.Info
        Me.picEdit.Cursor = System.Windows.Forms.Cursors.Cross
        Me.picEdit.InitialImage = Nothing
        Me.picEdit.Location = New System.Drawing.Point(2, 355)
        Me.picEdit.Name = "picEdit"
        Me.picEdit.Size = New System.Drawing.Size(326, 220)
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'fileOpen
        '
        Me.fileOpen.FileName = "OpenFileDialog1"
        '
        'btnOpenSave
        '
        Me.btnOpenSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenSave.Location = New System.Drawing.Point(229, 183)
        Me.btnOpenSave.Name = "btnOpenSave"
        Me.btnOpenSave.Size = New System.Drawing.Size(86, 23)
        Me.btnOpenSave.TabIndex = 56
        Me.btnOpenSave.Text = "Save"
        Me.btnOpenSave.UseVisualStyleBackColor = True
        Me.btnOpenSave.Visible = False
        '
        'frmFont
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 599)
        Me.Controls.Add(Me.split)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFont"
        Me.Text = "BMP Font"
        Me.split.Panel1.ResumeLayout(False)
        Me.split.Panel2.ResumeLayout(False)
        Me.split.Panel2.PerformLayout()
        CType(Me.split, System.ComponentModel.ISupportInitialize).EndInit()
        Me.split.ResumeLayout(False)
        Me.pnlH.ResumeLayout(False)
        CType(Me.picH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlV.ResumeLayout(False)
        CType(Me.picV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents split As SplitContainer
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
    Friend WithEvents lblCharacterSize As Label
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
    Friend WithEvents lblCharsizeHeight As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblCharsize As Label
    Friend WithEvents lblCharsizeWidth As Label
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
    Friend WithEvents chkGap As CheckBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtInsertStart As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnOpenSaveimagepath As Button
    Friend WithEvents folderSave As FolderBrowserDialog
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents fileOpen As OpenFileDialog
    Friend WithEvents btnEditorRRight As Button
    Friend WithEvents btnEditorRLeft As Button
    Friend WithEvents btnEditorRDown As Button
    Friend WithEvents btnEditorRUp As Button
    Friend WithEvents btnEditorRight As Button
    Friend WithEvents btnEditorLeft As Button
    Friend WithEvents btnEditorDown As Button
    Friend WithEvents btnEditorUp As Button
    Friend WithEvents lblCodeArraySize As Label
    Friend WithEvents lblCodeLength As Label
    Friend WithEvents lblCodepage As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboImportCodepage As ComboBox
    Friend WithEvents txtInsertEnd As TextBox
    Friend WithEvents lblImport As Label
    Friend WithEvents chkBigEndding As CheckBox
    Friend WithEvents btnImportClean As Button
    Friend WithEvents btnMoveCode As Button
    Friend WithEvents txtMoveTo As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txtMoveEnd As TextBox
    Friend WithEvents txtMoveStart As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCharacterAdjust As Button
    Friend WithEvents btnCopyCode As Button
    Friend WithEvents btnEditorInverse As Button
    Friend WithEvents btnOpenSave As Button
End Class
