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
        Me.progressBar = New System.Windows.Forms.ProgressBar()
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
        Me.lblNewBaseline = New System.Windows.Forms.Label()
        Me.txtNewBaseline = New System.Windows.Forms.TextBox()
        Me.txtFontName = New System.Windows.Forms.ComboBox()
        Me.lblNewCharsizeHeight = New System.Windows.Forms.Label()
        Me.lblNewFontSize = New System.Windows.Forms.Label()
        Me.lblNewFontOffsetY = New System.Windows.Forms.Label()
        Me.lblNewCodesizeRow = New System.Windows.Forms.Label()
        Me.lblNewFontOffset = New System.Windows.Forms.Label()
        Me.lblNewFont = New System.Windows.Forms.Label()
        Me.lblNewCodepage = New System.Windows.Forms.Label()
        Me.lblNewFontOffsetX = New System.Windows.Forms.Label()
        Me.lblNewCodesizeCol = New System.Windows.Forms.Label()
        Me.lblNewCodesize = New System.Windows.Forms.Label()
        Me.lblNewCharsize = New System.Windows.Forms.Label()
        Me.lblNewCharsizeWidth = New System.Windows.Forms.Label()
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
        Me.btnOpenSave = New System.Windows.Forms.Button()
        Me.txtInsertEnd = New System.Windows.Forms.TextBox()
        Me.lblCodeLocateEnd = New System.Windows.Forms.Label()
        Me.chkBigEndding = New System.Windows.Forms.CheckBox()
        Me.lblOpenCodepage = New System.Windows.Forms.Label()
        Me.cboImportCodepage = New System.Windows.Forms.ComboBox()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtInsertStart = New System.Windows.Forms.TextBox()
        Me.lblCodeLocateStart = New System.Windows.Forms.Label()
        Me.lblOpenCodelocate = New System.Windows.Forms.Label()
        Me.chkInverse = New System.Windows.Forms.CheckBox()
        Me.lblOpenCharsizeHeight = New System.Windows.Forms.Label()
        Me.lblOpenCodesizeHigh = New System.Windows.Forms.Label()
        Me.lblOpenType = New System.Windows.Forms.Label()
        Me.lblOpenFile = New System.Windows.Forms.Label()
        Me.lblOpenOffset = New System.Windows.Forms.Label()
        Me.lblOpenCodesizeLow = New System.Windows.Forms.Label()
        Me.lblOpenCodesize = New System.Windows.Forms.Label()
        Me.lblOpenCharsize = New System.Windows.Forms.Label()
        Me.lblOpenCharsizeWidth = New System.Windows.Forms.Label()
        Me.cboImportType = New System.Windows.Forms.ComboBox()
        Me.txtImportOffset = New System.Windows.Forms.TextBox()
        Me.txtImportSizeH = New System.Windows.Forms.TextBox()
        Me.txtImportSizeW = New System.Windows.Forms.TextBox()
        Me.txtImportHeight = New System.Windows.Forms.TextBox()
        Me.txtImportWidth = New System.Windows.Forms.TextBox()
        Me.txtImportFileName = New System.Windows.Forms.TextBox()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.tagSave = New System.Windows.Forms.TabPage()
        Me.lblSaveCoderangeFrom = New System.Windows.Forms.Label()
        Me.btnOpenSaveimagepath = New System.Windows.Forms.Button()
        Me.txtCodeRangeEnd = New System.Windows.Forms.TextBox()
        Me.txtCodeRangeStart = New System.Windows.Forms.TextBox()
        Me.lblSaveCoderangeTo = New System.Windows.Forms.Label()
        Me.lblSaveCoderange = New System.Windows.Forms.Label()
        Me.lblSaveType = New System.Windows.Forms.Label()
        Me.lblSavePath = New System.Windows.Forms.Label()
        Me.lblSaveFile = New System.Windows.Forms.Label()
        Me.btnOpenFolder = New System.Windows.Forms.Button()
        Me.txtSaveImagePath = New System.Windows.Forms.TextBox()
        Me.cboSaveFileType = New System.Windows.Forms.ComboBox()
        Me.txtSaveImage = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tagEdit = New System.Windows.Forms.TabPage()
        Me.btnExchange = New System.Windows.Forms.Button()
        Me.lblThresholdBW = New System.Windows.Forms.Label()
        Me.hsbThresholdBW = New System.Windows.Forms.HScrollBar()
        Me.btnDrawLines = New System.Windows.Forms.Button()
        Me.btnCopyCode = New System.Windows.Forms.Button()
        Me.btnEditClean = New System.Windows.Forms.Button()
        Me.btnCharacterAdjust = New System.Windows.Forms.Button()
        Me.btnMoveCode = New System.Windows.Forms.Button()
        Me.txtMoveTo = New System.Windows.Forms.TextBox()
        Me.lblEditMoveTo = New System.Windows.Forms.Label()
        Me.txtMoveEnd = New System.Windows.Forms.TextBox()
        Me.txtMoveStart = New System.Windows.Forms.TextBox()
        Me.lblEditMoveEnd = New System.Windows.Forms.Label()
        Me.lblEditMoveFrom = New System.Windows.Forms.Label()
        Me.lblEditMove = New System.Windows.Forms.Label()
        Me.lblCharacteradjustY = New System.Windows.Forms.Label()
        Me.lblEditScale = New System.Windows.Forms.Label()
        Me.lblCharacteradjust = New System.Windows.Forms.Label()
        Me.lblCharacteradjustX = New System.Windows.Forms.Label()
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
        Me.split.Panel2.Controls.Add(Me.progressBar)
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
        Me.split.Size = New System.Drawing.Size(827, 467)
        Me.split.SplitterDistance = 491
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
        Me.picH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picH.TabIndex = 0
        Me.picH.TabStop = False
        '
        'picHead
        '
        Me.picHead.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock
        Me.picHead.Location = New System.Drawing.Point(0, 0)
        Me.picHead.Name = "picHead"
        Me.picHead.Size = New System.Drawing.Size(13, 13)
        Me.picHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
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
        Me.pnlV.Size = New System.Drawing.Size(13, 451)
        Me.pnlV.TabIndex = 4
        '
        'picV
        '
        Me.picV.Location = New System.Drawing.Point(0, 0)
        Me.picV.Name = "picV"
        Me.picV.Size = New System.Drawing.Size(13, 145)
        Me.picV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
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
        Me.pnlMain.Size = New System.Drawing.Size(477, 451)
        Me.pnlMain.TabIndex = 3
        '
        'picMain
        '
        Me.picMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.picMain.Location = New System.Drawing.Point(0, 0)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(128, 128)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMain.TabIndex = 0
        Me.picMain.TabStop = False
        '
        'progressBar
        '
        Me.progressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progressBar.Location = New System.Drawing.Point(5, 231)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(308, 10)
        Me.progressBar.Step = 1
        Me.progressBar.TabIndex = 57
        Me.progressBar.Visible = False
        '
        'btnEditorInverse
        '
        Me.btnEditorInverse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorInverse.Location = New System.Drawing.Point(267, 267)
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
        Me.lblCodeArraySize.AutoSize = True
        Me.lblCodeArraySize.Location = New System.Drawing.Point(7, 275)
        Me.lblCodeArraySize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodeArraySize.Name = "lblCodeArraySize"
        Me.lblCodeArraySize.Size = New System.Drawing.Size(107, 12)
        Me.lblCodeArraySize.TabIndex = 55
        Me.lblCodeArraySize.Text = "Code array size: "
        '
        'lblCodeLength
        '
        Me.lblCodeLength.AutoSize = True
        Me.lblCodeLength.BackColor = System.Drawing.SystemColors.Control
        Me.lblCodeLength.Location = New System.Drawing.Point(6, 260)
        Me.lblCodeLength.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodeLength.Name = "lblCodeLength"
        Me.lblCodeLength.Size = New System.Drawing.Size(83, 12)
        Me.lblCodeLength.TabIndex = 54
        Me.lblCodeLength.Text = "Code length: "
        '
        'lblCodepage
        '
        Me.lblCodepage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodepage.AutoSize = True
        Me.lblCodepage.Location = New System.Drawing.Point(7, 245)
        Me.lblCodepage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodepage.Name = "lblCodepage"
        Me.lblCodepage.Size = New System.Drawing.Size(65, 12)
        Me.lblCodepage.TabIndex = 53
        Me.lblCodepage.Text = "Codepage: "
        '
        'btnEditorRRight
        '
        Me.btnEditorRRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorRRight.AutoSize = True
        Me.btnEditorRRight.Location = New System.Drawing.Point(287, 305)
        Me.btnEditorRRight.Name = "btnEditorRRight"
        Me.btnEditorRRight.Size = New System.Drawing.Size(27, 23)
        Me.btnEditorRRight.TabIndex = 52
        Me.btnEditorRRight.Text = "RR"
        Me.btnEditorRRight.UseVisualStyleBackColor = True
        '
        'btnEditorRLeft
        '
        Me.btnEditorRLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorRLeft.AutoSize = True
        Me.btnEditorRLeft.Location = New System.Drawing.Point(234, 305)
        Me.btnEditorRLeft.Name = "btnEditorRLeft"
        Me.btnEditorRLeft.Size = New System.Drawing.Size(27, 23)
        Me.btnEditorRLeft.TabIndex = 51
        Me.btnEditorRLeft.Text = "RL"
        Me.btnEditorRLeft.UseVisualStyleBackColor = True
        '
        'btnEditorRDown
        '
        Me.btnEditorRDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorRDown.AutoSize = True
        Me.btnEditorRDown.Location = New System.Drawing.Point(260, 320)
        Me.btnEditorRDown.Name = "btnEditorRDown"
        Me.btnEditorRDown.Size = New System.Drawing.Size(27, 23)
        Me.btnEditorRDown.TabIndex = 50
        Me.btnEditorRDown.Text = "RD"
        Me.btnEditorRDown.UseVisualStyleBackColor = True
        '
        'btnEditorRUp
        '
        Me.btnEditorRUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorRUp.AutoSize = True
        Me.btnEditorRUp.Location = New System.Drawing.Point(260, 296)
        Me.btnEditorRUp.Name = "btnEditorRUp"
        Me.btnEditorRUp.Size = New System.Drawing.Size(27, 23)
        Me.btnEditorRUp.TabIndex = 49
        Me.btnEditorRUp.Text = "RU"
        Me.btnEditorRUp.UseVisualStyleBackColor = True
        '
        'btnEditorRight
        '
        Me.btnEditorRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorRight.AutoSize = True
        Me.btnEditorRight.Location = New System.Drawing.Point(207, 305)
        Me.btnEditorRight.Name = "btnEditorRight"
        Me.btnEditorRight.Size = New System.Drawing.Size(21, 23)
        Me.btnEditorRight.TabIndex = 48
        Me.btnEditorRight.Text = "R"
        Me.btnEditorRight.UseVisualStyleBackColor = True
        '
        'btnEditorLeft
        '
        Me.btnEditorLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorLeft.AutoSize = True
        Me.btnEditorLeft.Location = New System.Drawing.Point(167, 305)
        Me.btnEditorLeft.Name = "btnEditorLeft"
        Me.btnEditorLeft.Size = New System.Drawing.Size(21, 23)
        Me.btnEditorLeft.TabIndex = 47
        Me.btnEditorLeft.Text = "L"
        Me.btnEditorLeft.UseVisualStyleBackColor = True
        '
        'btnEditorDown
        '
        Me.btnEditorDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorDown.AutoSize = True
        Me.btnEditorDown.Location = New System.Drawing.Point(187, 320)
        Me.btnEditorDown.Name = "btnEditorDown"
        Me.btnEditorDown.Size = New System.Drawing.Size(21, 23)
        Me.btnEditorDown.TabIndex = 46
        Me.btnEditorDown.Text = "D"
        Me.btnEditorDown.UseVisualStyleBackColor = True
        '
        'btnEditorUp
        '
        Me.btnEditorUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditorUp.AutoSize = True
        Me.btnEditorUp.Location = New System.Drawing.Point(187, 295)
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
        Me.chkGap.Location = New System.Drawing.Point(117, 449)
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
        Me.lblBackColor.Location = New System.Drawing.Point(304, 450)
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
        Me.lblForeColor.Location = New System.Drawing.Point(288, 450)
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
        Me.chkRound.Location = New System.Drawing.Point(57, 449)
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
        Me.chkGrid.Location = New System.Drawing.Point(3, 449)
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
        Me.cboCopyType.Items.AddRange(New Object() {"image", "editor image", "SVG", "BIN", "HEX", "OCT", "DEC"})
        Me.cboCopyType.Location = New System.Drawing.Point(174, 242)
        Me.cboCopyType.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cboCopyType.Name = "cboCopyType"
        Me.cboCopyType.Size = New System.Drawing.Size(140, 20)
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
        Me.tabControl.Size = New System.Drawing.Size(316, 227)
        Me.tabControl.TabIndex = 30
        '
        'tagCreate
        '
        Me.tagCreate.BackColor = System.Drawing.SystemColors.Control
        Me.tagCreate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tagCreate.Controls.Add(Me.lblNewBaseline)
        Me.tagCreate.Controls.Add(Me.txtNewBaseline)
        Me.tagCreate.Controls.Add(Me.txtFontName)
        Me.tagCreate.Controls.Add(Me.lblNewCharsizeHeight)
        Me.tagCreate.Controls.Add(Me.lblNewFontSize)
        Me.tagCreate.Controls.Add(Me.lblNewFontOffsetY)
        Me.tagCreate.Controls.Add(Me.lblNewCodesizeRow)
        Me.tagCreate.Controls.Add(Me.lblNewFontOffset)
        Me.tagCreate.Controls.Add(Me.lblNewFont)
        Me.tagCreate.Controls.Add(Me.lblNewCodepage)
        Me.tagCreate.Controls.Add(Me.lblNewFontOffsetX)
        Me.tagCreate.Controls.Add(Me.lblNewCodesizeCol)
        Me.tagCreate.Controls.Add(Me.lblNewCodesize)
        Me.tagCreate.Controls.Add(Me.lblNewCharsize)
        Me.tagCreate.Controls.Add(Me.lblNewCharsizeWidth)
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
        Me.tagCreate.Size = New System.Drawing.Size(308, 201)
        Me.tagCreate.TabIndex = 4
        Me.tagCreate.Text = "Create"
        '
        'lblNewBaseline
        '
        Me.lblNewBaseline.AutoSize = True
        Me.lblNewBaseline.Location = New System.Drawing.Point(226, 7)
        Me.lblNewBaseline.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewBaseline.Name = "lblNewBaseline"
        Me.lblNewBaseline.Size = New System.Drawing.Size(59, 12)
        Me.lblNewBaseline.TabIndex = 41
        Me.lblNewBaseline.Text = "Baseline:"
        '
        'txtNewBaseline
        '
        Me.txtNewBaseline.Location = New System.Drawing.Point(278, 5)
        Me.txtNewBaseline.Name = "txtNewBaseline"
        Me.txtNewBaseline.Size = New System.Drawing.Size(34, 21)
        Me.txtNewBaseline.TabIndex = 40
        Me.txtNewBaseline.Text = "0"
        '
        'txtFontName
        '
        Me.txtFontName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFontName.FormattingEnabled = True
        Me.txtFontName.Location = New System.Drawing.Point(68, 104)
        Me.txtFontName.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtFontName.Name = "txtFontName"
        Me.txtFontName.Size = New System.Drawing.Size(244, 20)
        Me.txtFontName.TabIndex = 6
        '
        'lblNewCharsizeHeight
        '
        Me.lblNewCharsizeHeight.AutoSize = True
        Me.lblNewCharsizeHeight.Location = New System.Drawing.Point(148, 8)
        Me.lblNewCharsizeHeight.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewCharsizeHeight.Name = "lblNewCharsizeHeight"
        Me.lblNewCharsizeHeight.Size = New System.Drawing.Size(47, 12)
        Me.lblNewCharsizeHeight.TabIndex = 39
        Me.lblNewCharsizeHeight.Text = "Height:"
        '
        'lblNewFontSize
        '
        Me.lblNewFontSize.AutoSize = True
        Me.lblNewFontSize.Location = New System.Drawing.Point(188, 148)
        Me.lblNewFontSize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewFontSize.Name = "lblNewFontSize"
        Me.lblNewFontSize.Size = New System.Drawing.Size(35, 12)
        Me.lblNewFontSize.TabIndex = 39
        Me.lblNewFontSize.Text = "Size:"
        '
        'lblNewFontOffsetY
        '
        Me.lblNewFontOffsetY.AutoSize = True
        Me.lblNewFontOffsetY.Location = New System.Drawing.Point(127, 148)
        Me.lblNewFontOffsetY.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewFontOffsetY.Name = "lblNewFontOffsetY"
        Me.lblNewFontOffsetY.Size = New System.Drawing.Size(17, 12)
        Me.lblNewFontOffsetY.TabIndex = 39
        Me.lblNewFontOffsetY.Text = "Y:"
        '
        'lblNewCodesizeRow
        '
        Me.lblNewCodesizeRow.AutoSize = True
        Me.lblNewCodesizeRow.Location = New System.Drawing.Point(148, 57)
        Me.lblNewCodesizeRow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewCodesizeRow.Name = "lblNewCodesizeRow"
        Me.lblNewCodesizeRow.Size = New System.Drawing.Size(29, 12)
        Me.lblNewCodesizeRow.TabIndex = 39
        Me.lblNewCodesizeRow.Text = "Row:"
        '
        'lblNewFontOffset
        '
        Me.lblNewFontOffset.AutoSize = True
        Me.lblNewFontOffset.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblNewFontOffset.Location = New System.Drawing.Point(4, 148)
        Me.lblNewFontOffset.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewFontOffset.Name = "lblNewFontOffset"
        Me.lblNewFontOffset.Size = New System.Drawing.Size(54, 12)
        Me.lblNewFontOffset.TabIndex = 39
        Me.lblNewFontOffset.Text = "Offset:"
        '
        'lblNewFont
        '
        Me.lblNewFont.AutoSize = True
        Me.lblNewFont.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblNewFont.Location = New System.Drawing.Point(4, 105)
        Me.lblNewFont.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewFont.Name = "lblNewFont"
        Me.lblNewFont.Size = New System.Drawing.Size(40, 12)
        Me.lblNewFont.TabIndex = 39
        Me.lblNewFont.Text = "Font:"
        '
        'lblNewCodepage
        '
        Me.lblNewCodepage.AutoSize = True
        Me.lblNewCodepage.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblNewCodepage.Location = New System.Drawing.Point(4, 30)
        Me.lblNewCodepage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewCodepage.Name = "lblNewCodepage"
        Me.lblNewCodepage.Size = New System.Drawing.Size(68, 12)
        Me.lblNewCodepage.TabIndex = 39
        Me.lblNewCodepage.Text = "Codepage:"
        '
        'lblNewFontOffsetX
        '
        Me.lblNewFontOffsetX.AutoSize = True
        Me.lblNewFontOffsetX.Location = New System.Drawing.Point(66, 148)
        Me.lblNewFontOffsetX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewFontOffsetX.Name = "lblNewFontOffsetX"
        Me.lblNewFontOffsetX.Size = New System.Drawing.Size(17, 12)
        Me.lblNewFontOffsetX.TabIndex = 39
        Me.lblNewFontOffsetX.Text = "X:"
        '
        'lblNewCodesizeCol
        '
        Me.lblNewCodesizeCol.AutoSize = True
        Me.lblNewCodesizeCol.Location = New System.Drawing.Point(66, 57)
        Me.lblNewCodesizeCol.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewCodesizeCol.Name = "lblNewCodesizeCol"
        Me.lblNewCodesizeCol.Size = New System.Drawing.Size(29, 12)
        Me.lblNewCodesizeCol.TabIndex = 39
        Me.lblNewCodesizeCol.Text = "Col:"
        '
        'lblNewCodesize
        '
        Me.lblNewCodesize.AutoSize = True
        Me.lblNewCodesize.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblNewCodesize.Location = New System.Drawing.Point(4, 57)
        Me.lblNewCodesize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewCodesize.Name = "lblNewCodesize"
        Me.lblNewCodesize.Size = New System.Drawing.Size(68, 12)
        Me.lblNewCodesize.TabIndex = 39
        Me.lblNewCodesize.Text = "Code Size"
        '
        'lblNewCharsize
        '
        Me.lblNewCharsize.AutoSize = True
        Me.lblNewCharsize.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblNewCharsize.Location = New System.Drawing.Point(4, 7)
        Me.lblNewCharsize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewCharsize.Name = "lblNewCharsize"
        Me.lblNewCharsize.Size = New System.Drawing.Size(75, 12)
        Me.lblNewCharsize.TabIndex = 39
        Me.lblNewCharsize.Text = "Char Size:"
        '
        'lblNewCharsizeWidth
        '
        Me.lblNewCharsizeWidth.AutoSize = True
        Me.lblNewCharsizeWidth.Location = New System.Drawing.Point(64, 8)
        Me.lblNewCharsizeWidth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNewCharsizeWidth.Name = "lblNewCharsizeWidth"
        Me.lblNewCharsizeWidth.Size = New System.Drawing.Size(41, 12)
        Me.lblNewCharsizeWidth.TabIndex = 39
        Me.lblNewCharsizeWidth.Text = "Width:"
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
        Me.cboCodepage.Size = New System.Drawing.Size(246, 20)
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
        Me.tagOpen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tagOpen.Controls.Add(Me.btnOpenSave)
        Me.tagOpen.Controls.Add(Me.txtInsertEnd)
        Me.tagOpen.Controls.Add(Me.lblCodeLocateEnd)
        Me.tagOpen.Controls.Add(Me.chkBigEndding)
        Me.tagOpen.Controls.Add(Me.lblOpenCodepage)
        Me.tagOpen.Controls.Add(Me.cboImportCodepage)
        Me.tagOpen.Controls.Add(Me.btnOpenFile)
        Me.tagOpen.Controls.Add(Me.btnInsert)
        Me.tagOpen.Controls.Add(Me.txtInsertStart)
        Me.tagOpen.Controls.Add(Me.lblCodeLocateStart)
        Me.tagOpen.Controls.Add(Me.lblOpenCodelocate)
        Me.tagOpen.Controls.Add(Me.chkInverse)
        Me.tagOpen.Controls.Add(Me.lblOpenCharsizeHeight)
        Me.tagOpen.Controls.Add(Me.lblOpenCodesizeHigh)
        Me.tagOpen.Controls.Add(Me.lblOpenType)
        Me.tagOpen.Controls.Add(Me.lblOpenFile)
        Me.tagOpen.Controls.Add(Me.lblOpenOffset)
        Me.tagOpen.Controls.Add(Me.lblOpenCodesizeLow)
        Me.tagOpen.Controls.Add(Me.lblOpenCodesize)
        Me.tagOpen.Controls.Add(Me.lblOpenCharsize)
        Me.tagOpen.Controls.Add(Me.lblOpenCharsizeWidth)
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
        Me.tagOpen.Size = New System.Drawing.Size(308, 201)
        Me.tagOpen.TabIndex = 0
        Me.tagOpen.Text = "Open"
        '
        'btnOpenSave
        '
        Me.btnOpenSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenSave.Location = New System.Drawing.Point(226, 183)
        Me.btnOpenSave.Name = "btnOpenSave"
        Me.btnOpenSave.Size = New System.Drawing.Size(86, 23)
        Me.btnOpenSave.TabIndex = 56
        Me.btnOpenSave.Text = "Save"
        Me.btnOpenSave.UseVisualStyleBackColor = True
        Me.btnOpenSave.Visible = False
        '
        'txtInsertEnd
        '
        Me.txtInsertEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInsertEnd.Location = New System.Drawing.Point(256, 156)
        Me.txtInsertEnd.Name = "txtInsertEnd"
        Me.txtInsertEnd.Size = New System.Drawing.Size(56, 21)
        Me.txtInsertEnd.TabIndex = 55
        Me.txtInsertEnd.Text = "0"
        '
        'lblCodeLocateEnd
        '
        Me.lblCodeLocateEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodeLocateEnd.AutoSize = True
        Me.lblCodeLocateEnd.Location = New System.Drawing.Point(222, 159)
        Me.lblCodeLocateEnd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodeLocateEnd.Name = "lblCodeLocateEnd"
        Me.lblCodeLocateEnd.Size = New System.Drawing.Size(29, 12)
        Me.lblCodeLocateEnd.TabIndex = 54
        Me.lblCodeLocateEnd.Text = "End:"
        '
        'chkBigEndding
        '
        Me.chkBigEndding.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkBigEndding.AutoSize = True
        Me.chkBigEndding.Location = New System.Drawing.Point(204, 131)
        Me.chkBigEndding.Name = "chkBigEndding"
        Me.chkBigEndding.Size = New System.Drawing.Size(108, 16)
        Me.chkBigEndding.TabIndex = 53
        Me.chkBigEndding.Text = "Little endding"
        Me.chkBigEndding.UseVisualStyleBackColor = True
        '
        'lblOpenCodepage
        '
        Me.lblOpenCodepage.AutoSize = True
        Me.lblOpenCodepage.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblOpenCodepage.Location = New System.Drawing.Point(6, 81)
        Me.lblOpenCodepage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOpenCodepage.Name = "lblOpenCodepage"
        Me.lblOpenCodepage.Size = New System.Drawing.Size(68, 12)
        Me.lblOpenCodepage.TabIndex = 52
        Me.lblOpenCodepage.Text = "Codepage:"
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
        Me.cboImportCodepage.Size = New System.Drawing.Size(243, 20)
        Me.cboImportCodepage.TabIndex = 51
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenFile.AutoSize = True
        Me.btnOpenFile.Location = New System.Drawing.Point(265, 2)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(47, 23)
        Me.btnOpenFile.TabIndex = 50
        Me.btnOpenFile.Text = "open"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInsert.Location = New System.Drawing.Point(136, 183)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(86, 23)
        Me.btnInsert.TabIndex = 47
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtInsertStart
        '
        Me.txtInsertStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInsertStart.Location = New System.Drawing.Point(161, 156)
        Me.txtInsertStart.Name = "txtInsertStart"
        Me.txtInsertStart.Size = New System.Drawing.Size(56, 21)
        Me.txtInsertStart.TabIndex = 49
        Me.txtInsertStart.Text = "0"
        '
        'lblCodeLocateStart
        '
        Me.lblCodeLocateStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCodeLocateStart.AutoSize = True
        Me.lblCodeLocateStart.Location = New System.Drawing.Point(115, 159)
        Me.lblCodeLocateStart.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodeLocateStart.Name = "lblCodeLocateStart"
        Me.lblCodeLocateStart.Size = New System.Drawing.Size(41, 12)
        Me.lblCodeLocateStart.TabIndex = 48
        Me.lblCodeLocateStart.Text = "Start:"
        '
        'lblOpenCodelocate
        '
        Me.lblOpenCodelocate.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblOpenCodelocate.Location = New System.Drawing.Point(6, 159)
        Me.lblOpenCodelocate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOpenCodelocate.Name = "lblOpenCodelocate"
        Me.lblOpenCodelocate.Size = New System.Drawing.Size(83, 17)
        Me.lblOpenCodelocate.TabIndex = 47
        Me.lblOpenCodelocate.Text = "Code Locate:"
        '
        'chkInverse
        '
        Me.chkInverse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkInverse.AutoSize = True
        Me.chkInverse.Location = New System.Drawing.Point(132, 131)
        Me.chkInverse.Name = "chkInverse"
        Me.chkInverse.Size = New System.Drawing.Size(66, 16)
        Me.chkInverse.TabIndex = 23
        Me.chkInverse.Text = "Inverse"
        Me.chkInverse.UseVisualStyleBackColor = True
        '
        'lblOpenCharsizeHeight
        '
        Me.lblOpenCharsizeHeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOpenCharsizeHeight.AutoSize = True
        Me.lblOpenCharsizeHeight.Location = New System.Drawing.Point(229, 56)
        Me.lblOpenCharsizeHeight.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOpenCharsizeHeight.Name = "lblOpenCharsizeHeight"
        Me.lblOpenCharsizeHeight.Size = New System.Drawing.Size(47, 12)
        Me.lblOpenCharsizeHeight.TabIndex = 40
        Me.lblOpenCharsizeHeight.Text = "Height:"
        '
        'lblOpenCodesizeHigh
        '
        Me.lblOpenCodesizeHigh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOpenCodesizeHigh.AutoSize = True
        Me.lblOpenCodesizeHigh.Location = New System.Drawing.Point(241, 105)
        Me.lblOpenCodesizeHigh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOpenCodesizeHigh.Name = "lblOpenCodesizeHigh"
        Me.lblOpenCodesizeHigh.Size = New System.Drawing.Size(35, 12)
        Me.lblOpenCodesizeHigh.TabIndex = 41
        Me.lblOpenCodesizeHigh.Text = "High:"
        '
        'lblOpenType
        '
        Me.lblOpenType.AutoSize = True
        Me.lblOpenType.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblOpenType.Location = New System.Drawing.Point(6, 32)
        Me.lblOpenType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOpenType.Name = "lblOpenType"
        Me.lblOpenType.Size = New System.Drawing.Size(40, 12)
        Me.lblOpenType.TabIndex = 42
        Me.lblOpenType.Text = "Type:"
        '
        'lblOpenFile
        '
        Me.lblOpenFile.AutoSize = True
        Me.lblOpenFile.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblOpenFile.Location = New System.Drawing.Point(6, 7)
        Me.lblOpenFile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOpenFile.Name = "lblOpenFile"
        Me.lblOpenFile.Size = New System.Drawing.Size(40, 12)
        Me.lblOpenFile.TabIndex = 42
        Me.lblOpenFile.Text = "File:"
        '
        'lblOpenOffset
        '
        Me.lblOpenOffset.AutoSize = True
        Me.lblOpenOffset.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblOpenOffset.Location = New System.Drawing.Point(6, 132)
        Me.lblOpenOffset.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOpenOffset.Name = "lblOpenOffset"
        Me.lblOpenOffset.Size = New System.Drawing.Size(54, 12)
        Me.lblOpenOffset.TabIndex = 42
        Me.lblOpenOffset.Text = "Offset:"
        '
        'lblOpenCodesizeLow
        '
        Me.lblOpenCodesizeLow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOpenCodesizeLow.AutoSize = True
        Me.lblOpenCodesizeLow.Location = New System.Drawing.Point(159, 105)
        Me.lblOpenCodesizeLow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOpenCodesizeLow.Name = "lblOpenCodesizeLow"
        Me.lblOpenCodesizeLow.Size = New System.Drawing.Size(29, 12)
        Me.lblOpenCodesizeLow.TabIndex = 43
        Me.lblOpenCodesizeLow.Text = "Low:"
        '
        'lblOpenCodesize
        '
        Me.lblOpenCodesize.AutoSize = True
        Me.lblOpenCodesize.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblOpenCodesize.Location = New System.Drawing.Point(6, 105)
        Me.lblOpenCodesize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOpenCodesize.Name = "lblOpenCodesize"
        Me.lblOpenCodesize.Size = New System.Drawing.Size(68, 12)
        Me.lblOpenCodesize.TabIndex = 44
        Me.lblOpenCodesize.Text = "Code Size"
        '
        'lblOpenCharsize
        '
        Me.lblOpenCharsize.AutoSize = True
        Me.lblOpenCharsize.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblOpenCharsize.Location = New System.Drawing.Point(6, 56)
        Me.lblOpenCharsize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOpenCharsize.Name = "lblOpenCharsize"
        Me.lblOpenCharsize.Size = New System.Drawing.Size(75, 12)
        Me.lblOpenCharsize.TabIndex = 45
        Me.lblOpenCharsize.Text = "Char Size:"
        '
        'lblOpenCharsizeWidth
        '
        Me.lblOpenCharsizeWidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOpenCharsizeWidth.AutoSize = True
        Me.lblOpenCharsizeWidth.Location = New System.Drawing.Point(147, 56)
        Me.lblOpenCharsizeWidth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOpenCharsizeWidth.Name = "lblOpenCharsizeWidth"
        Me.lblOpenCharsizeWidth.Size = New System.Drawing.Size(41, 12)
        Me.lblOpenCharsizeWidth.TabIndex = 46
        Me.lblOpenCharsizeWidth.Text = "Width:"
        '
        'cboImportType
        '
        Me.cboImportType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboImportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImportType.FormattingEnabled = True
        Me.cboImportType.Items.AddRange(New Object() {"RAW", ".FONT.PNG", ".HZCG6", "Nintendo-8Bit"})
        Me.cboImportType.Location = New System.Drawing.Point(46, 29)
        Me.cboImportType.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cboImportType.Name = "cboImportType"
        Me.cboImportType.Size = New System.Drawing.Size(266, 20)
        Me.cboImportType.TabIndex = 17
        '
        'txtImportOffset
        '
        Me.txtImportOffset.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImportOffset.Location = New System.Drawing.Point(71, 129)
        Me.txtImportOffset.Name = "txtImportOffset"
        Me.txtImportOffset.Size = New System.Drawing.Size(55, 21)
        Me.txtImportOffset.TabIndex = 22
        Me.txtImportOffset.Text = "0"
        '
        'txtImportSizeH
        '
        Me.txtImportSizeH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImportSizeH.Location = New System.Drawing.Point(281, 102)
        Me.txtImportSizeH.Name = "txtImportSizeH"
        Me.txtImportSizeH.Size = New System.Drawing.Size(31, 21)
        Me.txtImportSizeH.TabIndex = 21
        Me.txtImportSizeH.Text = "256"
        '
        'txtImportSizeW
        '
        Me.txtImportSizeW.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImportSizeW.Location = New System.Drawing.Point(193, 102)
        Me.txtImportSizeW.Name = "txtImportSizeW"
        Me.txtImportSizeW.Size = New System.Drawing.Size(31, 21)
        Me.txtImportSizeW.TabIndex = 20
        Me.txtImportSizeW.Text = "256"
        '
        'txtImportHeight
        '
        Me.txtImportHeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImportHeight.Location = New System.Drawing.Point(281, 53)
        Me.txtImportHeight.Name = "txtImportHeight"
        Me.txtImportHeight.Size = New System.Drawing.Size(31, 21)
        Me.txtImportHeight.TabIndex = 19
        Me.txtImportHeight.Text = "16"
        '
        'txtImportWidth
        '
        Me.txtImportWidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImportWidth.Location = New System.Drawing.Point(193, 53)
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
        Me.txtImportFileName.Size = New System.Drawing.Size(213, 21)
        Me.txtImportFileName.TabIndex = 16
        Me.txtImportFileName.Text = "C:\Users\张展新\Desktop\font\[AYUMI]N.FNT"
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImport.Location = New System.Drawing.Point(44, 183)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(86, 23)
        Me.btnImport.TabIndex = 24
        Me.btnImport.Text = "Open"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'tagSave
        '
        Me.tagSave.AutoScroll = True
        Me.tagSave.BackColor = System.Drawing.SystemColors.Control
        Me.tagSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tagSave.Controls.Add(Me.lblSaveCoderangeFrom)
        Me.tagSave.Controls.Add(Me.btnOpenSaveimagepath)
        Me.tagSave.Controls.Add(Me.txtCodeRangeEnd)
        Me.tagSave.Controls.Add(Me.txtCodeRangeStart)
        Me.tagSave.Controls.Add(Me.lblSaveCoderangeTo)
        Me.tagSave.Controls.Add(Me.lblSaveCoderange)
        Me.tagSave.Controls.Add(Me.lblSaveType)
        Me.tagSave.Controls.Add(Me.lblSavePath)
        Me.tagSave.Controls.Add(Me.lblSaveFile)
        Me.tagSave.Controls.Add(Me.btnOpenFolder)
        Me.tagSave.Controls.Add(Me.txtSaveImagePath)
        Me.tagSave.Controls.Add(Me.cboSaveFileType)
        Me.tagSave.Controls.Add(Me.txtSaveImage)
        Me.tagSave.Controls.Add(Me.btnSave)
        Me.tagSave.Location = New System.Drawing.Point(4, 22)
        Me.tagSave.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tagSave.Name = "tagSave"
        Me.tagSave.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tagSave.Size = New System.Drawing.Size(307, 201)
        Me.tagSave.TabIndex = 1
        Me.tagSave.Text = "Save"
        '
        'lblSaveCoderangeFrom
        '
        Me.lblSaveCoderangeFrom.AutoSize = True
        Me.lblSaveCoderangeFrom.Location = New System.Drawing.Point(73, 91)
        Me.lblSaveCoderangeFrom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSaveCoderangeFrom.Name = "lblSaveCoderangeFrom"
        Me.lblSaveCoderangeFrom.Size = New System.Drawing.Size(35, 12)
        Me.lblSaveCoderangeFrom.TabIndex = 48
        Me.lblSaveCoderangeFrom.Text = "From:"
        '
        'btnOpenSaveimagepath
        '
        Me.btnOpenSaveimagepath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenSaveimagepath.Location = New System.Drawing.Point(264, 5)
        Me.btnOpenSaveimagepath.Name = "btnOpenSaveimagepath"
        Me.btnOpenSaveimagepath.Size = New System.Drawing.Size(47, 23)
        Me.btnOpenSaveimagepath.TabIndex = 47
        Me.btnOpenSaveimagepath.Text = "open"
        Me.btnOpenSaveimagepath.UseVisualStyleBackColor = True
        '
        'txtCodeRangeEnd
        '
        Me.txtCodeRangeEnd.Location = New System.Drawing.Point(209, 84)
        Me.txtCodeRangeEnd.Name = "txtCodeRangeEnd"
        Me.txtCodeRangeEnd.Size = New System.Drawing.Size(51, 21)
        Me.txtCodeRangeEnd.TabIndex = 29
        Me.txtCodeRangeEnd.Text = "FF"
        '
        'txtCodeRangeStart
        '
        Me.txtCodeRangeStart.Location = New System.Drawing.Point(131, 84)
        Me.txtCodeRangeStart.Name = "txtCodeRangeStart"
        Me.txtCodeRangeStart.Size = New System.Drawing.Size(51, 21)
        Me.txtCodeRangeStart.TabIndex = 28
        Me.txtCodeRangeStart.Text = "0"
        '
        'lblSaveCoderangeTo
        '
        Me.lblSaveCoderangeTo.AutoSize = True
        Me.lblSaveCoderangeTo.Location = New System.Drawing.Point(187, 87)
        Me.lblSaveCoderangeTo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSaveCoderangeTo.Name = "lblSaveCoderangeTo"
        Me.lblSaveCoderangeTo.Size = New System.Drawing.Size(23, 12)
        Me.lblSaveCoderangeTo.TabIndex = 46
        Me.lblSaveCoderangeTo.Text = "to:"
        '
        'lblSaveCoderange
        '
        Me.lblSaveCoderange.AutoSize = True
        Me.lblSaveCoderange.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblSaveCoderange.Location = New System.Drawing.Point(4, 86)
        Me.lblSaveCoderange.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSaveCoderange.Name = "lblSaveCoderange"
        Me.lblSaveCoderange.Size = New System.Drawing.Size(82, 12)
        Me.lblSaveCoderange.TabIndex = 45
        Me.lblSaveCoderange.Text = "Code Range:"
        '
        'lblSaveType
        '
        Me.lblSaveType.AutoSize = True
        Me.lblSaveType.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblSaveType.Location = New System.Drawing.Point(4, 62)
        Me.lblSaveType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSaveType.Name = "lblSaveType"
        Me.lblSaveType.Size = New System.Drawing.Size(40, 12)
        Me.lblSaveType.TabIndex = 44
        Me.lblSaveType.Text = "Type:"
        '
        'lblSavePath
        '
        Me.lblSavePath.AutoSize = True
        Me.lblSavePath.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblSavePath.Location = New System.Drawing.Point(4, 10)
        Me.lblSavePath.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSavePath.Name = "lblSavePath"
        Me.lblSavePath.Size = New System.Drawing.Size(40, 12)
        Me.lblSavePath.TabIndex = 43
        Me.lblSavePath.Text = "Path:"
        '
        'lblSaveFile
        '
        Me.lblSaveFile.AutoSize = True
        Me.lblSaveFile.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblSaveFile.Location = New System.Drawing.Point(4, 37)
        Me.lblSaveFile.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSaveFile.Name = "lblSaveFile"
        Me.lblSaveFile.Size = New System.Drawing.Size(40, 12)
        Me.lblSaveFile.TabIndex = 43
        Me.lblSaveFile.Text = "File:"
        '
        'btnOpenFolder
        '
        Me.btnOpenFolder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenFolder.Location = New System.Drawing.Point(170, 139)
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
        Me.txtSaveImagePath.Size = New System.Drawing.Size(214, 21)
        Me.txtSaveImagePath.TabIndex = 25
        Me.txtSaveImagePath.Text = "256"
        '
        'cboSaveFileType
        '
        Me.cboSaveFileType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSaveFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSaveFileType.FormattingEnabled = True
        Me.cboSaveFileType.Items.AddRange(New Object() {".FONT.PNG", "RAW", ".CODE.PNG(多个)", ".SVG", ".CODE.SVG(多个)", ".TTX", ".HZCG6", ".hz.ww-hh"})
        Me.cboSaveFileType.Location = New System.Drawing.Point(43, 59)
        Me.cboSaveFileType.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cboSaveFileType.Name = "cboSaveFileType"
        Me.cboSaveFileType.Size = New System.Drawing.Size(268, 20)
        Me.cboSaveFileType.TabIndex = 27
        '
        'txtSaveImage
        '
        Me.txtSaveImage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaveImage.Location = New System.Drawing.Point(44, 34)
        Me.txtSaveImage.Name = "txtSaveImage"
        Me.txtSaveImage.Size = New System.Drawing.Size(267, 21)
        Me.txtSaveImage.TabIndex = 26
        Me.txtSaveImage.Text = "256"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(170, 110)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(141, 23)
        Me.btnSave.TabIndex = 31
        Me.btnSave.Text = "Save (as)"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'tagEdit
        '
        Me.tagEdit.BackColor = System.Drawing.SystemColors.Control
        Me.tagEdit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tagEdit.Controls.Add(Me.btnExchange)
        Me.tagEdit.Controls.Add(Me.lblThresholdBW)
        Me.tagEdit.Controls.Add(Me.hsbThresholdBW)
        Me.tagEdit.Controls.Add(Me.btnDrawLines)
        Me.tagEdit.Controls.Add(Me.btnCopyCode)
        Me.tagEdit.Controls.Add(Me.btnEditClean)
        Me.tagEdit.Controls.Add(Me.btnCharacterAdjust)
        Me.tagEdit.Controls.Add(Me.btnMoveCode)
        Me.tagEdit.Controls.Add(Me.txtMoveTo)
        Me.tagEdit.Controls.Add(Me.lblEditMoveTo)
        Me.tagEdit.Controls.Add(Me.txtMoveEnd)
        Me.tagEdit.Controls.Add(Me.txtMoveStart)
        Me.tagEdit.Controls.Add(Me.lblEditMoveEnd)
        Me.tagEdit.Controls.Add(Me.lblEditMoveFrom)
        Me.tagEdit.Controls.Add(Me.lblEditMove)
        Me.tagEdit.Controls.Add(Me.lblCharacteradjustY)
        Me.tagEdit.Controls.Add(Me.lblEditScale)
        Me.tagEdit.Controls.Add(Me.lblCharacteradjust)
        Me.tagEdit.Controls.Add(Me.lblCharacteradjustX)
        Me.tagEdit.Controls.Add(Me.txtMoveY)
        Me.tagEdit.Controls.Add(Me.txtMoveX)
        Me.tagEdit.Controls.Add(Me.btnToBlackWhite)
        Me.tagEdit.Controls.Add(Me.btnInverseColor)
        Me.tagEdit.Controls.Add(Me.btnScale)
        Me.tagEdit.Controls.Add(Me.txtScale)
        Me.tagEdit.Location = New System.Drawing.Point(4, 22)
        Me.tagEdit.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tagEdit.Name = "tagEdit"
        Me.tagEdit.Size = New System.Drawing.Size(307, 201)
        Me.tagEdit.TabIndex = 2
        Me.tagEdit.Text = "Edit"
        '
        'btnExchange
        '
        Me.btnExchange.Location = New System.Drawing.Point(252, 179)
        Me.btnExchange.Name = "btnExchange"
        Me.btnExchange.Size = New System.Drawing.Size(50, 23)
        Me.btnExchange.TabIndex = 61
        Me.btnExchange.Text = "Exchange"
        Me.btnExchange.UseVisualStyleBackColor = True
        '
        'lblThresholdBW
        '
        Me.lblThresholdBW.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblThresholdBW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThresholdBW.Location = New System.Drawing.Point(73, 59)
        Me.lblThresholdBW.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblThresholdBW.Name = "lblThresholdBW"
        Me.lblThresholdBW.Size = New System.Drawing.Size(23, 23)
        Me.lblThresholdBW.TabIndex = 60
        Me.lblThresholdBW.Visible = False
        '
        'hsbThresholdBW
        '
        Me.hsbThresholdBW.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hsbThresholdBW.Location = New System.Drawing.Point(10, 59)
        Me.hsbThresholdBW.Maximum = 255
        Me.hsbThresholdBW.Name = "hsbThresholdBW"
        Me.hsbThresholdBW.Size = New System.Drawing.Size(59, 34)
        Me.hsbThresholdBW.TabIndex = 59
        Me.hsbThresholdBW.Visible = False
        '
        'btnDrawLines
        '
        Me.btnDrawLines.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDrawLines.Location = New System.Drawing.Point(7, 32)
        Me.btnDrawLines.Name = "btnDrawLines"
        Me.btnDrawLines.Size = New System.Drawing.Size(88, 23)
        Me.btnDrawLines.TabIndex = 58
        Me.btnDrawLines.Text = "Draw Lines"
        Me.btnDrawLines.UseVisualStyleBackColor = True
        '
        'btnCopyCode
        '
        Me.btnCopyCode.Location = New System.Drawing.Point(195, 178)
        Me.btnCopyCode.Name = "btnCopyCode"
        Me.btnCopyCode.Size = New System.Drawing.Size(50, 23)
        Me.btnCopyCode.TabIndex = 57
        Me.btnCopyCode.Text = "Copy"
        Me.btnCopyCode.UseVisualStyleBackColor = True
        '
        'btnEditClean
        '
        Me.btnEditClean.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditClean.Location = New System.Drawing.Point(25, 151)
        Me.btnEditClean.Name = "btnEditClean"
        Me.btnEditClean.Size = New System.Drawing.Size(45, 23)
        Me.btnEditClean.TabIndex = 56
        Me.btnEditClean.Text = "Clean"
        Me.btnEditClean.UseVisualStyleBackColor = True
        '
        'btnCharacterAdjust
        '
        Me.btnCharacterAdjust.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCharacterAdjust.Location = New System.Drawing.Point(252, 95)
        Me.btnCharacterAdjust.Name = "btnCharacterAdjust"
        Me.btnCharacterAdjust.Size = New System.Drawing.Size(59, 23)
        Me.btnCharacterAdjust.TabIndex = 51
        Me.btnCharacterAdjust.Text = "Adjust"
        Me.btnCharacterAdjust.UseVisualStyleBackColor = True
        '
        'btnMoveCode
        '
        Me.btnMoveCode.Location = New System.Drawing.Point(139, 178)
        Me.btnMoveCode.Name = "btnMoveCode"
        Me.btnMoveCode.Size = New System.Drawing.Size(50, 23)
        Me.btnMoveCode.TabIndex = 50
        Me.btnMoveCode.Text = "Move"
        Me.btnMoveCode.UseVisualStyleBackColor = True
        '
        'txtMoveTo
        '
        Me.txtMoveTo.Location = New System.Drawing.Point(270, 129)
        Me.txtMoveTo.Name = "txtMoveTo"
        Me.txtMoveTo.Size = New System.Drawing.Size(33, 21)
        Me.txtMoveTo.TabIndex = 49
        '
        'lblEditMoveTo
        '
        Me.lblEditMoveTo.AutoSize = True
        Me.lblEditMoveTo.Location = New System.Drawing.Point(242, 131)
        Me.lblEditMoveTo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEditMoveTo.Name = "lblEditMoveTo"
        Me.lblEditMoveTo.Size = New System.Drawing.Size(23, 12)
        Me.lblEditMoveTo.TabIndex = 48
        Me.lblEditMoveTo.Text = "to:"
        '
        'txtMoveEnd
        '
        Me.txtMoveEnd.Location = New System.Drawing.Point(191, 127)
        Me.txtMoveEnd.Name = "txtMoveEnd"
        Me.txtMoveEnd.Size = New System.Drawing.Size(48, 21)
        Me.txtMoveEnd.TabIndex = 47
        '
        'txtMoveStart
        '
        Me.txtMoveStart.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMoveStart.Location = New System.Drawing.Point(109, 125)
        Me.txtMoveStart.Name = "txtMoveStart"
        Me.txtMoveStart.Size = New System.Drawing.Size(48, 21)
        Me.txtMoveStart.TabIndex = 46
        '
        'lblEditMoveEnd
        '
        Me.lblEditMoveEnd.AutoSize = True
        Me.lblEditMoveEnd.Location = New System.Drawing.Point(160, 130)
        Me.lblEditMoveEnd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEditMoveEnd.Name = "lblEditMoveEnd"
        Me.lblEditMoveEnd.Size = New System.Drawing.Size(29, 12)
        Me.lblEditMoveEnd.TabIndex = 45
        Me.lblEditMoveEnd.Text = "end:"
        '
        'lblEditMoveFrom
        '
        Me.lblEditMoveFrom.AutoSize = True
        Me.lblEditMoveFrom.Location = New System.Drawing.Point(69, 127)
        Me.lblEditMoveFrom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEditMoveFrom.Name = "lblEditMoveFrom"
        Me.lblEditMoveFrom.Size = New System.Drawing.Size(35, 12)
        Me.lblEditMoveFrom.TabIndex = 45
        Me.lblEditMoveFrom.Text = "from:"
        '
        'lblEditMove
        '
        Me.lblEditMove.AutoSize = True
        Me.lblEditMove.Location = New System.Drawing.Point(4, 127)
        Me.lblEditMove.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEditMove.Name = "lblEditMove"
        Me.lblEditMove.Size = New System.Drawing.Size(65, 12)
        Me.lblEditMove.TabIndex = 45
        Me.lblEditMove.Text = "Move Code:"
        '
        'lblCharacteradjustY
        '
        Me.lblCharacteradjustY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCharacteradjustY.AutoSize = True
        Me.lblCharacteradjustY.Location = New System.Drawing.Point(189, 99)
        Me.lblCharacteradjustY.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCharacteradjustY.Name = "lblCharacteradjustY"
        Me.lblCharacteradjustY.Size = New System.Drawing.Size(17, 12)
        Me.lblCharacteradjustY.TabIndex = 42
        Me.lblCharacteradjustY.Text = "Y:"
        '
        'lblEditScale
        '
        Me.lblEditScale.AutoSize = True
        Me.lblEditScale.Location = New System.Drawing.Point(4, 8)
        Me.lblEditScale.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEditScale.Name = "lblEditScale"
        Me.lblEditScale.Size = New System.Drawing.Size(41, 12)
        Me.lblEditScale.TabIndex = 43
        Me.lblEditScale.Text = "Scale:"
        '
        'lblCharacteradjust
        '
        Me.lblCharacteradjust.AutoSize = True
        Me.lblCharacteradjust.Location = New System.Drawing.Point(4, 99)
        Me.lblCharacteradjust.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCharacteradjust.Name = "lblCharacteradjust"
        Me.lblCharacteradjust.Size = New System.Drawing.Size(107, 12)
        Me.lblCharacteradjust.TabIndex = 43
        Me.lblCharacteradjust.Text = "Character adjust:"
        '
        'lblCharacteradjustX
        '
        Me.lblCharacteradjustX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCharacteradjustX.AutoSize = True
        Me.lblCharacteradjustX.Location = New System.Drawing.Point(128, 99)
        Me.lblCharacteradjustX.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCharacteradjustX.Name = "lblCharacteradjustX"
        Me.lblCharacteradjustX.Size = New System.Drawing.Size(17, 12)
        Me.lblCharacteradjustX.TabIndex = 44
        Me.lblCharacteradjustX.Text = "X:"
        '
        'txtMoveY
        '
        Me.txtMoveY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMoveY.Location = New System.Drawing.Point(211, 96)
        Me.txtMoveY.Name = "txtMoveY"
        Me.txtMoveY.Size = New System.Drawing.Size(35, 21)
        Me.txtMoveY.TabIndex = 37
        '
        'txtMoveX
        '
        Me.txtMoveX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMoveX.Location = New System.Drawing.Point(150, 96)
        Me.txtMoveX.Name = "txtMoveX"
        Me.txtMoveX.Size = New System.Drawing.Size(34, 21)
        Me.txtMoveX.TabIndex = 36
        '
        'btnToBlackWhite
        '
        Me.btnToBlackWhite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnToBlackWhite.Location = New System.Drawing.Point(209, 59)
        Me.btnToBlackWhite.Name = "btnToBlackWhite"
        Me.btnToBlackWhite.Size = New System.Drawing.Size(102, 23)
        Me.btnToBlackWhite.TabIndex = 35
        Me.btnToBlackWhite.Text = "To Black/White"
        Me.btnToBlackWhite.UseVisualStyleBackColor = True
        '
        'btnInverseColor
        '
        Me.btnInverseColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInverseColor.Location = New System.Drawing.Point(101, 32)
        Me.btnInverseColor.Name = "btnInverseColor"
        Me.btnInverseColor.Size = New System.Drawing.Size(102, 23)
        Me.btnInverseColor.TabIndex = 34
        Me.btnInverseColor.Text = "Inverse Color"
        Me.btnInverseColor.UseVisualStyleBackColor = True
        '
        'btnScale
        '
        Me.btnScale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnScale.Location = New System.Drawing.Point(184, 3)
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
        Me.txtScale.Size = New System.Drawing.Size(116, 21)
        Me.txtScale.TabIndex = 32
        Me.txtScale.Text = "100%"
        '
        'tagSpecial
        '
        Me.tagSpecial.BackColor = System.Drawing.SystemColors.Control
        Me.tagSpecial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tagSpecial.Controls.Add(Me.btnPic2HZ)
        Me.tagSpecial.Controls.Add(Me.btnOutput1)
        Me.tagSpecial.Controls.Add(Me.btnSpecial)
        Me.tagSpecial.Location = New System.Drawing.Point(4, 22)
        Me.tagSpecial.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.tagSpecial.Name = "tagSpecial"
        Me.tagSpecial.Size = New System.Drawing.Size(307, 201)
        Me.tagSpecial.TabIndex = 3
        Me.tagSpecial.Text = "Special"
        '
        'btnPic2HZ
        '
        Me.btnPic2HZ.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPic2HZ.Location = New System.Drawing.Point(7, 63)
        Me.btnPic2HZ.Name = "btnPic2HZ"
        Me.btnPic2HZ.Size = New System.Drawing.Size(303, 23)
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
        Me.btnOutput1.Size = New System.Drawing.Size(304, 23)
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
        Me.btnSpecial.Size = New System.Drawing.Size(304, 23)
        Me.btnSpecial.TabIndex = 39
        Me.btnSpecial.Text = "Compare"
        Me.btnSpecial.UseVisualStyleBackColor = True
        '
        'lblCursor
        '
        Me.lblCursor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCursor.AutoSize = True
        Me.lblCursor.Location = New System.Drawing.Point(8, 340)
        Me.lblCursor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCursor.Name = "lblCursor"
        Me.lblCursor.Size = New System.Drawing.Size(29, 12)
        Me.lblCursor.TabIndex = 21
        Me.lblCursor.Text = "Dot:"
        '
        'lblColRow
        '
        Me.lblColRow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblColRow.AutoSize = True
        Me.lblColRow.Location = New System.Drawing.Point(7, 325)
        Me.lblColRow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblColRow.Name = "lblColRow"
        Me.lblColRow.Size = New System.Drawing.Size(59, 12)
        Me.lblColRow.TabIndex = 21
        Me.lblColRow.Text = "Location:"
        '
        'lblCharacterSize
        '
        Me.lblCharacterSize.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCharacterSize.AutoSize = True
        Me.lblCharacterSize.Location = New System.Drawing.Point(7, 290)
        Me.lblCharacterSize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCharacterSize.Name = "lblCharacterSize"
        Me.lblCharacterSize.Size = New System.Drawing.Size(95, 12)
        Me.lblCharacterSize.TabIndex = 21
        Me.lblCharacterSize.Text = "Character size:"
        '
        'lblCode
        '
        Me.lblCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCode.AutoSize = True
        Me.lblCode.Location = New System.Drawing.Point(7, 310)
        Me.lblCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(35, 12)
        Me.lblCode.TabIndex = 21
        Me.lblCode.Text = "Code:"
        '
        'btnPasteImage
        '
        Me.btnPasteImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPasteImage.Location = New System.Drawing.Point(214, 266)
        Me.btnPasteImage.Name = "btnPasteImage"
        Me.btnPasteImage.Size = New System.Drawing.Size(47, 23)
        Me.btnPasteImage.TabIndex = 15
        Me.btnPasteImage.Text = "Paste"
        Me.btnPasteImage.UseVisualStyleBackColor = True
        '
        'btnCopyCharImage
        '
        Me.btnCopyCharImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopyCharImage.Location = New System.Drawing.Point(167, 266)
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
        Me.picEdit.Size = New System.Drawing.Size(316, 88)
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
        'frmFont
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 467)
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
    Friend WithEvents btnOpenFolder As Button
    Friend WithEvents cboSaveFileType As ComboBox
    Friend WithEvents txtSaveImage As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents tagEdit As TabPage
    Friend WithEvents btnScale As Button
    Friend WithEvents txtScale As TextBox
    Friend WithEvents tagSpecial As TabPage
    Friend WithEvents btnSpecial As Button
    Friend WithEvents lblNewCharsizeHeight As Label
    Friend WithEvents lblNewCodesizeRow As Label
    Friend WithEvents lblNewFont As Label
    Friend WithEvents lblNewCodepage As Label
    Friend WithEvents lblNewCodesizeCol As Label
    Friend WithEvents lblNewCodesize As Label
    Friend WithEvents lblNewCharsize As Label
    Friend WithEvents lblNewCharsizeWidth As Label
    Friend WithEvents lblOpenCharsizeHeight As Label
    Friend WithEvents lblOpenCodesizeHigh As Label
    Friend WithEvents lblOpenType As Label
    Friend WithEvents lblOpenFile As Label
    Friend WithEvents lblOpenOffset As Label
    Friend WithEvents lblOpenCodesizeLow As Label
    Friend WithEvents lblOpenCodesize As Label
    Friend WithEvents lblOpenCharsize As Label
    Friend WithEvents lblOpenCharsizeWidth As Label
    Friend WithEvents lblSaveType As Label
    Friend WithEvents lblSaveFile As Label
    Friend WithEvents lblNewFontOffsetY As Label
    Friend WithEvents lblNewFontOffset As Label
    Friend WithEvents lblNewFontOffsetX As Label
    Friend WithEvents txtCharOffsetY As TextBox
    Friend WithEvents txtCharOffsetX As TextBox
    Friend WithEvents txtFontName As ComboBox
    Friend WithEvents lblSavePath As Label
    Friend WithEvents txtSaveImagePath As TextBox
    Friend WithEvents lblNewFontSize As Label
    Friend WithEvents txtCharSize As TextBox
    Friend WithEvents chkInverse As CheckBox
    Friend WithEvents lblCharacteradjustY As Label
    Friend WithEvents lblEditScale As Label
    Friend WithEvents lblCharacteradjust As Label
    Friend WithEvents lblCharacteradjustX As Label
    Friend WithEvents txtMoveY As TextBox
    Friend WithEvents txtMoveX As TextBox
    Friend WithEvents btnInverseColor As Button
    Friend WithEvents btnToBlackWhite As Button
    Friend WithEvents chkRound As CheckBox
    Friend WithEvents chkGrid As CheckBox
    Friend WithEvents btnOutput1 As Button
    Friend WithEvents lblBackColor As Label
    Friend WithEvents lblForeColor As Label
    Friend WithEvents txtCodeRangeEnd As TextBox
    Friend WithEvents txtCodeRangeStart As TextBox
    Friend WithEvents lblSaveCoderangeTo As Label
    Friend WithEvents lblSaveCoderange As Label
    Friend WithEvents btnPic2HZ As Button
    Friend WithEvents chkGap As CheckBox
    Friend WithEvents btnInsert As Button
    Friend WithEvents txtInsertStart As TextBox
    Friend WithEvents lblCodeLocateStart As Label
    Friend WithEvents lblOpenCodelocate As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnOpenSaveimagepath As Button
    Friend WithEvents folderSave As FolderBrowserDialog
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents fileOpen As OpenFileDialog
    Friend WithEvents lblCodeArraySize As Label
    Friend WithEvents lblCodeLength As Label
    Friend WithEvents lblCodepage As Label
    Friend WithEvents lblOpenCodepage As Label
    Friend WithEvents cboImportCodepage As ComboBox
    Friend WithEvents txtInsertEnd As TextBox
    Friend WithEvents lblCodeLocateEnd As Label
    Friend WithEvents chkBigEndding As CheckBox
    Friend WithEvents btnEditClean As Button
    Friend WithEvents btnMoveCode As Button
    Friend WithEvents txtMoveTo As TextBox
    Friend WithEvents lblEditMoveTo As Label
    Friend WithEvents txtMoveEnd As TextBox
    Friend WithEvents txtMoveStart As TextBox
    Friend WithEvents lblEditMoveEnd As Label
    Friend WithEvents lblEditMoveFrom As Label
    Friend WithEvents lblEditMove As Label
    Friend WithEvents btnCharacterAdjust As Button
    Friend WithEvents btnCopyCode As Button
    Friend WithEvents btnOpenSave As Button
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents btnDrawLines As Button
    Friend WithEvents hsbThresholdBW As HScrollBar
    Friend WithEvents lblThresholdBW As Label
    Friend WithEvents lblSaveCoderangeFrom As Label
    Friend WithEvents btnExchange As Button
    Friend WithEvents btnEditorInverse As Button
    Friend WithEvents btnEditorRRight As Button
    Friend WithEvents btnEditorRLeft As Button
    Friend WithEvents btnEditorRDown As Button
    Friend WithEvents btnEditorRUp As Button
    Friend WithEvents btnEditorRight As Button
    Friend WithEvents btnEditorLeft As Button
    Friend WithEvents btnEditorDown As Button
    Friend WithEvents btnEditorUp As Button
    Friend WithEvents cboCopyType As ComboBox
    Friend WithEvents btnPasteImage As Button
    Friend WithEvents btnCopyCharImage As Button
    Friend WithEvents lblNewBaseline As Label
    Friend WithEvents txtNewBaseline As TextBox
End Class
