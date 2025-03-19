Imports System.Xml

Public Class frmFont
    Private fontName As String = ""
    'codePage: 0=raw/unknown;1200=usc;932=shift_jis;936=gb2312;950=big5;1252=ascii
    Private codePage As Integer = 0
    Private codeL(256) As Integer
    Private codeH(256) As Integer
    Private codeUltraHigh As Integer ' for ISO/IEC 10646 SMP, SIP, TIP
    Private codeLowRange() As Integer
    Private codeHighRange() As Integer
    Private codeLength As Integer = 2

    Private cellWidth As Integer = 0
    Private cellHeight As Integer = 0
    Private cellBaseline As Integer = 0
    Private codeWidth As Integer = 0
    Private codeHeight As Integer = 0

    Private currCellX As Integer = -1
    Private currCellY As Integer = -1

    Private bmpDigitalL(16) As Bitmap
    Private bmpDigitalS(16) As Bitmap
    Private bmpHead As New Bitmap(13, 13)
    Private bmpV As Bitmap
    Private bmpH As Bitmap
    Private bmpMain As Bitmap
    Private bmpClipboard As New Bitmap(1, 1)

    Private isShiftPress As Boolean
    Private isCtrlPress As Boolean
    Private zoomInOut As Integer = 1
    Private isResizing As Boolean = False

    Private Sub updateInfoData()
        lblCodepage.Text = "Codepage: " & Str(codePage)
        lblCodeLength.Text = "Code length: " & Str(codeLength)
        lblCodeArraySize.Text = "Code array size: " & Str(codeWidth) & " x " & Str(codeHeight)
        lblCharacterSize.Text = "Character size: " & Str(cellWidth) & " x " & Str(cellHeight)
    End Sub

    Private Sub updateActiveData()
        Dim l As Integer = 1
        If codeLength >= 2 Then
            l = 2
        End If
        If currCellX >= 0 Then
            lblCode.Text = "Code: " & Strings.Right("00" & Hex(codeH(currCellY)), l) & Strings.Right("00" & Hex(codeL(currCellX)), l)
            lblColRow.Text = "Location: " & currCellX & "-" & currCellY
        Else
            lblCode.Text = "Code: "
            lblColRow.Text = "Location: "

        End If
    End Sub

    Private Function hexstr(n, sz) As String
        hexstr = Strings.Right("0000000" & Hex(n), sz)
    End Function

    Private Function in0255(v As Integer) As Integer
        If v < 0 Then
            in0255 = 0
        End If
        If v > 255 Then
            in0255 = 255
        End If
        in0255 = v
    End Function

    Private Sub initGraphicResource()
        Dim grp As Graphics
        For i = 0 To 15
            bmpDigitalL(i) = New Bitmap(5, 7)
            grp = Graphics.FromImage(bmpDigitalL(i))
            grp.DrawImage(iml57.Images(0), 0 - i * 5, 0)
            bmpDigitalS(i) = New Bitmap(3, 5)
            grp = Graphics.FromImage(bmpDigitalS(i))
            grp.DrawImage(iml35.Images(0), 0 - i * 3, 0)
        Next
    End Sub

    Private Sub initCharactor()
        If codePage < 0 Then
            Exit Sub
        End If
        If IsNothing(picMain.Image) Then
            Exit Sub
        End If
        Dim grpMain As Graphics = Graphics.FromImage(picMain.Image)
        Dim mBrush As SolidBrush
        Dim size As Integer
        Dim offset As Integer
        Dim offsetY As Integer

        If chkBlack.Checked = False Then
            mBrush = New SolidBrush(Color.LightPink)
        Else
            mBrush = New SolidBrush(Color.Black)
        End If
        offsetY = 0
        If chkMax.Checked = False Then
            If txtCharOffsetX.Text = "" Then
                If (cellHeight >= 16) Then
                    size = 12
                    offset = -3
                ElseIf (cellHeight >= 14) Then
                    size = 11
                    offset = -3
                ElseIf (cellHeight >= 13) Then
                    size = 10
                    offset = -3
                ElseIf (cellHeight >= 12) Then
                    size = 9
                    offset = -2
                Else
                    Exit Sub
                End If
            End If
        Else
            size = cellHeight / 3 * 2
            If txtCharOffsetX.Text = "" Then
                offset = -size / 5
            End If
        End If
        If txtCharOffsetX.Text <> "" Then
            offset = Int(txtCharOffsetX.Text)
        End If
        If txtCharOffsetY.Text <> "" Then
            offsetY = Int(txtCharOffsetY.Text)
        End If
        If txtCharSize.Text <> "" Then
            size = Int(txtCharSize.Text)
        End If

        txtCharOffsetX.Text = Str(offset)
        txtCharOffsetY.Text = Str(offsetY)
        txtCharSize.Text = Str(size)

        Dim mFont As Font
        mFont = New Font(txtFontName.Text, size)
        Dim currChar(5) As Byte
        Dim unicodeString As String
        Dim bmp As New Bitmap(cellWidth, cellHeight)
        Dim grp As Graphics = Graphics.FromImage(bmp)
        Dim brs As New SolidBrush(Color.White)
        startProgress(codeHeight)
        For i = 0 To codeHeight - 1
            For j = 0 To codeWidth - 1
                If codeLength = 2 Then
                    currChar(0) = codeH(i)
                    currChar(1) = codeL(j)
                ElseIf codePage = 12000 Then ' convert 3bytes To utf8
                    If codeUltraHigh <= &H1F Then
                        currChar(0) = &HF0 + (codeUltraHigh >> 2)
                        currChar(1) = &H80 + ((codeUltraHigh And &H3) << 4) + (codeH(i) >> 4)
                        currChar(2) = &H80 + ((codeH(i) And &HF) << 2) + (codeL(j) >> 6)
                        currChar(3) = &H80 + (codeL(j) And &H3F)
                    End If
                Else
                    currChar(0) = codeH(i) * 16 + codeL(j)
                    currChar(1) = 0
                End If
                If codePage = 12000 Then
                    unicodeString = System.Text.Encoding.UTF8.GetString(currChar)
                ElseIf codePage = 1200 Then
                    currChar(1) = codeH(i)
                    currChar(0) = codeL(j)
                    unicodeString = System.Text.Encoding.GetEncoding(codePage).GetString(currChar)
                Else
                    unicodeString = System.Text.Encoding.GetEncoding(codePage).GetString(currChar)
                End If
                grp.FillRectangle(brs, 0, 0, cellWidth, cellHeight)
                'grp.DrawString(unicodeString.Substring(0, 1), mFont, mBrush, offset, 0)
                grp.DrawString(unicodeString, mFont, mBrush, offset, offsetY)
                grpMain.DrawImage(bmp, j * (cellWidth + 1), i * (cellHeight + 1))
            Next
            goProgress(i + 1)
        Next
        endProgress()
        brs.Dispose()
        mFont.Dispose()
        bmp.Dispose()
        mBrush.Dispose()
        picMain.Refresh()
        RedrawEditor()
    End Sub

    Private Sub drawHead(dt As Integer, x As Integer, y As Integer)
        For i As Integer = 0 To 7
            If ((dt >> (7 - i)) Mod 2) = 0 Then
                bmpHead.SetPixel(x + i, y, Color.White)
            Else
                bmpHead.SetPixel(x + i, y, Color.Black)
            End If
        Next
    End Sub

    Private Function getHead(x As Integer, y As Integer) As Integer
        Dim rt = 0
        For i As Integer = 0 To 7
            rt = rt << 1
            If bmpHead.GetPixel(x + i, y).GetBrightness < 0.5 Then
                rt = rt + 1
            End If
        Next
        Return rt
    End Function

    Private Sub printHead()
        For i = 1 To 10
            bmpHead.SetPixel(1, i, Color.Black)
            bmpHead.SetPixel(10, i, Color.Black)
            bmpHead.SetPixel(i, 1, Color.Black)
            bmpHead.SetPixel(i, 10, Color.Black)
        Next
        drawHead(Int(codePage / 256), 2, 2)
        drawHead(codePage Mod 256, 2, 3)
        drawHead(cellWidth, 2, 4)
        drawHead(cellHeight, 2, 5)
        drawHead(codeWidth, 2, 6)
        drawHead(codeHeight, 2, 7)
        drawHead(codeUltraHigh, 2, 8)
        drawHead(cellBaseline, 2, 9)
    End Sub

    Private Sub readHead()
        codePage = getHead(2, 2)
        codePage = codePage << 8
        codePage = codePage + getHead(2, 3)
        cellWidth = getHead(2, 4)
        cellHeight = getHead(2, 5)
        codeWidth = getHead(2, 6)
        codeHeight = getHead(2, 7)
        codeUltraHigh = getHead(2, 8)
        cellBaseline = getHead(2, 9)
        SetRange(codePage, codeWidth, codeHeight)
    End Sub

    Private Sub mapRange()
        Dim i, j, k As Integer

        'For i = 0 To 255
        'codeL(i) = 0
        'codeH(i) = 0
        'Next

        k = 0
        For i = 0 To codeLowRange.Length - 1 Step 2
            For j = codeLowRange(i) To codeLowRange(i + 1)
                codeL(k) = j
                k = k + 1
            Next
        Next
        codeWidth = k
        k = 0
        For i = 0 To codeHighRange.Length - 1 Step 2
            For j = codeHighRange(i) To codeHighRange(i + 1)
                codeH(k) = j
                k = k + 1
            Next
        Next
        codeHeight = k
    End Sub

    Private Sub SetRange(cp, cw, ch)
        Select Case cp
            Case 1252
                codeLowRange = {0, 15}
                If ch = 8 Then
                    codeHighRange = {0, 7}
                Else
                    codeHighRange = {0, 15}
                End If
                codeLength = 1
            Case 1200
                codeLowRange = {0, 255}
                codeHighRange = {0, 255}
                codeLength = 2
            Case 12000
                codeLowRange = {0, 255}
                codeHighRange = {0, 255}
                codeLength = 4
            Case 936
                If ch <= 16 Then
                    codeLowRange = {0, 15}
                    codeHighRange = {0, 15}
                    codeLength = 1
                ElseIf ch <= &HFE - &HA1 + 1 Then
                    codeLowRange = {&HA1, &HFE}
                    codeHighRange = {&HA1, &HFE}
                    codeLength = 2
                Else
                    codeLowRange = {&H40, &H7E, &H80, &HFE}
                    codeHighRange = {&H81, &HFE}
                    codeLength = 2
                End If
            Case 950
                If ch <= 16 Then
                    codeLowRange = {0, 15}
                    codeHighRange = {0, 15}
                    codeLength = 1
                Else
                    codeLowRange = {&H40, &H7E, &HA1, &HFE}
                    codeHighRange = {&H81, &HFE}
                    codeLength = 2
                End If
            Case 932
                If ch <= 16 Then
                    codeLowRange = {0, 15}
                    codeHighRange = {0, 15}
                    codeLength = 1
                Else
                    codeLowRange = {&H40, &H7E, &H80, &HFC}
                    codeHighRange = {&H81, &H9F, &HE0, &HFC}
                    codeLength = 2
                End If
            Case Else
                codeLowRange = {0, in0255(cw)}
                codeHighRange = {0, in0255(ch)}
                codeLength = 2
        End Select

        mapRange()
    End Sub

    Private Function mapW(ByRef map()) As Integer
        mapW = 0
    End Function

    Private Sub cleanArea(sc As String, ec As String)
        Dim grpMain As Graphics = Graphics.FromImage(picMain.Image)
        Dim s As Integer = code2loc(sc)
        Dim e As Integer = code2loc(ec)
        If e < s Then
            Exit Sub
        End If
        Dim wb As New SolidBrush(Color.White)
        For j = 0 To codeHeight
            For i = 0 To codeWidth
                If j * codeWidth + i >= s And j * codeWidth + i <= e Then
                    grpMain.FillRectangle(wb, i * (cellWidth + 1), j * (cellHeight + 1), cellWidth, cellHeight)
                End If
            Next
        Next
        picMain.Update()
        picMain.Refresh()
    End Sub

    Private Sub drawHeadAndLine()
        ' draw Head
        Dim grpOutputHead As Graphics = Graphics.FromImage(bmpHead)
        grpOutputHead.FillRectangle(New SolidBrush(Color.White), 0, 0, 12, 12)
        grpOutputHead.DrawLine(Pens.Blue, 0, 12, 12, 12)
        grpOutputHead.DrawLine(Pens.Blue, 12, 0, 12, 12)
        picHead.Image = bmpHead
        picHead.Width = 13 ' * zoomInOut
        picHead.Height = 13 ' * zoomInOut
        printHead()
        picHead.Refresh()

        Dim grpOutputMain As Graphics = Graphics.FromImage(picMain.Image)

        newBitmap(bmpH, codeWidth * (cellWidth + 1), 13)
        Dim grpOutputH As Graphics = Graphics.FromImage(bmpH)
        grpOutputH.FillRectangle(New SolidBrush(Color.White), 0, 0, bmpH.Width, bmpH.Height)
        For i = 0 To codeWidth - 1
            grpOutputH.DrawLine(Pens.Blue, i * (cellWidth + 1) - 1, 0, i * (cellWidth + 1) - 1, 12)
            If (cellWidth >= 18) Then
                If codeLength >= 2 Then
                    grpOutputH.DrawImage(bmpDigitalL(Int(codeL(i) / 16)), 2 + i * (cellWidth + 1), 3)
                    grpOutputH.DrawImage(bmpDigitalL(codeL(i) Mod 16), 10 + i * (cellWidth + 1), 3)
                Else
                    grpOutputH.DrawImage(bmpDigitalL(codeL(i) Mod 16), 2 + i * (cellWidth + 1), 3)
                End If
            ElseIf (cellWidth >= 16) Then
                If codeLength >= 2 Then
                    grpOutputH.DrawImage(bmpDigitalL(Int(codeL(i) / 16)), 2 + i * (cellWidth + 1), 3)
                    grpOutputH.DrawImage(bmpDigitalL(codeL(i) Mod 16), 8 + i * (cellWidth + 1), 3)
                Else
                    grpOutputH.DrawImage(bmpDigitalL(codeL(i) Mod 16), 2 + i * (cellWidth + 1), 3)
                End If
            ElseIf (cellWidth >= 9) Then
                If codeLength >= 2 Then
                    grpOutputH.DrawImage(bmpDigitalS(Int(codeL(i) / 16)), 1 + i * (cellWidth + 1), 3)
                    grpOutputH.DrawImage(bmpDigitalS(codeL(i) Mod 16), 5 + i * (cellWidth + 1), 3)
                Else
                    grpOutputH.DrawImage(bmpDigitalL(codeL(i) Mod 16), 1 + i * (cellWidth + 1), 3)
                End If
            ElseIf (cellWidth >= 7) Then
                If codeLength >= 2 Then
                    grpOutputH.DrawImage(bmpDigitalS(Int(codeL(i) / 16)), 1 + i * (cellWidth + 1), 0)
                    grpOutputH.DrawImage(bmpDigitalS(codeL(i) Mod 16), 1 + i * (cellWidth + 1), 6)
                Else
                    grpOutputH.DrawImage(bmpDigitalL(codeL(i) Mod 16), 1 + i * (cellWidth + 1), 3)
                End If
            ElseIf (cellWidth >= 5) Then
                If codeLength >= 2 Then
                    grpOutputH.DrawImage(bmpDigitalS(Int(codeL(i) / 16)), 1 + i * (cellWidth + 1), 0)
                    grpOutputH.DrawImage(bmpDigitalS(codeL(i) Mod 16), 1 + i * (cellWidth + 1), 6)
                Else
                    grpOutputH.DrawImage(bmpDigitalS(codeL(i) Mod 16), 1 + i * (cellWidth + 1), 4)
                End If
            ElseIf (cellWidth >= 3) Then
                If codeLength >= 2 Then
                    grpOutputH.DrawImage(bmpDigitalS(Int(codeL(i) / 16)), i * (cellWidth + 1), 0)
                    grpOutputH.DrawImage(bmpDigitalS(codeL(i) Mod 16), i * (cellWidth + 1), 6)
                Else
                    grpOutputH.DrawImage(bmpDigitalS(codeL(i) Mod 16), i * (cellWidth + 1), 4)
                End If
            End If
            grpOutputMain.DrawLine(Pens.Blue, i * (cellWidth + 1) - 1, 0, i * (cellWidth + 1) - 1, codeHeight * (cellHeight + 1) - 1)
        Next
        grpOutputH.DrawLine(Pens.Blue, codeWidth * (cellWidth + 1) - 1, 0, codeWidth * (cellWidth + 1) - 1, 12)
        grpOutputMain.DrawLine(Pens.Blue, codeWidth * (cellWidth + 1) - 1, 0, codeWidth * (cellWidth + 1) - 1, codeHeight * (cellHeight + 1) - 1)
        grpOutputH.DrawLine(Pens.Blue, 0, 12, codeWidth * (cellWidth + 1) - 1, 12)
        If Not IsNothing(picH.Image) Then
            picH.Image.Dispose()
        End If
        picH.Image = bmpH
        picH.Width = codeWidth * (cellWidth + 1) ' * zoomInOut
        picH.Height = 13 '* zoomInOut
        picH.Refresh()

        newBitmap(bmpV, 13, codeHeight * (cellHeight + 1))
        Dim grpOutputV As Graphics = Graphics.FromImage(bmpV)
        grpOutputV.FillRectangle(New SolidBrush(Color.White), 0, 0, bmpV.Width, bmpV.Height)
        For i = 0 To codeHeight - 1
            grpOutputV.DrawLine(Pens.Blue, 0, i * (cellHeight + 1) - 1, 12, i * (cellHeight + 1) - 1)
            If (cellHeight >= 18) Then
                If codeLength >= 2 Then
                    grpOutputV.DrawImage(bmpDigitalL(Int(codeH(i) / 16)), 5, 2 + i * (cellHeight + 1))
                    grpOutputV.DrawImage(bmpDigitalL(codeH(i) Mod 16), 5, 10 + i * (cellHeight + 1))
                Else
                    grpOutputV.DrawImage(bmpDigitalL(codeH(i) Mod 16), 5, 2 + i * (cellHeight + 1))
                End If
            ElseIf (cellHeight >= 10) Then
                If codeLength >= 2 Then
                    grpOutputV.DrawImage(bmpDigitalL(Int(codeH(i) / 16)), 0, 2 + i * (cellHeight + 1))
                End If
                grpOutputV.DrawImage(bmpDigitalL(codeH(i) Mod 16), 6, 2 + i * (cellHeight + 1))
            ElseIf (cellHeight >= 8) Then
                If codeLength >= 2 Then
                    grpOutputV.DrawImage(bmpDigitalS(Int(codeH(i) / 16)), 2, 2 + i * (cellHeight + 1))
                End If
                grpOutputV.DrawImage(bmpDigitalS(codeH(i) Mod 16), 6, 2 + i * (cellHeight + 1))
            ElseIf (cellHeight >= 6) Then
                If codeLength >= 2 Then
                    grpOutputV.DrawImage(bmpDigitalS(Int(codeH(i) / 16)), 2, 1 + i * (cellHeight + 1))
                End If
                grpOutputV.DrawImage(bmpDigitalS(codeH(i) Mod 16), 6, 1 + i * (cellHeight + 1))
            End If
            grpOutputMain.DrawLine(Pens.Blue, 0, i * (cellHeight + 1) - 1, codeWidth * (cellWidth + 1) - 1, i * (cellHeight + 1) - 1)
        Next
        grpOutputV.DrawLine(Pens.Blue, 0, codeHeight * (cellHeight + 1) - 1, 12, codeHeight * (cellHeight + 1) - 1)
        grpOutputMain.DrawLine(Pens.Blue, 0, codeHeight * (cellHeight + 1) - 1, codeWidth * (cellWidth + 1) - 1, codeHeight * (cellHeight + 1) - 1)
        grpOutputV.DrawLine(Pens.Blue, 12, 0, 12, codeHeight * (cellHeight + 1) - 1)
        If Not IsNothing(picV.Image) Then
            picV.Image.Dispose()
        End If
        picV.Image = bmpV
        picV.Width = 13 '* zoomInOut
        picV.Height = codeHeight * (cellHeight + 1) '* zoomInOut
        picV.Refresh()

        bmpMain = picMain.Image
        picMain.Refresh()
    End Sub

    Private Sub createArray(cp As Integer, width As Integer, height As Integer)
        'SetRange(cp, width, height)
        cellWidth = width
        cellHeight = height
        newBitmap(bmpMain, codeWidth * (cellWidth + 1), codeHeight * (cellHeight + 1))
        Dim grp = Graphics.FromImage(bmpMain)
        grp.FillRectangle(New SolidBrush(Color.White), 0, 0, codeWidth * (cellWidth + 1), codeHeight * (cellHeight + 1))
        If Not IsNothing(picMain.Image) Then
            picMain.Image.Dispose()
        End If
        picMain.Image = bmpMain
        'picMain.Width = bmpMain.Width * zoomInOut
        'picMain.Height = bmpMain.Height * zoomInOut
        drawHeadAndLine()
        updateInfoData()
        updateActiveData()
    End Sub

    Private Sub NewFont(codepage_name As String, sizeW As Integer, sizeH As Integer)
        Select Case codepage_name
            Case "ASCII-7(1252)"
                codeLowRange = {0, 15}
                codeHighRange = {0, 7}
                codePage = 1252
                codeLength = 1
            Case "ASCII-8(1252)"
                codeLowRange = {0, 15}
                codeHighRange = {0, 15}
                codePage = 1252
                codeLength = 1
            Case "UnicodeUCS16(1200)"
                codeLowRange = {0, 255}
                codeHighRange = {0, 255}
                codePage = 1200
                codeLength = 2
            Case "ISO/IEC10646BMP(1200)"
                codeLowRange = {0, 255}
                codeHighRange = {0, 255}
                codePage = 1200
                codeLength = 2
            Case "ISO/IEC10646SMP(65005)"
                codeUltraHigh = 1
                codeLowRange = {0, 255}
                codeHighRange = {0, 255}
                codePage = 12000
                codeLength = 4
            Case "ISO/IEC10646SIP(65005)"
                codeUltraHigh = 2
                codeLowRange = {0, 255}
                codeHighRange = {0, 255}
                codePage = 12000
                codeLength = 4
            Case "ISO/IEC10646TIP(65005)"
                codeUltraHigh = 3
                codeLowRange = {0, 255}
                codeHighRange = {0, 255}
                codePage = 12000
                codeLength = 4
            Case "ISO/IEC10646-Fxxxx(65005)"
                codeUltraHigh = 15
                codeLowRange = {0, 255}
                codeHighRange = {0, 255}
                codePage = 12000
                codeLength = 4
            Case "GB2312双字节(936)"
                codeLowRange = {&HA1, &HFE}
                codeHighRange = {&HA1, &HFE}
                codePage = 936
                codeLength = 2
            Case "GBK双字节(936)"
                codeLowRange = {&H40, &H7E, &H80, &HFE}
                codeHighRange = {&H81, &HFE}
                codePage = 936
                codeLength = 2
            Case "GB18030双字节(936)"
                codeLowRange = {&H40, &H7E, &H80, &HFE}
                codeHighRange = {&H81, &HFE}
                codePage = 936
                codeLength = 2
            Case "GB18030单字节(936)"
                codeLowRange = {0, 15}
                codeHighRange = {0, 15}
                codePage = 936
                codeLength = 1
            Case "Big-5双字节(950)"
                codeLowRange = {&H40, &H7E, &HA1, &HFE}
                codeHighRange = {&H81, &HFE}
                codePage = 950
                codeLength = 2
            Case "Big-5单字节(950)"
                codeLowRange = {0, 15}
                codeHighRange = {0, 15}
                codePage = 950
                codeLength = 1
            Case "Shift-JIS双字节(932)"
                codeLowRange = {&H40, &H7E, &H80, &HFC}
                codeHighRange = {&H81, &H9F, &HE0, &HFC}
                codePage = 932
                codeLength = 2
            Case "Shift-JIS单字节(932)"
                codeLowRange = {0, 15}
                codeHighRange = {0, 15}
                codePage = 932
                codeLength = 1
            Case Else
                codeLowRange = {0, in0255(sizeW - 1)}
                codeHighRange = {0, in0255(sizeH - 1)}
                codePage = 0
                codeLength = 2
        End Select
        mapRange()

    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        NewFont(cboCodepage.SelectedItem, txtNewSizeW.Text, txtNewSizeH.Text)
        createArray(codePage, txtNewWidth.Text, txtNewHeight.Text)
        RedrawEditor()
    End Sub

    Private Sub picMain_Move(sender As Object, e As EventArgs) Handles picMain.Move
        picH.Left = picMain.Left
        picV.Top = picMain.Top
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim grpD = Graphics.FromImage(picMain.Image)
        If (currCellX >= 0 And currCellX < codeWidth) And (currCellY >= 0 And currCellY < codeHeight) Then
            grpD.DrawRectangle(New Pen(Color.Blue), currCellX * (cellWidth + 1) - 1, currCellY * (cellHeight + 1) - 1, cellWidth + 1, cellHeight + 1)
        End If
        picMain.Refresh()
        Select Case cboSaveFileType.Text
            Case ".hz.ww-hh"
                saveHZwwhh()
            Case ".HZCG6"
                saveHZ()
            Case ".CODE.PNG(多个)"
                savePNGs()
            Case ".SVG"
                saveSVG()
            Case ".CODE.SVG(多个)"
                saveSVGs()
            Case "RAW"
                saveRAW()
            Case ".TTX"
                saveFontXML()
            Case Else
                savePNG()
        End Select
        grpD.DrawRectangle(New Pen(Color.Red), currCellX * (cellWidth + 1) - 1, currCellY * (cellHeight + 1) - 1, cellWidth + 1, cellHeight + 1)
    End Sub
    Public Function iByte2(ByVal i As Integer) As Byte()
        Dim btemp() As Byte = {0, 0}
        Dim b() As Byte = BitConverter.GetBytes(i)
        btemp(0) = b(0)
        btemp(1) = b(1)
        Return btemp
    End Function

    Public Function iByte4(ByVal i As Integer) As Byte()
        Dim btemp() As Byte = {0, 0, 0, 0}
        Dim b() As Byte = BitConverter.GetBytes(i)
        btemp(0) = b(0)
        btemp(1) = b(1)
        btemp(2) = b(2)
        btemp(3) = b(3)
        Return btemp
    End Function

    Private Sub saveHZwwhh()
        Try
            bmpMain = picMain.Image

            Dim FS As New System.IO.FileStream(txtSaveImagePath.Text & "\" & txtSaveImage.Text & ".hz." & Str(cellWidth).Trim() & "-" & Str(cellHeight).Trim(), IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.Write)
            Dim Bw As New System.IO.BinaryWriter(FS)

            Dim s = "%%/UNICODE_CIDCMAP DefCMapName /G /GBK_CIDCMAP 0  null CreateRasterFont "
            Dim bHeader = System.Text.Encoding.UTF8.GetBytes(s)
            Bw.Write(bHeader)
            Dim HGRF(30) As Byte
            HGRF = {&H48, &H47, &H52, &H46,
                    0, 0, 0, 0,
                    cellWidth, 0, cellHeight, 0,
                    0, 0, 1, 0,
                    1, 0, 0, 0,
                    cellWidth, 0, 0, 0,
                    0, 0, 0, 0, 0, 0}
            Bw.Write(HGRF)
            Dim i, j, k, l As Integer
            Dim d As Byte
            Dim add As Integer
            add = HGRF.Length + 6 * 65536
            Dim blocksize = cellWidth * cellHeight / 8
            For j = HexStrToLong(txtCodeRangeStart.Text) To HexStrToLong(txtCodeRangeEnd.Text)
                Bw.Write(iByte2(blocksize))
                Bw.Write(iByte4(add))
                add += blocksize
            Next

            Dim c As Color
            Bw.Seek(bHeader.Length + HGRF.Length + 6 * 65536, IO.SeekOrigin.Begin)
            Dim max = HexStrToLong(txtCodeRangeEnd.Text)
            Dim min = HexStrToLong(txtCodeRangeStart.Text)
            For j = Int(min / 256) To Int(max / 256)
                For i = 0 To 255
                    If (j * 256 + i) <= max And (j * 256 + i) >= min Then
                        For k = 0 To cellHeight - 1
                            For l = 0 To cellWidth - 1
                                c = bmpMain.GetPixel(i * (cellWidth + 1) + l, j * (cellHeight + 1) + k)
                                If (c.R * 9 + c.G * 19 + c.B * 4 >> 5) < 128 And c.A > 128 Then
                                    d += (1 << (7 - (l Mod 8)))
                                End If
                                If ((l + 1) Mod 8) = 0 Then
                                    'write to file
                                    Bw.Write(d)
                                    d = 0
                                End If
                            Next
                            If (cellWidth Mod 8) <> 0 Then
                                'writetofile
                                Bw.Write(d)
                                d = 0
                            End If
                        Next
                    End If
                Next
            Next

            FS.Close()
        Catch ex2 As Exception
            MessageBox.Show("Error on save HZ file : " & ex2.Message)
        End Try
    End Sub

    Private Sub saveHZ()
        Try
            bmpMain = picMain.Image

            Dim FS As New System.IO.FileStream(txtSaveImagePath.Text & "\" & txtSaveImage.Text, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.Write)
            Dim Bw As New System.IO.BinaryWriter(FS)

            Dim i, j, k, l
            Dim c As Color
            Dim d As Byte
            For j = HexStrToLong(txtCodeRangeStart.Text) To HexStrToLong(txtCodeRangeEnd.Text)
                For i = 0 To codeWidth - 1
                    For k = 0 To cellHeight - 1
                        For l = 0 To cellWidth - 1
                            c = bmpMain.GetPixel(i * (cellWidth + 1) + l, j * (cellHeight + 1) + k)
                            If (c.R * 9 + c.G * 19 + c.B * 4 >> 5) < 128 And c.A > 128 Then
                                d += (1 << (7 - (l Mod 8)))
                            End If
                            If ((l + 1) Mod 8) = 0 Then
                                'write to file
                                Bw.Write(d)
                                d = 0
                            End If
                        Next
                        If (cellWidth Mod 8) <> 0 Then
                            'writetofile
                            Bw.Write(d)
                            d = 0
                        End If
                    Next
                Next
            Next
            FS.Close()
        Catch ex2 As Exception
            MessageBox.Show("Error on save HZ file : " & ex2.Message)
        End Try
    End Sub
    Private Sub saveRAW()
        Try
            bmpMain = picMain.Image

            Dim FS As New System.IO.FileStream(txtSaveImagePath.Text & "\" & txtSaveImage.Text, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.Write)
            Dim Bw As New System.IO.BinaryWriter(FS)

            Dim i, j, k, l
            Dim c As Color
            Dim d As Byte
            startProgress(codeHeight)
            For j = 0 To codeHeight - 1
                For i = 0 To codeWidth - 1
                    For k = 0 To cellHeight - 1
                        For l = 0 To cellWidth - 1
                            c = bmpMain.GetPixel(i * (cellWidth + 1) + l, j * (cellHeight + 1) + k)
                            If (c.R * 9 + c.G * 19 + c.B * 4 >> 5) < 128 And c.A > 128 Then
                                d += (1 << (7 - (l Mod 8)))
                            End If
                            If ((l + 1) Mod 8) = 0 Then
                                'write to file
                                Bw.Write(d)
                                d = 0
                            End If
                        Next
                        If (cellWidth Mod 8) <> 0 Then
                            'writetofile
                            Bw.Write(d)
                            d = 0
                        End If
                    Next
                Next
                goProgress(j + 1)
            Next
            endProgress()
            FS.Close()
        Catch ex2 As Exception
            MessageBox.Show("Error on save RAW file : " & ex2.Message)
            endProgress()
        End Try
    End Sub

    Private Sub savePNGs()
        'picSave.Visible = False
        'picSave.Width = cellWidth
        'picSave.Height = cellHeight
        Dim srcSize As Rectangle
        srcSize.Width = cellWidth
        srcSize.Height = cellHeight
        Dim bmpSave As New Bitmap(cellWidth, cellHeight)
        Dim grpSave As Graphics = Graphics.FromImage(bmpSave)
        For j = 0 To codeHeight - 1
            For i = 0 To codeWidth - 1
                srcSize.X = i * (cellWidth + 1)
                srcSize.Y = j * (cellHeight + 1)
                grpSave.DrawImageUnscaled(picMain.Image, srcSize)
                Try
                    bmpSave.Save(txtSaveImagePath.Text & "\" & txtSaveImage.Text & "." & hexstr(j, codeLength / 2) & hexstr(i, codeLength / 2) & ".FONT.PNG")
                Catch ex As Exception

                End Try
            Next
        Next
        bmpSave.Dispose()
    End Sub

    Private Sub savePNG()
        Dim bmpSave As New Bitmap(picHead.Image.Width + picMain.Image.Width, picHead.Image.Height + picMain.Image.Height)
        Dim grpSave As Graphics = Graphics.FromImage(bmpSave)
        '.Clone(New Rectangle(13, 13, bmpFont.Width - 13, bmpFont.Height - 13), Imaging.PixelFormat.DontCare)
        grpSave.DrawImage(picHead.Image, 0, 0, 13, 13)
        grpSave.DrawImageUnscaled(picH.Image, 13, 0)
        grpSave.DrawImageUnscaled(picV.Image, 0, 13)
        grpSave.DrawImageUnscaledAndClipped(picMain.Image, New Rectangle(13, 13, picMain.Image.Width, picMain.Image.Height))
        Try
            Dim fn = txtSaveImagePath.Text & "\" & txtSaveImage.Text & ".FONT.png"
            bmpSave.Save(fn)
            picMain.Image.Save(fn & ".png")
            bmpSave.Dispose()
        Catch ex As Exception
            MessageBox.Show("error save:" & ex.Message)
        End Try
    End Sub

    Private Function loc2code(x, y) As String
        Dim l As Integer
        If codeLength >= 2 Then
            l = 2
        Else
            l = 1
        End If
        loc2code = hexstr(codeH(y), l) & hexstr(codeL(x), l)
    End Function

    Private Sub saveSVG()
        '    Dim oldType = cboCopyType.Text
        '      Dim oldX = currCellX
        '     Dim oldY = currCellY
        '       cboCopyType.Text = "SVG"
        Dim i, j
        Dim s As String
        Dim svg_def As String = ""
        Dim svg_use As String = ""

        Dim FS As New System.IO.FileStream(txtSaveImagePath.Text & "\" & txtSaveImage.Text & ".SVG", IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.Write)
        startProgress(codeHeight)
        For j = 0 To codeHeight - 1
            For i = 0 To codeWidth - 1
                'currCellX = i
                'currCellY = j
                'RedrawEditor()
                svg_def = svg_def & bmp2svg_g(picMain.Image, loc2code(i, j), chkGrid.Checked, chkRound.Checked, chkGap.Checked)
                svg_use = svg_use & "<use x=""" & i * (cellWidth + 1) * 10 & """ y=""" & j * (cellHeight + 1) * 10 &
                                    """ width=""" & cellWidth * 10 & """ height=""" & cellHeight * 10 &
                                    """ xlink:href=""#code" & loc2code(i, j) & """ />" & vbCrLf
            Next
            goProgress(j + 1)
        Next
        endProgress()

        svg_def = "<defs>" & svg_def & "</defs>"
        svg_use = "<g style=""display:inline"">" & svg_use & "</g>"
        s = "<?xml version=""1.0"" encoding=""UTF-8"" standalone=""no""?>" & vbCrLf & "<svg xmlns=""http://www.w3.org/2000/svg""" & vbCrLf
        Dim w = (cellWidth + 1) * (codeWidth) * 10
        Dim h = (cellHeight + 1) * (codeHeight) * 10
        s = s & " enable-background=""New 0 0 " & w & " " & h & """" & vbCrLf
        s = s & " width=""" & w & """ height=""" & h & """ viewBox=""0 0 " & w & " " & h & """ "
        s = s & " xmlns:xlink=""http://www.w3.org/1999/xlink"">" & vbCrLf
        s = s & svg_def & vbCrLf
        s = s & svg_use & vbCrLf
        s = s & "</svg>"

        Dim b = System.Text.Encoding.UTF8.GetBytes(s)
        FS.Write(b, 0, UBound(b) + 1)
        FS.Close()

        '        currCellX = oldX
        '       currCellY = oldY
        '      cboCopyType.Text = oldType

        RedrawEditor()
    End Sub

    Private Sub saveSVGs()
        Dim oldType = cboCopyType.Text
        '        Dim oldX = currCellX
        '      Dim oldY = currCellY
        cboCopyType.Text = "SVG"
        Dim i, j
        Dim s As String
        startProgress(codeHeight)
        For j = 0 To codeHeight - 1
            For i = 0 To codeWidth - 1
                '                currCellX = i
                '               currCellY = j
                '              RedrawEditor()
                Dim FS As New System.IO.FileStream(txtSaveImagePath.Text & "\" & txtSaveImage.Text & "." & hexstr(j, codeLength) & hexstr(i, codeLength) & ".SVG", IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.Write)
                s = bmp2svgtext(picMain.Image, loc2code(i, j), chkGrid.Checked, chkRound.Checked)
                Dim b = System.Text.Encoding.UTF8.GetBytes(s)
                FS.Write(b, 0, UBound(b) + 1)
                FS.Close()
            Next
            goProgress(j + 1)
        Next
        endProgress()

        '    currCellX = oldX
        '  currCellY = oldY
        cboCopyType.Text = oldType

        RedrawEditor()
    End Sub

    Private Function bmp2fontxmltext(bmp As Bitmap, x As Integer, y As Integer) As String
        Dim grid, gap, round As Boolean
        gap = chkGap.Checked
        grid = chkGrid.Checked
        round = chkRound.Checked

        Dim xd As XmlDocument = New XmlDocument()
        Dim declar = xd.CreateXmlDeclaration("1.0", "UTF-8", "no")
        xd.AppendChild(declar)
        Dim ttFont = xd.CreateElement("ttFont")
        ttFont.SetAttribute("sfntVersion", "\x00\x01\x00\x00")
        ttFont.SetAttribute("ttLibVersion", "4.38")
        Dim GlyphOrder = xd.CreateElement("GlyphOrder")
        Dim hmtx = xd.CreateElement("hmtx")
        Dim cmap = xd.CreateElement("cmap")
        Dim i
        For i = 0 To 10

            Dim GlyphID = xd.CreateElement("GlyphID")
            GlyphID.SetAttribute("name", "char" & Str(i))
            GlyphOrder.AppendChild(GlyphID)

            Dim mtx = xd.CreateElement("mtx")
            mtx.SetAttribute("name", "char" & Str(i))
            mtx.SetAttribute("width", "")
            mtx.SetAttribute("lsb", "0")
            hmtx.AppendChild(mtx)

        Next
        ttFont.AppendChild(GlyphOrder)
        xd.AppendChild(ttFont)

        MessageBox.Show(xd.OuterXml())

        bmp2fontxmltext = xd.ToString()
    End Function

    Private Sub xmlAddNodeValue(ByRef xd As XmlDocument, ByRef pnode As XmlElement, nodename As String, nodevalue As String)
        Dim xmlnode = xd.CreateElement(nodename)
        xmlnode.SetAttribute("value", nodevalue)
        pnode.AppendChild(xmlnode)
    End Sub

    Private Sub xmlAddNamerecord(ByRef xd As XmlDocument, ByRef pnode As XmlElement, id As Integer, data As String)
        Dim namerecord = xd.CreateElement("namerecord")
        namerecord.SetAttribute("nameID", id)
        namerecord.SetAttribute("platformID", 1)
        namerecord.SetAttribute("platEncID", 0)
        namerecord.SetAttribute("langID", "0x0")
        namerecord.SetAttribute("unicode", "True")
        namerecord.InnerText = data
        pnode.AppendChild(namerecord)
    End Sub


    Private Sub saveFontXML()
        Dim i, j, k, l As Integer
        Dim c As Color
        Dim grid, gap, round As Integer

        startProgress(codeHeight)

        Dim xd As XmlDocument = New XmlDocument()
        Dim declar = xd.CreateXmlDeclaration("1.0", "UTF-8", "no")
        xd.AppendChild(declar)
        Dim ttFont = xd.CreateElement("ttFont")
        ttFont.SetAttribute("sfntVersion", "\x00\x01\x00\x00")
        ttFont.SetAttribute("ttLibVersion", "4.38")
        Dim GlyphOrder = xd.CreateElement("GlyphOrder")

        Dim head = xd.CreateElement("head")
        xmlAddNodeValue(xd, head, "tableVersion", "1.0")
        xmlAddNodeValue(xd, head, "fontRevision", "1.0")
        xmlAddNodeValue(xd, head, "checkSumAdjustment", 0)
        xmlAddNodeValue(xd, head, "magicNumber", "0x5F0F3CF5")
        xmlAddNodeValue(xd, head, "flags", "00000000 00000000")
        xmlAddNodeValue(xd, head, "unitsPerEm", cellWidth * 10)
        xmlAddNodeValue(xd, head, "created", "Tue Jun 28 00:12:30 2011")
        xmlAddNodeValue(xd, head, "modified", "Tue Jun 28 00:12:30 2011")
        xmlAddNodeValue(xd, head, "xMin", 0)
        xmlAddNodeValue(xd, head, "yMin", 0)
        xmlAddNodeValue(xd, head, "xMax", cellWidth * 10)
        xmlAddNodeValue(xd, head, "yMax", cellHeight * 10)
        xmlAddNodeValue(xd, head, "macStyle", "00000000 00000000")
        xmlAddNodeValue(xd, head, "lowestRecPPEM", 8)
        xmlAddNodeValue(xd, head, "fontDirectionHint", 2)
        xmlAddNodeValue(xd, head, "indexToLocFormat", 1)
        xmlAddNodeValue(xd, head, "glyphDataFormat", 0)

        Dim hhea = xd.CreateElement("hhea")
        xmlAddNodeValue(xd, hhea, "tableVersion", "0x00010000")
        xmlAddNodeValue(xd, hhea, "ascent", cellWidth * 10)
        xmlAddNodeValue(xd, hhea, "descent", -cellWidth * 3)
        xmlAddNodeValue(xd, hhea, "lineGap", 0)
        xmlAddNodeValue(xd, hhea, "advanceWidthMax", cellWidth * 10)
        xmlAddNodeValue(xd, hhea, "minLeftSideBearing", -cellWidth)
        xmlAddNodeValue(xd, hhea, "minRightSideBearing", cellWidth)
        xmlAddNodeValue(xd, hhea, "xMaxExtent", cellWidth * 10)
        xmlAddNodeValue(xd, hhea, "caretSlopeRise", 1)
        xmlAddNodeValue(xd, hhea, "caretSlopeRun", 0)
        xmlAddNodeValue(xd, hhea, "caretOffset", 0)
        xmlAddNodeValue(xd, hhea, "reserved0", 0)
        xmlAddNodeValue(xd, hhea, "reserved1", 0)
        xmlAddNodeValue(xd, hhea, "reserved2", 0)
        xmlAddNodeValue(xd, hhea, "reserved3", 0)
        xmlAddNodeValue(xd, hhea, "metricDataFormat", 0)
        xmlAddNodeValue(xd, hhea, "numberOfHMetrics", codeWidth * codeHeight)

        Dim maxp = xd.CreateElement("maxp")
        xmlAddNodeValue(xd, maxp, "tableVersion", "0x10000")
        xmlAddNodeValue(xd, maxp, "numGlyphs", codeWidth * codeHeight)
        xmlAddNodeValue(xd, maxp, "maxPoints", codeWidth * codeHeight)
        xmlAddNodeValue(xd, maxp, "maxContours", cellWidth * cellHeight)
        xmlAddNodeValue(xd, maxp, "maxCompositePoints", 0)
        xmlAddNodeValue(xd, maxp, "maxCompositeContours", 0)
        xmlAddNodeValue(xd, maxp, "maxZones", 2)
        xmlAddNodeValue(xd, maxp, "maxTwilightPoints", 0)
        xmlAddNodeValue(xd, maxp, "maxStorage", 0)
        xmlAddNodeValue(xd, maxp, "maxFunctionDefs", 0)
        xmlAddNodeValue(xd, maxp, "maxInstructionDefs", 0)
        xmlAddNodeValue(xd, maxp, "maxStackElements", 0)
        xmlAddNodeValue(xd, maxp, "maxSizeOfInstructions", 0)
        xmlAddNodeValue(xd, maxp, "maxComponentElements", 0)
        xmlAddNodeValue(xd, maxp, "maxComponentDepth", 0)

        Dim os2 = xd.CreateElement("OS_2")
        xmlAddNodeValue(xd, os2, "version", 2)
        xmlAddNodeValue(xd, os2, "xAvgCharWidth", cellWidth * 10)
        xmlAddNodeValue(xd, os2, "usWeightClass", cellHeight * 10)
        xmlAddNodeValue(xd, os2, "usWidthClass", 5)
        xmlAddNodeValue(xd, os2, "fsType", "00000000 00000100")
        xmlAddNodeValue(xd, os2, "ySubscriptXSize", cellWidth * 5)
        xmlAddNodeValue(xd, os2, "ySubscriptYSize", cellHeight * 5)
        xmlAddNodeValue(xd, os2, "ySubscriptXOffset", 0)
        xmlAddNodeValue(xd, os2, "ySubscriptYOffset", 0)
        xmlAddNodeValue(xd, os2, "ySuperscriptXSize", cellWidth * 5)
        xmlAddNodeValue(xd, os2, "ySuperscriptYSize", cellHeight * 5)
        xmlAddNodeValue(xd, os2, "ySuperscriptXOffset", 0)
        xmlAddNodeValue(xd, os2, "ySuperscriptYOffset", cellHeight * 5)
        xmlAddNodeValue(xd, os2, "yStrikeoutSize", 51)
        xmlAddNodeValue(xd, os2, "yStrikeoutPosition", 204)
        xmlAddNodeValue(xd, os2, "sFamilyClass", 0)
        Dim panose = xd.CreateElement("panose")
        xmlAddNodeValue(xd, panose, "bFamilyType", 2)
        xmlAddNodeValue(xd, panose, "bSerifStyle", 0)
        xmlAddNodeValue(xd, panose, "bWeight", 4)
        xmlAddNodeValue(xd, panose, "bProportion", 0)
        xmlAddNodeValue(xd, panose, "bContrast", 0)
        xmlAddNodeValue(xd, panose, "bStrokeVariation", 0)
        xmlAddNodeValue(xd, panose, "bArmStyle", 0)
        xmlAddNodeValue(xd, panose, "bLetterForm", 0)
        xmlAddNodeValue(xd, panose, "bMidline", 0)
        xmlAddNodeValue(xd, panose, "bXHeight", 0)
        os2.AppendChild(panose)
        xmlAddNodeValue(xd, os2, "ulUnicodeRange1", "00000000 00000000 00000000 00000001")
        xmlAddNodeValue(xd, os2, "ulUnicodeRange2", "00000000 00000000 00000000 00000000")
        xmlAddNodeValue(xd, os2, "ulUnicodeRange3", "00000000 00000000 00000000 00000000")
        xmlAddNodeValue(xd, os2, "ulUnicodeRange4", "00000000 00000000 00000000 00000000")
        xmlAddNodeValue(xd, os2, "achVendID", "BMPF")
        xmlAddNodeValue(xd, os2, "fsSelection", "00000000 01000000")
        xmlAddNodeValue(xd, os2, "usFirstCharIndex", &H20)
        xmlAddNodeValue(xd, os2, "usLastCharIndex", 255)
        xmlAddNodeValue(xd, os2, "sTypoAscender", cellHeight * 5)
        xmlAddNodeValue(xd, os2, "sTypoDescender", 0)
        xmlAddNodeValue(xd, os2, "sTypoLineGap", 0)
        xmlAddNodeValue(xd, os2, "usWinAscent", cellHeight * 10)
        xmlAddNodeValue(xd, os2, "usWinDescent", cellHeight * 2)
        xmlAddNodeValue(xd, os2, "ulCodePageRange1", "00000000 00000000 00000000 00000001")
        xmlAddNodeValue(xd, os2, "ulCodePageRange2", "00000000 00000000 00000000 00000000")
        xmlAddNodeValue(xd, os2, "sxHeight", cellHeight * 10)
        xmlAddNodeValue(xd, os2, "sCapHeight", cellHeight * 10)
        xmlAddNodeValue(xd, os2, "usDefaultChar", 0)
        xmlAddNodeValue(xd, os2, "usBreakChar", 32)
        xmlAddNodeValue(xd, os2, "usMaxContext", 0)

        Dim hmtx = xd.CreateElement("hmtx")
        Dim cmap = xd.CreateElement("cmap")
        Dim cmap_tableVersion = xd.CreateElement("tableVersion")
        cmap_tableVersion.SetAttribute("version", 0)
        cmap.AppendChild(cmap_tableVersion)
        Dim cmap_format_4_1 = xd.CreateElement("cmap_format_4")
        cmap_format_4_1.SetAttribute("platformID", 0)
        cmap_format_4_1.SetAttribute("platEncID", 3)
        cmap_format_4_1.SetAttribute("language", 0)
        Dim cmap_format_4_2 = xd.CreateElement("cmap_format_4")
        cmap_format_4_2.SetAttribute("platformID", 3)
        cmap_format_4_2.SetAttribute("platEncID", 1)
        cmap_format_4_2.SetAttribute("language", 0)
        Dim glyf = xd.CreateElement("glyf")
        Dim bmp As Bitmap = picMain.Image
        For j = 0 To codeHeight - 1
            For i = 0 To codeWidth - 1
                Dim GlyphID = xd.CreateElement("GlyphID")
                GlyphID.SetAttribute("name", "char" & loc2code(i, j))
                GlyphOrder.AppendChild(GlyphID)

                Dim mtx = xd.CreateElement("mtx")
                mtx.SetAttribute("name", "char" & loc2code(i, j))
                mtx.SetAttribute("width", cellWidth * 10)
                mtx.SetAttribute("lsb", "0")
                hmtx.AppendChild(mtx)

                Dim map = xd.CreateElement("map")
                map.SetAttribute("name", "char" & loc2code(i, j))
                map.SetAttribute("code", "0x" & loc2code(i, j))
                cmap_format_4_1.AppendChild(map)
                cmap_format_4_2.AppendChild(map.Clone)

                Dim TTGlyph = xd.CreateElement("TTGlyph")
                TTGlyph.SetAttribute("name", "char" & loc2code(i, j))
                TTGlyph.SetAttribute("xMin", "0")
                TTGlyph.SetAttribute("yMin", "0")
                TTGlyph.SetAttribute("xMax", cellWidth * 10)
                TTGlyph.SetAttribute("yMax", cellHeight * 10)

                If chkGap.Checked Then
                    gap = 1
                Else
                    gap = 0
                End If
                For k = 0 To cellHeight - 1
                    For l = 0 To cellWidth - 1
                        c = bmp.GetPixel(i * (cellWidth + 1) + l, j * (cellHeight + 1) + k)
                        If (c.R * 9 + c.G * 19 + c.B * 4 >> 5) < 128 And c.A > 128 Then
                            Dim contour = xd.CreateElement("contour")
                            Dim pt1 = xd.CreateElement("pt")
                            pt1.SetAttribute("x", l * 10 + 10 - gap)
                            pt1.SetAttribute("y", cellHeight * 7 - k * 10 + gap)
                            pt1.SetAttribute("on", "1")
                            contour.AppendChild(pt1)
                            Dim pt2 = xd.CreateElement("pt")
                            pt2.SetAttribute("x", l * 10 + 10 - gap)
                            pt2.SetAttribute("y", cellHeight * 7 - k * 10 + 10 - gap)
                            pt2.SetAttribute("on", "1")
                            contour.AppendChild(pt2)
                            Dim pt3 = xd.CreateElement("pt")
                            pt3.SetAttribute("x", l * 10 + gap)
                            pt3.SetAttribute("y", cellHeight * 7 - k * 10 + 10 - gap)
                            pt3.SetAttribute("on", "1")
                            contour.AppendChild(pt3)
                            Dim pt4 = xd.CreateElement("pt")
                            pt4.SetAttribute("x", l * 10 + gap)
                            pt4.SetAttribute("y", cellHeight * 7 - k * 10 + gap)
                            pt4.SetAttribute("on", "1")
                            contour.AppendChild(pt4)
                            TTGlyph.AppendChild(contour)
                        End If
                    Next
                Next
                Dim instructions = xd.CreateElement("instructions")
                TTGlyph.AppendChild(instructions)
                glyf.AppendChild(TTGlyph)
            Next
            goProgress(j + 1)
        Next
        cmap.AppendChild(cmap_format_4_1)
        cmap.AppendChild(cmap_format_4_2)

        ttFont.AppendChild(GlyphOrder)
        ttFont.AppendChild(head)
        ttFont.AppendChild(hhea)
        ttFont.AppendChild(maxp)
        ttFont.AppendChild(os2)
        ttFont.AppendChild(hmtx)
        ttFont.AppendChild(cmap)
        Dim loca = xd.CreateElement("loca")
        ttFont.AppendChild(loca)
        ttFont.AppendChild(glyf)

        Dim _name = xd.CreateElement("name")
        xmlAddNamerecord(xd, _name, "0", "Copyright Chanhsin 2024") 'copyright
        xmlAddNamerecord(xd, _name, "1", txtSaveImage.Text) ' font name
        xmlAddNamerecord(xd, _name, "2", "Regular") ' font type
        xmlAddNamerecord(xd, _name, "3", "BMPFont " & txtSaveImage.Text) ' font name full
        xmlAddNamerecord(xd, _name, "4", txtSaveImage.Text & " Regular") ' font type full
        xmlAddNamerecord(xd, _name, "5", "Version 1.0") ' version
        xmlAddNamerecord(xd, _name, "6", txtSaveImage.Text) ' font name
        xmlAddNamerecord(xd, _name, "7", "BMPFont, is a tool from Chanhsin") ' builder note
        xmlAddNamerecord(xd, _name, "8", "http://github") ' builder url
        xmlAddNamerecord(xd, _name, "9", "Chanhsin") ' builder name
        xmlAddNamerecord(xd, _name, "10", txtSaveImage.Text & " was build with BMPFont") ' builder name
        ttFont.AppendChild(_name)

        Dim post = xd.CreateElement("post")
        xmlAddNodeValue(xd, post, "formatType", "3.0")
        xmlAddNodeValue(xd, post, "italicAngle", "0.0")
        xmlAddNodeValue(xd, post, "underlinePosition", "102")
        xmlAddNodeValue(xd, post, "underlineThickness", "51")
        xmlAddNodeValue(xd, post, "isFixedPitch", "0")
        xmlAddNodeValue(xd, post, "minMemType42", "0")
        xmlAddNodeValue(xd, post, "maxMemType42", "0")
        xmlAddNodeValue(xd, post, "minMemType1", "0")
        xmlAddNodeValue(xd, post, "maxMemType1", "0")
        ttFont.AppendChild(post)

        xd.AppendChild(ttFont)
        xd.Save(txtSaveImagePath.Text & "\" & txtSaveImage.Text & ".TTX")
        endProgress()
    End Sub

    Private Sub newBitmap(ByRef bmp As Bitmap, w As Integer, h As Integer)
        If IsNothing(bmp) = False Then
            bmp.Dispose()
        End If
        bmp = New Bitmap(w, h)
    End Sub

    Private Sub importFontPNG()
        Try
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(txtImportFileName.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read)
            picHead.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            Dim bmpFont As Bitmap = picHead.Image
            newBitmap(bmpV, 13, picHead.Image.Height - 13)
            newBitmap(bmpH, picHead.Image.Width - 13, 13)
            newBitmap(bmpMain, picHead.Image.Width - 13, picHead.Image.Height - 13)
            bmpMain = bmpFont.Clone(New Rectangle(13, 13, bmpFont.Width - 13, bmpFont.Height - 13), Imaging.PixelFormat.DontCare)
            picMain.Image = bmpMain
            picMain.Width = bmpMain.Width
            picMain.Height = bmpMain.Height
            bmpV = bmpFont.Clone(New Rectangle(0, 13, 13, bmpFont.Height - 13), Imaging.PixelFormat.DontCare)
            picV.Image = bmpV
            picV.Height = bmpV.Height
            bmpH = bmpFont.Clone(New Rectangle(13, 0, bmpFont.Width - 13, 13), Imaging.PixelFormat.DontCare)
            picH.Image = bmpH
            picH.Width = bmpH.Width
            bmpHead = bmpFont.Clone(New Rectangle(0, 0, 13, 13), Imaging.PixelFormat.DontCare)
            picHead.Image.Dispose()
            picHead.Image = bmpHead
            readHead()

            updateInfoData()
            updateActiveData()
        Catch ex As Exception

        End Try
    End Sub

    Private Function code2locX(cd As String) As Integer
        Dim c As Integer
        code2locX = 0
        If cd.Length >= 4 Then
            c = HexStrToLong(cd.Substring(cd.Length - 2, 2))
        ElseIf cd.Length = 2 Then
            c = HexStrToLong(cd.Substring(cd.Length - 1, 1))
        Else
            Exit Function
        End If
        Dim i As Integer
        For i = 0 To codeWidth - 1
            If codeL(i) = c Then
                code2locX = i
            End If
        Next
    End Function
    Private Function code2locY(cd As String) As Integer
        Dim c As Integer
        code2locY = 0
        If cd.Length >= 4 Then
            c = HexStrToLong(cd.Substring(cd.Length - 4, 2))
        ElseIf cd.Length = 2 Then
            c = HexStrToLong(cd.Substring(cd.Length - 2, 1))
        Else
            Exit Function
        End If
        Dim i As Integer
        For i = 0 To codeHeight - 1
            If codeH(i) = c Then
                code2locY = i
            End If
        Next
    End Function
    Private Function code2loc(cd As String) As Integer
        Dim x = code2locX(cd)
        Dim y = code2locY(cd)
        code2loc = y * codeWidth + x
    End Function

    Private Sub insertRAW(st As String, ed As String)
        Try
            Dim FS As New System.IO.FileStream(txtImportFileName.Text, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            Dim Bw As New System.IO.BinaryReader(FS)
            Dim readBs As Byte()
            Dim bmp = New Bitmap(cellWidth, cellHeight)

            FS.Seek(txtImportOffset.Text, IO.SeekOrigin.Begin)
            Dim widthBytes As Integer = Int((cellWidth + 7) / 8)
            Dim c1 As Color
            Dim c0 As Color
            If chkInverse.Checked = False Then
                c1 = Color.Black
                c0 = Color.White
            Else
                c1 = Color.White
                c0 = Color.Black
            End If
            printHead()
            Dim grpMain As Graphics = Graphics.FromImage(picMain.Image)
            Dim startLoc = code2loc(st)
            Dim endloc = code2loc(ed)
            If endloc <= startLoc Then
                endloc = 65536
            End If
            startProgress(codeHeight)
            For t = 0 To codeHeight - 1
                For l = 0 To codeWidth - 1
                    If t * codeWidth + l >= startLoc And t * codeWidth + 1 <= endloc Then
                        readBs = Bw.ReadBytes(widthBytes * cellHeight)
                        If readBs.Length < widthBytes * cellHeight - 1 Then
                            If codePage = 0 Then
                                codeHeight = t + 1
                                codeHighRange(1) = codeHeight - 1
                                Dim bmpOldMain As Bitmap = picMain.Image
                                Dim h As Integer = (t + 1) * (cellHeight + 1)
                                Dim bmpNew As Bitmap = New Bitmap(bmpOldMain.Width, h)
                                bmpNew = bmpOldMain.Clone(New Rectangle(0, 0, bmpNew.Width, bmpNew.Height), Imaging.PixelFormat.DontCare)
                                bmpOldMain.Dispose()
                                bmpMain = bmpNew
                                picMain.Image = bmpMain
                                picMain.Height = h
                                picMain.Refresh()
                                Dim bmpOldV As Bitmap = picV.Image
                                Dim bmpNewV As Bitmap = New Bitmap(bmpOldV.Width, h)
                                bmpNewV = bmpOldV.Clone(New Rectangle(0, 0, bmpNewV.Width, bmpNewV.Height), Imaging.PixelFormat.DontCare)
                                picV.Image = bmpNewV
                                picV.Height = h
                                bmpOldV.Dispose()
                                picV.Refresh()
                                printHead()
                            End If
                            picMain.Refresh()
                            FS.Close()
                            Exit Sub
                        End If
                        For j = 0 To (readBs.Length + 1) / widthBytes - 1 ' height - 1
                            For i = 0 To cellWidth - 1 'widthBytes * 8 - 1
                                If (j * widthBytes + Int(i / 8)) < readBs.Length Then
                                    If ((readBs(j * widthBytes + Int(i / 8)) >> (7 - (i Mod 8))) Mod 2) = 1 Then
                                        If chkBigEndding.Checked Then
                                            bmp.SetPixel(Int(i / 8) * 8 + 7 - (i Mod 8), j, c1)
                                        Else
                                            bmp.SetPixel(i, j, c1)
                                        End If
                                    Else
                                        If chkBigEndding.Checked Then
                                            bmp.SetPixel(Int(i / 8) * 8 + 7 - (i Mod 8), j, c0)
                                        Else
                                            bmp.SetPixel(i, j, c0)
                                        End If
                                    End If
                                End If
                            Next
                        Next
                        grpMain.DrawImage(bmp, l * (cellWidth + 1), t * (cellHeight + 1))
                        'picMain.Refresh()
                    End If
                Next
                goProgress(t + 1)
            Next
            endProgress()
            picMain.Refresh()
            printHead()
            updateInfoData()
            updateActiveData()
            FS.Close()
        Catch ex2 As Exception
            MessageBox.Show("Error on open RAW file : " & vbCrLf & ex2.Message & vbCrLf & ex2.StackTrace)
            picMain.Refresh()
            Exit Sub
        End Try
    End Sub

    Private Sub insertNintendo8bit(st As String, ed As String, bs_step As Integer, bs_off As Integer)
        Try
            Dim FS As New System.IO.FileStream(txtImportFileName.Text, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            Dim Bw As New System.IO.BinaryReader(FS)
            Dim readBs As Byte()
            Dim bmp = New Bitmap(cellWidth, cellHeight)

            FS.Seek(txtImportOffset.Text, IO.SeekOrigin.Begin)
            Dim cx(4) As Color
            Dim c As Integer
            If chkInverse.Checked = False Then
                cx(3) = Color.Black
                cx(2) = Color.DarkGray
                cx(1) = Color.Gray
                cx(0) = Color.White
            Else
                cx(3) = Color.White
                cx(2) = Color.Gray
                cx(1) = Color.DarkGray
                cx(0) = Color.Black
            End If
            printHead()
            Dim grpMain As Graphics = Graphics.FromImage(picMain.Image)
            Dim startLoc = code2loc(st)
            Dim endloc = code2loc(ed)
            If endloc <= startLoc Then
                endloc = 65536
            End If
            startProgress(codeHeight)
            For t = 0 To codeHeight - 1
                For l = 0 To codeWidth - 1
                    readBs = Bw.ReadBytes(cellHeight * 2)
                    If readBs.Length < cellHeight * 2 - 1 Then
                        codeHeight = t + 1
                        codeHighRange(1) = codeHeight - 1
                        Dim bmpOldMain As Bitmap = picMain.Image
                        Dim h As Integer = (t + 1) * (cellHeight + 1)
                        Dim bmpNew As Bitmap = New Bitmap(bmpOldMain.Width, h)
                        bmpNew = bmpOldMain.Clone(New Rectangle(0, 0, bmpNew.Width, bmpNew.Height), Imaging.PixelFormat.DontCare)
                        bmpOldMain.Dispose()
                        bmpMain = bmpNew
                        picMain.Image = bmpMain
                        picMain.Height = h
                        picMain.Refresh()
                        Dim bmpOldV As Bitmap = picV.Image
                        Dim bmpNewV As Bitmap = New Bitmap(bmpOldV.Width, h)
                        bmpNewV = bmpOldV.Clone(New Rectangle(0, 0, bmpNewV.Width, bmpNewV.Height), Imaging.PixelFormat.DontCare)
                        picV.Image = bmpNewV
                        picV.Height = h
                        bmpOldV.Dispose()
                        picV.Refresh()
                        printHead()
                        picMain.Refresh()
                        FS.Close()
                        Exit Sub
                    End If
                    For j = 0 To 7
                        For i = 0 To 7
                            If j < readBs.Length / 2 Then
                                c = (readBs(j * bs_step + Int(i / 8)) >> (7 - i)) Mod 2
                                c = (c << 1) + ((readBs(j * bs_step + bs_off + Int(i / 8)) >> (7 - i)) Mod 2)
                                If chkBigEndding.Checked Then
                                    bmp.SetPixel(7 - i, j, cx(c))
                                Else
                                    bmp.SetPixel(i, j, cx(c))
                                End If
                            End If
                        Next
                    Next
                    grpMain.DrawImage(bmp, l * (cellWidth + 1), t * (cellHeight + 1))
                    'picMain.Refresh()
                Next
                goProgress(t + 1)
            Next
            endProgress()
            picMain.Refresh()
            printHead()
            updateInfoData()
            updateActiveData()
            FS.Close()
        Catch ex2 As Exception
            MessageBox.Show("Error on open RAW file : " & vbCrLf & ex2.Message & vbCrLf & ex2.StackTrace)
            picMain.Refresh()
            Exit Sub
        End Try
    End Sub

    Private Sub importRAW(width As Integer, height As Integer, sizeW As Integer, sizeH As Integer, cp As String, st As String, ed As String)

        NewFont(cp, sizeW, sizeH)
        '            codeLowRange = {0, sizeW - 1}
        '           codeHighRange = {0, sizeH - 1}
        createArray(codePage, width, height)
        insertRAW(st, ed)

    End Sub

    Private Sub importNintendo8bit(sizeW As Integer, sizeH As Integer, cp As String, st As String, ed As String, bs_step As Integer, bs_off As Integer)
        NewFont(cp, sizeW, sizeH)
        createArray(codePage, 8, 8)
        insertNintendo8bit(st, ed, bs_step, bs_off)
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Select Case cboImportType.Text
            Case ".FONT.PNG"
                importFontPNG()
            Case ".HZCG6"
                'importHZCG6()
            Case "Nintendo-FC"
                importNintendo8bit(txtImportSizeW.Text, txtImportSizeH.Text, cboImportCodepage.Text, txtInsertStart.Text, txtInsertEnd.Text, 1, 8)
            Case "Nintendo-GB"
                importNintendo8bit(txtImportSizeW.Text, txtImportSizeH.Text, cboImportCodepage.Text, txtInsertStart.Text, txtInsertEnd.Text, 2, 1)
            Case Else
                importRAW(txtImportWidth.Text, txtImportHeight.Text, txtImportSizeW.Text, txtImportSizeH.Text, cboImportCodepage.Text, txtInsertStart.Text, txtInsertEnd.Text)
        End Select

        resizeAll()
        updateInfoData()
        updateActiveData()
        RedrawEditor()
    End Sub

    Private Sub SelectChar(newx As Integer, newy As Integer)
        If (cellWidth <= 0) Then
            Exit Sub
        End If
        If (cellHeight <= 0) Then
            Exit Sub
        End If
        Dim grpD = Graphics.FromImage(picMain.Image)
        If (currCellX >= 0) And (currCellY >= 0) Then
            grpD.DrawRectangle(New Pen(Color.Blue), currCellX * (cellWidth + 1) - 1, currCellY * (cellHeight + 1) - 1, cellWidth + 1, cellHeight + 1)
        End If
        currCellX = newx
        currCellY = newy
        updateActiveData()
        grpD.DrawRectangle(New Pen(Color.Red), currCellX * (cellWidth + 1) - 1, currCellY * (cellHeight + 1) - 1, cellWidth + 1, cellHeight + 1)
        picMain.Refresh()
        RedrawEditor()
    End Sub

    Private Sub picMain_MouseClick(sender As Object, e As MouseEventArgs) Handles picMain.MouseClick
        If (cellWidth <= 0) Then
            Exit Sub
        End If
        If (cellHeight <= 0) Then
            Exit Sub
        End If
        If e.X < 0 Or e.Y < 0 Or e.X >= picMain.Width * zoomInOut Or e.Y >= picMain.Height * zoomInOut Then
            Exit Sub
        End If
        btnCopyCharImage.Select()
        If isShiftPress = True Then
            Dim maxloc As Integer
            Dim minloc As Integer
            maxloc = currCellX + currCellY * codeWidth
            minloc = Int((e.X) / (cellWidth + 1)) + Int((e.Y) / (cellHeight + 1)) * codeWidth
            If maxloc > minloc Then
                txtMoveStart.Text = loc2code(Int((e.X) / (cellWidth + 1)), Int((e.Y) / (cellHeight + 1)))
                txtMoveEnd.Text = loc2code(currCellX, currCellY)
            Else
                txtMoveStart.Text = loc2code(currCellX, currCellY)
                txtMoveEnd.Text = loc2code(Int((e.X) / (cellWidth + 1)), Int((e.Y) / (cellHeight + 1)))
            End If
        End If
        SelectChar(Int((e.X) / (cellWidth + 1) / zoomInOut), Int((e.Y) / (cellHeight + 1) / zoomInOut))
    End Sub

    Private Sub picEditor_Resize(sender As Object, e As EventArgs) Handles picEdit.Resize
        RedrawEditor()
    End Sub
    Private Sub RedrawEditor()
        If currCellX = -1 Then
            Exit Sub
        End If
        If picEdit.Width <= 1 Or picEdit.Height <= 1 Then
            Exit Sub
        End If
        If (cellWidth <= 0) Then
            Exit Sub
        End If
        If (cellHeight <= 0) Then
            Exit Sub
        End If

        Dim bmp = New Bitmap(cellWidth, cellHeight)
        Dim grp = Graphics.FromImage(bmp)
        Dim bmpD = New Bitmap(picEdit.Width, picEdit.Height)
        Dim grpD = Graphics.FromImage(bmpD)

        grp.DrawImage(picMain.Image, New RectangleF(0, 0, cellWidth, cellHeight), New RectangleF(currCellX * (cellWidth + 1), currCellY * (cellHeight + 1), cellWidth, cellHeight), GraphicsUnit.Pixel)
        grpD.FillRectangle(New SolidBrush(Color.White), 0, 0, picEdit.Width, picEdit.Height)

        Dim dotSizeW As Single = (picEdit.Width - 1) / cellWidth
        Dim dotSizeH As Single = (picEdit.Height - 1) / cellHeight
        Dim dotoffset_X, dotoffset_Y, dot_W, dot_H, i, j As Single

        If chkGap.Checked Then
            dotoffset_X = dotSizeW * 0.05
            dotoffset_Y = dotSizeH * 0.05
            dot_W = dotSizeW * 0.9
            dot_H = dotSizeH * 0.9
        Else
            dotoffset_X = 0
            dotoffset_Y = 0
            dot_W = dotSizeW
            dot_H = dotSizeH
        End If
        Dim c As Color
        For j = 0 To cellHeight - 1
            For i = 0 To cellWidth - 1
                drawEditorDot(grpD, i * dotSizeW, j * dotSizeH, dotoffset_X, dotoffset_Y, dot_W, dot_H, bmp.GetPixel(i, j))
                '                If chkRound.Checked = False Then
                '               grpD.FillRectangle(New SolidBrush(bmp.GetPixel(i, j)), (i * dotSizeW) + dotoffset_X, j * dotSizeH + dotoffset_Y, dot_W, dot_H)
                '              Else
                '             grpD.FillEllipse(New SolidBrush(bmp.GetPixel(i, j)), (i * dotSizeW) + dotoffset_X, j * dotSizeH + dotoffset_Y, dot_W - 1, dot_H - 1)
                '            End If
                '           If chkGrid.Checked = True Then
                '          grpD.DrawRectangle(New Pen(Color.LightGray), i * dotSizeW, j * dotSizeH, dotSizeW, dotSizeH)
                '         End If
            Next
        Next
        bmp.Dispose()
        If Not IsNothing(picEdit.BackgroundImage) Then
            picEdit.BackgroundImage.Dispose()
        End If
        picEdit.BackgroundImage = bmpD
    End Sub

    Private Sub getFontList()
        Dim ff() As FontFamily
        Dim installedFontCollection As New Drawing.Text.InstalledFontCollection()
        ff = installedFontCollection.Families
        For Each i In ff
            txtFontName.Items.Add(i.Name)
        Next
    End Sub

    Private Sub frmBMPFont_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initGraphicResource()
        cboCodepage.SelectedIndex = 0
        cboSaveFileType.SelectedIndex = 0
        cboImportType.SelectedIndex = 0
        cboCopyType.SelectedIndex = 0
        getFontList()
        txtSaveImagePath.Text = Application.StartupPath
        Me.KeyPreview = True
        'resizeAll()
    End Sub

    Private Sub resizeObjByObj(obj As Object, objParent As Object, alignType As Integer,
                          Optional objNorth As Object = vbNull, Optional objSouth As Object = vbNull,
                          Optional objEast As Object = vbNull, Optional objWest As Object = vbNull,
                          Optional gap As Integer = 2)
        If alignType & AnchorStyles.Bottom <> 0 Then
            obj.Top = objParent.Height - obj.Height - gap
        End If
        If alignType & AnchorStyles.Right <> 0 Then
            obj.Left = objParent.Width - obj.Width - gap
        End If
    End Sub

    Private Function resizeObj(obj As Object, Optional l As Integer = -1, Optional t As Integer = -1, Optional w As Integer = -1, Optional h As Integer = -1) As Integer
        If IsNothing(obj) Then
            resizeObj = 0
            Exit Function
        End If
        If l <> -1 Then
            obj.left = l
        End If
        If t <> -1 Then
            obj.top = t
        End If
        If w <> -1 Then
            obj.width = w
        End If
        If h <> -1 Then
            obj.height = h
        End If
        resizeObj = obj.width
    End Function

    Private Sub addObj(ByRef x As Integer, ByRef y As Integer, max As Integer, obj As Object, anchor As Integer)
        ' AnchorStyles.Left: default
        ' AnchorStyles.Right: to line end

    End Sub

    Private Function tabsize(i As Integer, t As Integer) As Integer
        tabsize = Int((i + t - 1) / t) * t
        'tabsize = i
    End Function

    Private Sub resizeLineData(objTitle As Object, objItems() As Object,
                               left As Integer, ByRef y As Integer, width As Integer,
                               linespacing As Integer, ind As Integer)
        Dim x, remain, i As Integer
        Dim items, maxitemwidth As Integer

        items = 0
        maxitemwidth = 0

        x = left
        x += resizeObj(objTitle, x, y + 4, -1, -1)
        remain = width - objTitle.Width
        For Each item In objItems
            If InStr(item.Name, "lbl") > 0 Then
                remain -= item.Width
                items += 1
                If maxitemwidth < item.Width Then
                    maxitemwidth = item.Width
                End If
            End If
        Next
        If (remain > 30 * items) Then
            For i = 0 To items - 1
                x += resizeObj(objItems(i * 2), x, y + 4)
                x += resizeObj(objItems(i * 2 + 1), x, y, remain / items)
            Next
            y += linespacing
        Else
            remain = width - maxitemwidth - objTitle.Width
            If (remain > 30) Then
                For i = 0 To items - 1
                    x = left + objTitle.Width
                    x += resizeObj(objItems(i * 2), x, y + 4)
                    resizeObj(objItems(i * 2 + 1), x, y, width - objTitle.Width - objItems(i * 2).Width)
                    y += linespacing
                Next
            Else
                For i = 0 To items - 1
                    y += linespacing
                    x = left + ind
                    x += resizeObj(objItems(i * 2), x, y + 4, -1, -1)
                    remain = width - objItems(i * 2).Width - ind
                    If remain < 30 Then
                        y += linespacing
                        x = left + ind
                        remain = width - ind
                    End If
                    resizeObj(objItems(i * 2 + 1), x, y, remain)
                Next
                y += linespacing
            End If
        End If
    End Sub

    Private Function getWidth(obj As Object) As Integer
        If IsNothing(obj) Then
            getWidth = 0
        Else
            getWidth = obj.Width
        End If
    End Function

    Private Sub resizeLineSelect(objTitle As Object, objSelect As Object,
                                 left As Integer, ByRef y As Integer, width As Integer,
                                 linespacing As Integer, ind As Integer)
        Dim x, remain As Integer
        x = left
        x += resizeObj(objTitle, x, y + 4)
        remain = width - objTitle.Width
        If remain <= 90 Then
            x = left + ind
            y += linespacing
            remain = width - ind
        End If
        resizeObj(objSelect, x, y, remain)
        y += linespacing
    End Sub

    Private Sub resizeLineSelect(objTitle As Object, objSelect As Object, objCommand As Object,
                                 left As Integer, ByRef y As Integer, width As Integer,
                                 linespacing As Integer, ind As Integer)
        Dim x, i, remain As Integer
        x = left
        x += resizeObj(objTitle, x, y + 4)
        remain = width - objTitle.Width
        remain -= objCommand.Width
        If remain <= 90 Then
            x = left + ind
            y += linespacing
            remain = width - ind - objCommand.Width
            If remain <= 90 Then
                remain = width - ind
                resizeObj(objSelect, x, y, remain)
                y += linespacing
                x = left + ind
                x += resizeObj(objCommand, x, y)
            Else
                x += resizeObj(objSelect, x, y, remain)
                x += resizeObj(objCommand, x, y)
            End If
        Else
            x += resizeObj(objSelect, x, y, remain)
            x += resizeObj(objCommand, x, y)
        End If
        y += linespacing
    End Sub
    Private Sub resizeLineSelect(objTitle As Object, objSelect As Object, objCommand() As Object,
                                 left As Integer, ByRef y As Integer, width As Integer,
                                 linespacing As Integer, ind As Integer)
        Dim x, i, remain, cmdwid As Integer
        x = left
        x += resizeObj(objTitle, x, y + 4)
        remain = width - objTitle.Width
        cmdwid = 0
        For i = 0 To objCommand.Length - 1
            remain -= objCommand(i).Width
            cmdwid += objCommand(i).Width
        Next
        If remain <= 30 Then
            remain = width - ind - cmdwid
            If remain <= 30 Then
                x = left + ind
                y += linespacing
                remain = width - ind
                resizeObj(objSelect, x, y, remain)
                y += linespacing
                x = left + ind
                If width - ind > cmdwid Then
                    For i = 0 To objCommand.Length - 1
                        x += resizeObj(objCommand(i), x, y)
                    Next
                Else
                    For i = 0 To objCommand.Length - 1
                        resizeObj(objCommand(i), x, y)
                        x = left + ind
                        y += linespacing
                    Next
                    y -= linespacing
                End If
            Else
                resizeObj(objSelect, x, y, width - objTitle.Width)
                x = left + objTitle.Width
                y += linespacing
                For i = 0 To objCommand.Length - 1
                    x += resizeObj(objCommand(i), x, y)
                Next
            End If
        Else
            x += resizeObj(objSelect, x, y, remain)
            For i = 0 To objCommand.Length - 1
                x += resizeObj(objCommand(i), x, y)
            Next
        End If
        y += linespacing
    End Sub

    Private Sub resizeLineCommand(objCommands() As Object,
                                 left As Integer, ByRef y As Integer, width As Integer,
                                 linespacing As Integer, ind As Integer)
        Dim x, i, remain As Integer

        x = left + ind
        remain = width - ind
        If remain / objCommands.Length > 90 Then
            For i = 0 To objCommands.Length - 1
                x += resizeObj(objCommands(i), x, y, remain / objCommands.Length)
            Next
            y += linespacing
        Else
            If remain / 3 > 60 Then
                For i = 0 To objCommands.Length - 1
                    x += resizeObj(objCommands(i), x, y, remain / 3)
                    If i Mod 3 = 2 Then
                        x = left + ind
                        y += linespacing
                    End If
                Next
            ElseIf remain / 2 > 60 Then
                For i = 0 To objCommands.Length - 1
                    x += resizeObj(objCommands(i), x, y, remain / 2)
                    If i Mod 2 = 1 Then
                        x = left + ind
                        y += linespacing
                    End If
                Next
            Else
                For i = 0 To objCommands.Length - 1
                    resizeObj(objCommands(i), x, y, remain)
                    x = left + ind
                    y += linespacing
                Next
            End If
        End If
    End Sub

    Private Sub resizeLineNormal(obj() As Object,
                                 left As Integer, ByRef y As Integer, width As Integer,
                                 linespacing As Integer, ind As Integer)
        Dim x, i, remain As Integer

        x = left
        remain = width - x
        For i = 0 To obj.Length - 1
            remain -= obj(i).Width
        Next
        If remain > 0 Then
            For i = 0 To obj.Length - 1
                x += resizeObj(obj(i), x, y)
            Next
            y += linespacing
        Else
            For i = 0 To obj.Length - 1
                resizeObj(obj(i), x, y)
                y += linespacing
            Next
        End If
    End Sub

    Private Sub resizeLineCommand(objCommands() As Object,
                                 left As Integer, ByRef y As Integer, width As Integer)
        Dim x, i As Integer

        x = left
        For i = 0 To objCommands.Length - 1
            x += resizeObj(objCommands(i), x, y, width / objCommands.Length)
        Next
    End Sub


    Private Sub resizeTab()
        Try
            Dim x, y As Integer
            If IsNothing(tabControl.SelectedTab) Then
                Exit Sub
            End If
            Dim margin As Integer = 2
            Dim gap As Integer = 0
            Dim tab As Integer = 1
            Dim ind As Integer = 8
            Dim linespacing As Integer = 23
            Dim max = tabControl.SelectedTab.Width - gap * 2 - 20

            max = tabControl.SelectedTab.Width - margin * 2 - 20
            y = 0
            If tabControl.SelectedTab.Text = "Create" Then
                resizeLineData(lblNewCharsize, {lblNewCharsizeWidth, txtNewWidth, lblNewCharsizeHeight, txtNewHeight, lblNewBaseline, txtNewBaseline},
                          margin, y, max, linespacing, ind)
                resizeLineSelect(lblNewCodepage, cboCodepage,
                          margin, y, max, linespacing, ind)
                resizeLineData(lblNewCodesize, {lblNewCodesizeCol, txtNewSizeW, lblNewCodesizeRow, txtNewSizeH},
                          margin, y, max, linespacing, ind)
                resizeLineCommand({btnCreate},
                          margin, y, max, linespacing, ind)
                resizeLineSelect(lblNewFont, txtFontName,
                          margin, y, max, linespacing, ind)
                resizeLineNormal({chkMax, chkBlack},
                          txtFontName.Left, y, max, linespacing, ind)
                resizeLineData(lblNewFontOffset, {lblNewFontOffsetX, txtCharOffsetX, lblNewFontOffsetY, txtCharOffsetY, lblNewFontSize, txtCharSize},
                          margin, y, max, linespacing, ind)
                resizeLineCommand({btnInitCharactors},
                      margin, y, max, linespacing, ind)
            End If
            If tabControl.SelectedTab.Text = "Open" Then
                resizeLineSelect(lblOpenFile, txtImportFileName, btnOpenFile,
                          margin, y, max, linespacing, ind)
                resizeLineSelect(lblOpenType, cboImportType,
                          margin, y, max, linespacing, ind)
                resizeLineData(lblOpenCharsize, {lblOpenCharsizeWidth, txtImportWidth, lblOpenCharsizeHeight, txtImportHeight},
                          margin, y, max, linespacing, ind)
                resizeLineSelect(lblOpenCodepage, cboImportCodepage,
                          margin, y, max, linespacing, ind)
                resizeLineData(lblOpenCodesize, {lblOpenCodesizeLow, txtImportSizeW, lblOpenCodesizeHigh, txtImportSizeH},
                          margin, y, max, linespacing, ind)
                resizeLineSelect(lblOpenOffset, txtImportOffset, {chkInverse, chkBigEndding},
                          margin, y, max, linespacing, ind)
                '                resizeLineNormal({chkInverse, chkBigEndding},
                '               lblOpenOffset.Width, y, max, linespacing, ind)
                resizeLineData(lblOpenCodelocate, {lblCodeLocateStart, txtInsertStart, lblCodeLocateEnd, txtInsertEnd},
                          margin, y, max, linespacing, ind)
                resizeLineCommand({btnImport, btnInsert, btnOpenSave},
                          margin, y, max, linespacing, ind)
            End If
            If tabControl.SelectedTab.Text = "Save" Then
                resizeLineSelect(lblSavePath, txtSaveImagePath, btnOpenSaveimagepath,
                          margin, y, max, linespacing, ind)
                resizeLineSelect(lblSaveFile, txtSaveImage,
                          margin, y, max, linespacing, ind)
                resizeLineSelect(lblSaveType, cboSaveFileType,
                          margin, y, max, linespacing, ind)
                resizeLineData(lblSaveCoderange, {lblSaveCoderangeFrom, txtCodeRangeStart, lblSaveCoderangeTo, txtCodeRangeEnd},
                          margin, y, max, linespacing, ind)
                resizeLineCommand({btnSave, btnOpenFolder},
                          margin, y, max, linespacing, ind)
            End If
            If tabControl.SelectedTab.Text = "Edit" Then
                resizeLineSelect(lblEditScale, txtScale, btnScale,
                          margin, y, max, linespacing, ind)
                resizeLineCommand({btnDrawLines, btnInverseColor, btnToBlackWhite},
                          margin, y, max, linespacing, ind)
                '                resizeLineCommand({btnToBlackWhite},
                '               margin, y, max, linespacing, ind)
                resizeLineData(lblCharacteradjust, {lblCharacteradjustX, txtMoveX, lblCharacteradjustY, txtMoveY},
                          margin, y, max, linespacing, ind)
                resizeLineCommand({btnCharacterAdjust},
                          margin, y, max, linespacing, ind)
                resizeLineData(lblEditMove, {lblEditMoveFrom, txtMoveStart, lblEditMoveEnd, txtMoveEnd, lblEditMoveTo, txtMoveTo},
                          margin, y, max, linespacing, ind)
                resizeLineCommand({btnEditClean, btnMoveCode, btnCopyCode, btnExchange},
                          margin, y, max, linespacing, ind)
            End If

            If y + linespacing + tabControl.ItemSize.Height > tabControl.Height Then
                tabControl.SelectedTab.AutoScroll = True
                'tabControl.SelectedTab.AutoScrollMinSize.Width = 8
                'tabControl.SelectedTab.SetAutoScrollMargin(8, 8)
            Else
                tabControl.SelectedTab.AutoScroll = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub resizeNSEW(x As Integer, y As Integer, N As Object, S As Object, E As Object, W As Object)
        resizeObj(N, x - N.Width / 2, y - 12 - N.Height / 2, -1, -1)
        resizeObj(S, x - S.Width / 2, y + 12 - S.Height / 2, -1, -1)
        resizeObj(E, x + N.Width / 2 - 1, y - E.Height / 2, -1, -1)
        resizeObj(W, x - N.Width / 2 - W.Width + 1, y - W.Height / 2, -1, -1)
    End Sub

    Private Sub resizeAll()
        tabControl.Width = split.Panel2.Width - 2

        resizeObj(picHead, 0, 0, 13 * zoomInOut, 13 * zoomInOut)
        resizeObj(pnlMain, 13 * zoomInOut, 13 * zoomInOut, split.Panel1.Width - 13 * zoomInOut, split.Panel1.Height - 13 * zoomInOut)
        If IsNothing(bmpMain) = False Then
            resizeObj(picMain, -1, -1, bmpMain.Width * zoomInOut, bmpMain.Height * zoomInOut)
        End If
        resizeObj(pnlH, 13 * zoomInOut, 0, pnlMain.Width, 13 * zoomInOut)
        resizeObj(picH, -1, -1, picH.Width * zoomInOut, picH.Height * zoomInOut)
        resizeObj(pnlV, 0, 13 * zoomInOut, 13 * zoomInOut, pnlMain.Height)
        resizeObj(picV, -1, -1, picV.Width * zoomInOut, picV.Height * zoomInOut)
        ' picV.Left = 0
        ' picH.Top = 0
        RedrawEditor()
        resizeObj(picEdit, -1, -1, split.Panel2.Width - 2 * picEdit.Left, split.Panel2.Height - picEdit.Top - 2 * picEdit.Left - chkGrid.Height)
        resizeObj(chkGrid, -1, split.Panel2.Height - chkGrid.Height, -1, -1)
        resizeObj(chkRound, -1, split.Panel2.Height - chkGrid.Height, -1, -1)
        resizeObj(chkGap, -1, split.Panel2.Height - chkGrid.Height, -1, -1)
        resizeObj(lblBackColor, split.Panel2.Width - lblBackColor.Width, split.Panel2.Height - lblBackColor.Height, -1, -1)
        resizeObj(lblForeColor, lblBackColor.Left - lblForeColor.Width, split.Panel2.Height - lblBackColor.Height, -1, -1)
        resizeObj(progressBar, tabControl.Left, tabControl.Height, tabControl.Width - 4, 8)

        resizeObj(cboCopyType, tabControl.Width - cboCopyType.Width - 2, tabControl.Height + 10)
        Dim y As Integer
        y = tabControl.Height + 30
        resizeLineCommand({btnCopyCharImage, btnPasteImage},
                          tabControl.Width - cboCopyType.Width - 2, y, cboCopyType.Width)
        y = tabControl.Height + 52
        resizeLineCommand({btnEditorInverse},
                          tabControl.Width - cboCopyType.Width - 2, y, cboCopyType.Width)
        resizeNSEW(tabControl.Width - cboCopyType.Width + btnEditorLeft.Width + btnEditorUp.Width / 2, tabControl.Height + 100, btnEditorUp, btnEditorDown, btnEditorRight, btnEditorLeft)
        resizeNSEW(tabControl.Width - 2 - btnEditorRRight.Width - btnEditorRUp.Width / 2, tabControl.Height + 100, btnEditorRUp, btnEditorRDown, btnEditorRRight, btnEditorRLeft)

        resizeTab()

        'edit
        'btnCopyCharImage.Width = split.Panel2.Width - btnCopyCharImage.Left
        'btnPasteImage.Width = split.Panel2.Width - btnPasteImage.Left
    End Sub

    Private Sub frmBMPFont_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'If isResizing = False Then
        'isResizing = True
        resizeAll()
        '    isResizing = False
        'End If
    End Sub

    Private Function bmp2bintext(bmp)
        Dim s = ""
        Dim c As Color
        For j = 0 To cellHeight - 1
            For i = 0 To cellWidth - 1
                c = bmp.GetPixel(currCellX * (cellWidth + 1) + i, currCellY * (cellHeight + 1) + j)
                If (c.R * 9 + c.G * 19 + c.B * 4 >> 5) < 128 And c.A > 128 Then
                    s = s & "1 "
                Else
                    s = s & "0 "
                End If
            Next
            s = s & vbCrLf
        Next
        bmp2bintext = s
    End Function

    Private Function bmp2svg_g(bmp As Bitmap, cd As String, grid As Boolean, round As Boolean, gap As Boolean) As String
        bmp2svg_g = "  <g style=""display:inline"" id=""code" & cd & """ width=""" & cellWidth * 10 & """ height=""" & cellHeight * 10 & """>" & vbCrLf

        If grid = True Then
            For i = 0 To cellWidth
                bmp2svg_g &= "    <line x1=""" & i * 10 & """ y1=""0"" x2=""" & i * 10 & """ y2=""" & cellHeight * 10 & """ style=""stroke:#000;stroke-width:0.4px""/>" & vbCrLf
            Next
            For j = 0 To cellHeight
                bmp2svg_g &= "    <line y1=""" & j * 10 & """ x1=""0"" y2=""" & j * 10 & """ x2=""" & cellWidth * 10 & """ style=""stroke:#000;stroke-width:0.4px""/>" & vbCrLf
            Next
        End If
        Dim c As Color
        Dim dotXY, dotWH As Single
        If gap = True Then
            dotXY = 0.5
            dotWH = 9
        Else
            dotXY = 0
            dotWH = 10
        End If
        Dim x, y As Integer

        If cd = "" Then
            x = currCellX
            y = currCellY
        Else
            x = code2locX(cd)
            y = code2locY(cd)
        End If
        For j = 0 To cellHeight - 1
            For i = 0 To cellWidth - 1
                c = bmp.GetPixel(x * (cellWidth + 1) + i, y * (cellHeight + 1) + j)
                If (c.R * 9 + c.G * 19 + c.B * 4 >> 5) < 128 And c.A > 128 Then
                    If round = True Then
                        bmp2svg_g &= "    <circle r=""" & dotWH / 2 & """ cy=""" & j * 10 + 5 & """ cx=""" & i * 10 + 5 & """ style=""fill:rgb(" & c.R & "," & c.G & "," & c.B & ");fill-opacity:1""/>" & vbCrLf
                    Else
                        bmp2svg_g &= "    <rect width=""" & dotWH & """ height=""" & dotWH & """ y=""" & (j * 10 + dotXY) & """ x=""" & (i * 10 + dotXY) & """ style=""fill:rgb(" & c.R & "," & c.G & "," & c.B & ");fill-opacity:1""/>" & vbCrLf
                    End If
                End If
            Next
            bmp2svg_g &= vbCrLf
        Next
        bmp2svg_g &= "  </g>" & vbCrLf
    End Function
    Private Function bmp2svgtext(bmp, cd, grid, round)
        Dim s = "<?xml version=""1.0"" encoding=""UTF-8"" standalone=""no""?>" & vbCrLf
        s &= "<svg xmlns=""http://www.w3.org/2000/svg""" & vbCrLf
        s &= "     enable-background=""new 0 0 " & cellWidth * 10 & " " & cellHeight * 10 & """" & vbCrLf
        s &= "     width=""" & cellWidth * 10 & """ height=""" & cellHeight * 10 & """ viewBox=""0 0 " & cellWidth * 10 & " " & cellHeight * 10 & """>" & vbCrLf
        s &= bmp2svg_g(bmp, cd, grid, round, chkGap.Checked)
        s &= "</svg>"
        bmp2svgtext = s
    End Function

    Private Sub btnCopyImage_Click(sender As Object, e As EventArgs) Handles btnCopyCharImage.Click
        If currCellX = -1 Then
            Exit Sub
        End If
        If picEdit.Width <= 1 Or picEdit.Height <= 1 Then
            Exit Sub
        End If
        Dim s As String
        Try
            bmpClipboard.Dispose()
            Select Case cboCopyType.Text
                Case "image"
                    bmpClipboard = New Bitmap(cellWidth, cellHeight)
                    Dim grp = Graphics.FromImage(bmpClipboard)
                    grp.DrawImage(picMain.Image, New RectangleF(0, 0, cellWidth, cellHeight), New RectangleF(currCellX * (cellWidth + 1), currCellY * (cellHeight + 1), cellWidth, cellHeight), GraphicsUnit.Pixel)
                    Clipboard.SetImage(bmpClipboard)
                Case "editor image"
                    Clipboard.SetImage(picEdit.Image)
                Case "BIN"
                    s = bmp2bintext(picMain.Image)
                    Clipboard.SetText(s)
                Case "SVG"
                    s = bmp2svgtext(picMain.Image, loc2code(currCellX, currCellY), chkGrid.Checked, chkRound.Checked)
                    Clipboard.SetText(s)
            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPasteImage_Click(sender As Object, e As EventArgs) Handles btnPasteImage.Click
        If currCellX = -1 Then
            Exit Sub
        End If
        If picEdit.Width <= 1 Or picEdit.Height <= 1 Then
            Exit Sub
        End If
        Dim bmpClip = Clipboard.GetImage()
        If bmpClip Is Nothing Then
            Exit Sub
        End If
        Dim grpMain As Graphics = Graphics.FromImage(picMain.Image)
        'Dim bmp = New Bitmap(Width, Height)
        'Dim grp As Graphics = Graphics.FromImage(bmp)

        'grp.DrawImage(bmpClip, 0, 0)

        grpMain.DrawImage(bmpClip, currCellX * (cellWidth + 1), currCellY * (cellHeight + 1), cellWidth, cellHeight)
        picMain.Refresh()
        resizeAll()
        RedrawEditor()
    End Sub

    Private Sub drawEditorDot(grp As Graphics, x As Integer, y As Integer, ox As Integer, oy As Integer, w As Integer, h As Integer, c As Color)
        If c = Color.White Then
            grp.FillRectangle(New SolidBrush(c), x, y, w + ox + ox, h + oy + oy)
        Else
            If chkRound.Checked = False Then
                grp.FillRectangle(New SolidBrush(c), x + ox, y + oy, w, h)
            Else
                grp.FillEllipse(New SolidBrush(c), x + ox, y + oy, w - 1, h - 1)
            End If
        End If
        If chkGrid.Checked = True Then
            grp.DrawRectangle(New Pen(Color.LightGray), x, y, w + ox + ox, h + oy + oy)
        End If
    End Sub

    Private Sub picEditor_MouseMove(sender As Object, e As MouseEventArgs) Handles picEdit.MouseMove
        If picEdit.BackgroundImage Is Nothing Then
            Exit Sub
        End If
        'If isShiftPress = True Then
        'picEdit.Cursor = Cursors.Hand
        'Else
        'picEdit.Cursor = Cursors.Cross
        'End If
        If e.X < 0 Or e.Y < 0 Or e.X > picEdit.Width Or e.Y > picEdit.Height Then
            Exit Sub
        End If
        Dim grpD As Graphics = Graphics.FromImage(picEdit.BackgroundImage)
        Dim bmpM As Bitmap = picMain.Image
        Dim grpM As Graphics = Graphics.FromImage(picMain.Image)

        Dim a As Single = (picEdit.Width - 1) / cellWidth
        Dim b As Single = (picEdit.Height - 1) / cellHeight

        Dim dotX As Integer = (e.X + a / 2) / a - 1
        Dim dotY As Integer = (e.Y + b / 2) / b - 1
        lblCursor.Text = "Dot: " & dotX & "-" & dotY
        If dotX >= cellWidth Or dotY >= cellHeight Then
            Exit Sub
        End If
        Dim dotW, dotH, dotOffX, dotOffY As Integer
        If chkGap.Checked Then
            dotW = a * 0.9
            dotH = b * 0.9
            dotOffX = a * 0.05
            dotOffY = b * 0.05
        Else
            dotW = a
            dotH = b
            dotOffX = 0
            dotOffY = 0
        End If
        If e.Button = MouseButtons.Left Then
            If isShiftPress = False Then
                drawEditorDot(grpD, dotX * a, dotY * b, dotOffX, dotOffY, dotW, dotH, lblForeColor.BackColor)
                bmpM.SetPixel(currCellX * (cellWidth + 1) + dotX, currCellY * (cellHeight + 1) + dotY, lblForeColor.BackColor)
            Else
                lblForeColor.BackColor = bmpM.GetPixel(currCellX * (cellWidth + 1) + dotX, currCellY * (cellHeight + 1) + dotY)
                If lblForeColor.BackColor.GetBrightness > 0.5 Then
                    lblForeColor.ForeColor = Color.Black
                Else
                    lblForeColor.ForeColor = Color.White
                End If
            End If

        End If
        If e.Button = MouseButtons.Right Then
            If isShiftPress = False Then
                drawEditorDot(grpD, dotX * a, dotY * b, dotOffX, dotOffY, dotW, dotH, lblBackColor.BackColor)
                bmpM.SetPixel(currCellX * (cellWidth + 1) + dotX, currCellY * (cellHeight + 1) + dotY, lblBackColor.BackColor)
            Else
                lblBackColor.BackColor = bmpM.GetPixel(currCellX * (cellWidth + 1) + dotX, currCellY * (cellHeight + 1) + dotY)
                If lblBackColor.BackColor.GetBrightness > 0.5 Then
                    lblBackColor.ForeColor = Color.Black
                Else
                    lblBackColor.ForeColor = Color.White
                End If
            End If
        End If
        picMain.Refresh()
        picEdit.Refresh()
    End Sub

    Private Sub picEditor_MouseClick(sender As Object, e As MouseEventArgs) Handles picEdit.MouseClick
        picEditor_MouseMove(sender, e)
    End Sub

    Private Sub picMain_MouseMove(sender As Object, e As MouseEventArgs) Handles picMain.MouseMove

        If e.Button = MouseButtons.Left Then
            picMain_MouseClick(sender, e)
        End If
    End Sub

    Private Sub btnInitCharactors_Click(sender As Object, e As EventArgs) Handles btnInitCharactors.Click
        initCharactor()
    End Sub

    Private Sub SplitContainer1_Resize(sender As Object, e As EventArgs) Handles split.Resize
        'If isResizing = False Then
        resizeAll()
        'End If
    End Sub

    Private Sub btnScale_Click(sender As Object, e As EventArgs) Handles btnScale.Click

        Dim rectNew As New Rectangle
        Dim rectOld As New Rectangle
        Dim scale As Integer

        If InStr(txtScale.Text, "%") > 0 Then
            scale = Int(txtScale.Text.Replace("%", ""))
            If scale = 100 Or scale <= 0 Or scale > 10000 Then
                Exit Sub
            End If
            rectNew.Width = cellWidth * scale / 100
            rectNew.Height = cellHeight * scale / 100
        ElseIf InStr(txtScale.Text, "x") > 0 Then
            Dim a = Strings.Split(txtScale.Text, "x")
            rectNew.Width = a(0)
            rectNew.Height = a(1)
        End If
        rectOld.Width = cellWidth
        rectOld.Height = cellHeight

        Dim bmp As Bitmap = picMain.Image.Clone()
        createArray(codePage, rectNew.Width, rectNew.Height)
        Dim grpNew = Graphics.FromImage(picMain.Image)
        Dim grpOld = Graphics.FromImage(bmp)
        startProgress(codeHeight)
        For j = 0 To codeHeight - 1
            For i = 0 To codeWidth - 1
                rectNew.X = i * (rectNew.Width + 1)
                rectNew.Y = j * (rectNew.Height + 1)
                rectOld.X = i * (rectOld.Width + 1)
                rectOld.Y = j * (rectOld.Width + 1)
                grpNew.DrawImage(bmp, rectNew, rectOld, GraphicsUnit.Pixel)
            Next
            goProgress(j + 1)
        Next
        endProgress()
        bmp.Dispose()
        picMain.Refresh()
        RedrawEditor()
    End Sub

    Private Sub frmBMPFont_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.V Then
            btnPasteImage_Click(sender, e)
        End If
        If e.Control And e.KeyCode = Keys.C Then
            btnCopyImage_Click(sender, e)
        End If
        If e.KeyCode = Keys.ShiftKey Then
            isShiftPress = True
            picEdit.Cursor = Cursors.Hand
        End If
        If e.KeyCode = Keys.ControlKey Then
            isCtrlPress = True
        End If
    End Sub

    Private Sub OpenFolder_Click(sender As Object, e As EventArgs) Handles btnOpenFolder.Click
        Process.Start("explorer.exe", txtSaveImagePath.Text)
        'Application.StartupPath
    End Sub

    Private Sub Special_Click(sender As Object, e As EventArgs) Handles btnSpecial.Click
        frmPrint.Show()
    End Sub

    Private Sub tabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControl.SelectedIndexChanged
        resizeTab()
    End Sub

    Private Sub btnInverseColor_Click(sender As Object, e As EventArgs) Handles btnInverseColor.Click
        If IsNothing(picMain.Image) Then
            Exit Sub
        End If
        Dim bmp As Bitmap = picMain.Image
        Dim c As Color
        Dim d As Color
        startProgress(codeHeight)
        For j = 0 To codeHeight - 1
            For i = 0 To codeWidth - 1
                For n = 0 To cellHeight - 1
                    For m = 0 To cellWidth - 1
                        c = bmp.GetPixel(i * (cellWidth + 1) + m, j * (cellHeight + 1) + n)
                        d = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B)
                        bmp.SetPixel(i * (cellWidth + 1) + m, j * (cellHeight + 1) + n, d)
                    Next
                Next
            Next
            goProgress(j + 1)
        Next
        endProgress()
        picMain.Refresh()
        RedrawEditor()
    End Sub

    Private Sub btnToBlackWhite_Click(sender As Object, e As EventArgs) Handles btnToBlackWhite.Click
        If IsNothing(picMain.Image) Then
            Exit Sub
        End If
        Dim bmp As Bitmap = picMain.Image
        Dim c As Color
        Dim d As Color
        startProgress(codeHeight)

        For j = 0 To codeHeight - 1
            For i = 0 To codeWidth - 1
                For n = 0 To cellHeight - 1
                    For m = 0 To cellWidth - 1
                        c = bmp.GetPixel(i * (cellWidth + 1) + m, j * (cellHeight + 1) + n)
                        If (c.R * 9 + c.G * 19 + c.B * 4 >> 5) < 128 And c.A > 128 Then
                            d = Color.Black
                        Else
                            d = Color.White
                        End If
                        bmp.SetPixel(i * (cellWidth + 1) + m, j * (cellHeight + 1) + n, d)
                    Next
                Next
            Next
            goProgress(j + 1)
        Next
        endProgress()
        picMain.Refresh()
        RedrawEditor()
    End Sub
    Private Sub chkRound_CheckedChanged(sender As Object, e As EventArgs) Handles chkRound.CheckedChanged
        RedrawEditor()
    End Sub

    Private Sub chkGrid_CheckedChanged(sender As Object, e As EventArgs) Handles chkGrid.CheckedChanged
        RedrawEditor()
    End Sub

    Private Sub btnOutput1_Click(sender As Object, e As EventArgs) Handles btnOutput1.Click
        ' GB Zones:
        ' Double1 (Symbol): A1-A9 : A1-FE
        ' Double2 (Hanzi) : B0-F7 : A1-FE
        ' Double3 (Hanzi) : 81-A0 : 40-7E,80-FE
        ' Double4 (Hanzi) : AA-FE : 40-7E,80-FE
        ' Double5 (Symbol): A8-A9 : 40-7E,80-A0
        ' DoubleUser1: AAA1-AFFE
        ' DoubleUser2: F8A1-FEFE
        ' DoubleUser3     : A1-A7 : 40-7E,80-A0
    End Sub

    Private Sub frmBMPFont_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.ShiftKey Then
            isShiftPress = False
            picEdit.Cursor = Cursors.Cross
        End If
        If e.KeyCode = Keys.ControlKey Then
            isCtrlPress = False
        End If
    End Sub

    Private Function HexStrToLong(myStr As String) As Long '16进制转整数
        Dim tmpStr As String
        Dim tmpchr As String
        tmpStr = ""
        tmpStr = Trim(myStr)
        Dim value As Integer
        value = 0
        myStr = StrConv(myStr, vbUpperCase)
        For i = 1 To Len(myStr)
            tmpchr = Mid(myStr, i, 1)

            Select Case tmpchr
                Case "0"
                    value = value + 0 * 16 ^ (Len(myStr) - i)
                Case "1"
                    value = value + 1 * 16 ^ (Len(myStr) - i)
                Case "2"
                    value = value + 2 * 16 ^ (Len(myStr) - i)
                Case "3"
                    value = value + 3 * 16 ^ (Len(myStr) - i)
                Case "4"
                    value = value + 4 * 16 ^ (Len(myStr) - i)
                Case "5"
                    value = value + 5 * 16 ^ (Len(myStr) - i)
                Case "6"
                    value = value + 6 * 16 ^ (Len(myStr) - i)
                Case "7"
                    value = value + 7 * 16 ^ (Len(myStr) - i)
                Case "8"
                    value = value + 8 * 16 ^ (Len(myStr) - i)
                Case "9"
                    value = value + 9 * 16 ^ (Len(myStr) - i)
                Case "A"
                    value = value + 10 * 16 ^ (Len(myStr) - i)
                Case "B"
                    value = value + 11 * 16 ^ (Len(myStr) - i)
                Case "C"
                    value = value + 12 * 16 ^ (Len(myStr) - i)
                Case "D"
                    value = value + 13 * 16 ^ (Len(myStr) - i)
                Case "E"
                    value = value + 14 * 16 ^ (Len(myStr) - i)
                Case "F"
                    value = value + 15 * 16 ^ (Len(myStr) - i)
            End Select
        Next
        HexStrToLong = value

    End Function

    Private Sub picMain_GotFocus(sender As Object, e As EventArgs) Handles picMain.GotFocus

    End Sub

    Private Sub picMain_KeyDown(sender As Object, e As KeyEventArgs) Handles picMain.KeyDown
        If (picMain.Focused = True) Then
            If e.KeyCode = Keys.Left Then
                Dim newx = currCellX - 1
                If newx < 0 Then
                    newx = 0
                End If
                SelectChar(newx, currCellY)
                Return
            End If
            If e.KeyCode = Keys.Up Then
                Dim newy = currCellY - 1
                If newy < 0 Then
                    newy = 0
                End If
                SelectChar(currCellX, newy)
                Return
            End If
            If e.KeyCode = Keys.Right Then
                Dim newx = currCellX + 1
                If newx >= codeWidth Then
                    newx = codeWidth - 1
                End If
                SelectChar(newx, currCellY)
                Return
            End If
            If e.KeyCode = Keys.Down Then
                Dim newy = currCellY + 1
                If newy >= codeHeight Then
                    newy = codeHeight - 1
                End If
                SelectChar(currCellX, newy)
                Return
            End If
        End If
    End Sub

    Private Sub setCodepageSize(cpn As String, txtw As TextBox, txth As TextBox)
        txth.Enabled = False
        txtw.Enabled = False
        Select Case cpn
            Case "UnicodeUCS16(1200)", "ISO/IEC10646BMP(1200)", "ISO/IEC10646SMP(65005)", "ISO/IEC10646SIP(65005)", "ISO/ IEC10646TIP(65005)", "ISO/ IEC10646 - Fxxxx(65005)"
                txtw.Text = "256"
                txth.Text = "256"
            Case "ASCII-7(1252)", "GB18030单字节(936)", "Big-5单字节(950)"
                txtw.Text = "16"
                txth.Text = "8"
            Case "ASCII-8(1252)", "Shift-JIS单字节(932)"
                txtw.Text = "16"
                txth.Text = "16"
            Case "GB2312双字节(936)"
                txtw.Text = Str(&HFE - &HA1 + 1)
                txth.Text = Str(&HFE - &HA1 + 1)
            Case "GBK双字节(936)", "GB18030双字节(936)"
                txtw.Text = Str(&HFE - &H80 + 1 + &H7E - &H40 + 1)
                txth.Text = Str(&HFE - &H81 + 1)
            Case "Big-5双字节(950)"
                txtw.Text = Str(&HFE - &HA1 + 1 + &H7E - &H40 + 1)
                txth.Text = Str(&HFE - &H81 + 1)
            Case "Shift-JIS双字节(932)"
                txtw.Text = Str(&HFC - &H80 + 1 + &H7E - &H40 + 1)
                txth.Text = Str(&HFC - &HE0 + 1 + &H9F - &H81 + 1)
            Case Else
                txtw.Text = "256"
                txth.Text = "256"
                txth.Enabled = True
                txtw.Enabled = True
        End Select

    End Sub

    Private Sub cboCodepage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCodepage.SelectedIndexChanged
        setCodepageSize(cboCodepage.Text, txtNewSizeW, txtNewSizeH)
    End Sub

    Private Sub chkGap_CheckedChanged(sender As Object, e As EventArgs) Handles chkGap.CheckedChanged
        RedrawEditor()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOpenSaveimagepath.Click
        folderSave.SelectedPath = txtSaveImagePath.Text
        If folderSave.ShowDialog() = DialogResult.OK Then
            txtSaveImagePath.Text = folderSave.SelectedPath
        End If
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        fileOpen.FileName = txtImportFileName.Text
        If fileOpen.ShowDialog() = DialogResult.OK Then
            txtImportFileName.Text = fileOpen.FileName
        End If
    End Sub

    Private Sub picEdit_Click(sender As Object, e As EventArgs) Handles picEdit.Click

    End Sub

    Private Sub btnEditorUp_Click(sender As Object, e As EventArgs) Handles btnEditorUp.Click
        If IsNothing(picMain.Image) Then
            Exit Sub
        End If
        Dim bmp As Bitmap = picMain.Image
        Dim m, n As Integer
        For m = 0 To cellWidth - 1
            For n = 1 To cellHeight - 1
                bmp.SetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + n - 1, bmp.GetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + n))
            Next
            bmp.SetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + cellHeight - 1, lblBackColor.BackColor)
        Next
        picMain.Refresh()
        RedrawEditor()
    End Sub

    Private Sub btnEditorDown_Click(sender As Object, e As EventArgs) Handles btnEditorDown.Click
        If IsNothing(picMain.Image) Then
            Exit Sub
        End If
        Dim bmp As Bitmap = picMain.Image
        Dim m, n As Integer
        For m = 0 To cellWidth - 1
            For n = cellHeight - 2 To 0 Step -1
                bmp.SetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + n + 1, bmp.GetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + n))
            Next
            bmp.SetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1), lblBackColor.BackColor)
        Next
        picMain.Refresh()
        RedrawEditor()
    End Sub

    Private Sub btnEditorLeft_Click(sender As Object, e As EventArgs) Handles btnEditorLeft.Click
        If IsNothing(picMain.Image) Then
            Exit Sub
        End If
        Dim bmp As Bitmap = picMain.Image
        Dim m, n As Integer
        For n = 0 To cellHeight - 1
            For m = 1 To cellWidth - 1
                bmp.SetPixel(currCellX * (cellWidth + 1) + m - 1, currCellY * (cellHeight + 1) + n, bmp.GetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + n))
            Next
            bmp.SetPixel(currCellX * (cellWidth + 1) + cellWidth - 1, currCellY * (cellHeight + 1) + n, lblBackColor.BackColor)
        Next
        picMain.Refresh()
        RedrawEditor()
    End Sub

    Private Sub btnEditorRight_Click(sender As Object, e As EventArgs) Handles btnEditorRight.Click
        If IsNothing(picMain.Image) Then
            Exit Sub
        End If
        Dim bmp As Bitmap = picMain.Image
        Dim m, n As Integer
        For n = 0 To cellHeight - 1
            For m = cellWidth - 2 To 0 Step -1
                bmp.SetPixel(currCellX * (cellWidth + 1) + m + 1, currCellY * (cellHeight + 1) + n, bmp.GetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + n))
            Next
            bmp.SetPixel(currCellX * (cellWidth + 1), currCellY * (cellHeight + 1) + n, lblBackColor.BackColor)
        Next
        picMain.Refresh()
        RedrawEditor()
    End Sub

    Private Sub btnEditorRUp_Click(sender As Object, e As EventArgs) Handles btnEditorRUp.Click
        If IsNothing(picMain.Image) Then
            Exit Sub
        End If
        Dim bmp As Bitmap = picMain.Image
        Dim m, n As Integer
        Dim c As Color
        For m = 0 To cellWidth - 1
            c = bmp.GetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1))
            For n = 1 To cellHeight - 1
                bmp.SetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + n - 1, bmp.GetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + n))
            Next
            bmp.SetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + cellHeight - 1, c)
        Next
        picMain.Refresh()
        RedrawEditor()
    End Sub

    Private Sub btnEditorRDown_Click(sender As Object, e As EventArgs) Handles btnEditorRDown.Click
        If IsNothing(picMain.Image) Then
            Exit Sub
        End If
        Dim bmp As Bitmap = picMain.Image
        Dim m, n As Integer
        Dim c As Color
        For m = 0 To cellWidth - 1
            c = bmp.GetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + cellHeight - 1)
            For n = cellHeight - 2 To 0 Step -1
                bmp.SetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + n + 1, bmp.GetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + n))
            Next
            bmp.SetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1), c)
        Next
        picMain.Refresh()
        RedrawEditor()
    End Sub

    Private Sub btnEditorRLeft_Click(sender As Object, e As EventArgs) Handles btnEditorRLeft.Click
        If IsNothing(picMain.Image) Then
            Exit Sub
        End If
        Dim bmp As Bitmap = picMain.Image
        Dim m, n As Integer
        Dim c As Color
        For n = 0 To cellHeight - 1
            c = bmp.GetPixel(currCellX * (cellWidth + 1), currCellY * (cellHeight + 1) + n)
            For m = 1 To cellWidth - 1
                bmp.SetPixel(currCellX * (cellWidth + 1) + m - 1, currCellY * (cellHeight + 1) + n, bmp.GetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + n))
            Next
            bmp.SetPixel(currCellX * (cellWidth + 1) + cellWidth - 1, currCellY * (cellHeight + 1) + n, c)
        Next
        picMain.Refresh()
        RedrawEditor()
    End Sub

    Private Sub btnEditorRRight_Click(sender As Object, e As EventArgs) Handles btnEditorRRight.Click
        If IsNothing(picMain.Image) Then
            Exit Sub
        End If
        Dim bmp As Bitmap = picMain.Image
        Dim m, n As Integer
        Dim c As Color
        For n = 0 To cellHeight - 1
            c = bmp.GetPixel(currCellX * (cellWidth + 1) + cellWidth - 1, currCellY * (cellHeight + 1) + n)
            For m = cellWidth - 2 To 0 Step -1
                bmp.SetPixel(currCellX * (cellWidth + 1) + m + 1, currCellY * (cellHeight + 1) + n, bmp.GetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + n))
            Next
            bmp.SetPixel(currCellX * (cellWidth + 1), currCellY * (cellHeight + 1) + n, c)
        Next
        picMain.Refresh()
        RedrawEditor()
    End Sub

    Private Sub cboImportCodepage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboImportCodepage.SelectedIndexChanged
        setCodepageSize(cboImportCodepage.Text, txtImportSizeW, txtImportSizeH)
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        insertRAW(txtInsertStart.Text, txtInsertEnd.Text)
        RedrawEditor()
    End Sub

    Private Sub btnImportClean_Click(sender As Object, e As EventArgs) Handles btnEditClean.Click
        cleanArea(txtMoveStart.Text, txtMoveEnd.Text)
        RedrawEditor()
    End Sub

    Private Function loc2x(loc As Integer) As Integer
        loc2x = loc Mod codeWidth
    End Function

    Private Function loc2y(loc As Integer) As Integer
        loc2y = Int(loc / codeWidth)
    End Function

    Private Sub CopyCell(locSource As Integer, locDest As Integer, isCopyMoveExchange As Integer)
        Dim max = codeWidth * codeHeight - 1
        If locSource > max Or locSource < 0 Then
            Exit Sub
        End If
        If locDest > max Or locDest < 0 Then
            Exit Sub
        End If
        If locSource = locDest Then
            Exit Sub
        End If
        Dim bmp As Bitmap = picMain.Image
        Dim bmpTemp As New Bitmap(cellWidth, cellHeight)
        Dim grp As Graphics = Graphics.FromImage(bmp)
        Dim grpTemp As Graphics = Graphics.FromImage(bmpTemp)
        Dim dx = loc2x(locDest) * (cellWidth + 1)
        Dim dy = loc2y(locDest) * (cellHeight + 1)
        Dim sx = loc2x(locSource) * (cellWidth + 1)
        Dim sy = loc2y(locSource) * (cellHeight + 1)
        If isCopyMoveExchange = 2 Then
            grpTemp.DrawImage(bmp, New Rectangle(0, 0, cellWidth, cellHeight), New Rectangle(dx, dy, cellWidth, cellHeight), GraphicsUnit.Pixel)
        End If
        grp.DrawImage(bmp, New Rectangle(dx, dy, cellWidth, cellHeight), New Rectangle(sx, sy, cellWidth, cellHeight), GraphicsUnit.Pixel)
        'grp.DrawImageUnscaled()
        If isCopyMoveExchange = 1 Then 'move
            grp.FillRectangle(New SolidBrush(Color.White), New Rectangle(sx, sy, cellWidth, cellHeight))
        ElseIf isCopyMoveExchange = 2 Then 'exchange
            grp.DrawImage(bmpTemp, New Rectangle(sx, sy, cellWidth, cellHeight), New Rectangle(0, 0, cellWidth, cellHeight), GraphicsUnit.Pixel)
        End If

    End Sub
    Private Sub startProgress(m As Integer)
        progressBar.Maximum = m
        progressBar.Visible = True
        progressBar.Value = 0
    End Sub

    Private Sub goProgress(v As Integer)
        progressBar.Value = v
    End Sub

    Private Sub endProgress()
        progressBar.Visible = False
    End Sub

    Private Sub CopyCells(codeStart As String, codeEnd As String, codeTo As String, isCopyMoveExchange As Integer)
        Dim cdStart = code2loc(codeStart)
        Dim cdEnd = code2loc(codeEnd)
        Dim cdTo = code2loc(codeTo)
        Dim cdSize = cdEnd - cdStart + 1
        If cdEnd < cdStart Then
            Exit Sub
        End If
        Dim i As Integer
        startProgress(cdSize)
        If cdTo > cdEnd Or cdTo < cdStart Then
            For i = 0 To cdSize - 1
                CopyCell(i + cdStart, i + cdTo, isCopyMoveExchange)
                goProgress(i + 1)
                Application.DoEvents()
            Next
        ElseIf cdTo <= cdEnd And cdTo > cdStart Then
            For i = cdSize - 1 To 0 Step -1
                CopyCell(i + cdStart, i + cdTo, isCopyMoveExchange)
                goProgress(cdSize - i)
            Next
        End If
        endProgress()
        picMain.Refresh()
    End Sub

    Private Sub btnMoveCode_Click(sender As Object, e As EventArgs) Handles btnMoveCode.Click
        CopyCells(txtMoveStart.Text, txtMoveEnd.Text, txtMoveTo.Text, 1)
        RedrawEditor()
    End Sub

    Private Sub btnCopyCode_Click(sender As Object, e As EventArgs) Handles btnCopyCode.Click
        CopyCells(txtMoveStart.Text, txtMoveEnd.Text, txtMoveTo.Text, 0)
        RedrawEditor()
    End Sub

    Private Sub btnEditorInverse_Click(sender As Object, e As EventArgs) Handles btnEditorInverse.Click
        If IsNothing(picMain.Image) Then
            Exit Sub
        End If
        If currCellX < 0 Or currCellX >= codeWidth Then
            Exit Sub
        End If
        If currCellY < 0 Or currCellY >= codeHeight Then
            Exit Sub
        End If
        Dim bmp As Bitmap = picMain.Image
        Dim c As Color
        Dim d As Color
        For n = 0 To cellHeight - 1
            For m = 0 To cellWidth - 1
                c = bmp.GetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + n)
                d = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B)
                bmp.SetPixel(currCellX * (cellWidth + 1) + m, currCellY * (cellHeight + 1) + n, d)
            Next
        Next
        picMain.Refresh()
        RedrawEditor()
    End Sub

    Private Sub btnOpenSave_Click(sender As Object, e As EventArgs) Handles btnOpenSave.Click
        savePNG()
    End Sub

    Private Sub picMain_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles picMain.MouseDoubleClick
        txtMoveTo.Text = loc2code(Int((e.X) / (cellWidth + 1)), Int((e.Y) / (cellHeight + 1)))
        picMain_MouseClick(sender, e)
    End Sub

    Private Sub btnDrawLines_Click(sender As Object, e As EventArgs) Handles btnDrawLines.Click
        drawHeadAndLine()
        RedrawEditor()
    End Sub

    Private Sub hsbThresholdBW_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbThresholdBW.Scroll
        lblThresholdBW.BackColor = Color.FromArgb(255 << 24 + hsbThresholdBW.Value << 16 + hsbThresholdBW.Value << 8 + hsbThresholdBW.Value)
    End Sub

    Private Sub split_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles split.SplitterMoved
        'If isResizing = False Then
        resizeAll()
        'End If
    End Sub
    Private Sub btnExchange_Click(sender As Object, e As EventArgs) Handles btnExchange.Click
        CopyCells(txtMoveStart.Text, txtMoveEnd.Text, txtMoveTo.Text, 2)
    End Sub

    Private Sub picMain_Click(sender As Object, e As EventArgs) Handles picMain.Click

    End Sub

    Private Sub picMain_MouseWheel(sender As Object, e As MouseEventArgs) Handles picMain.MouseWheel
        If isCtrlPress Then
            If e.Delta > 0 Then
                zoomInOut += 1
                If zoomInOut > 8 Then
                    zoomInOut = 8
                End If
                resizeAll()
            End If
            If e.Delta < 0 Then
                zoomInOut -= 1
                If zoomInOut < 0 Then
                    zoomInOut = 0
                End If
                resizeAll()
            End If
        End If
    End Sub
End Class
