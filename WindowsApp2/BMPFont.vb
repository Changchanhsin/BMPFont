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
    Private codeWidth As Integer = 0
    Private codeHeight As Integer = 0

    Private currCellX As Integer = -1
    Private currCellY As Integer = -1

    Private bmpDigitalL(16) As Bitmap
    Private bmpDigitalS(16) As Bitmap
    Private bmpHead As New Bitmap(13, 13)
    Private bmpClipboard As New Bitmap(1, 1)

    Private isShiftPress As Boolean

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

        Dim mFont As Font
        mFont = New Font(txtFontName.Text, size)
        Dim currChar(5) As Byte
        Dim unicodeString As String
        Dim bmp As New Bitmap(cellWidth, cellHeight)
        Dim grp As Graphics = Graphics.FromImage(bmp)
        Dim brs As New SolidBrush(Color.White)
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
        Next
        brs.Dispose()
        mFont.Dispose()
        bmp.Dispose()
        mBrush.Dispose()
        picMain.Refresh()
    End Sub

    Private Sub drawHead(dt As Integer, x As Integer, y As Integer)
        For i As Integer = 0 To 7
            'If ((dt Mod 2) Xor ((x + i + y) Mod 2)) = 0 Then
            '            If ((dt Mod 2)) = 0 Then
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
        drawHead(codePage / 256, 2, 2)
        drawHead(codePage Mod 256, 2, 3)
        drawHead(cellWidth, 2, 4)
        drawHead(cellHeight, 2, 5)
        drawHead(codeWidth, 2, 6)
        drawHead(codeHeight, 2, 7)
        drawHead(codeUltraHigh, 2, 8)
        drawHead(0, 2, 9)
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
        SetRange(codePage, codeWidth, codeHeight)
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
                codeLowRange = {0, 255}
                codeHighRange = {0, 255}
                codeLength = 2
        End Select
    End Sub

    Private Function mapW(ByRef map()) As Integer
        mapW = 0
    End Function

    Private Sub cleanArea(sc As String, ec As String)
        Dim bmp As New Bitmap(cellWidth, cellHeight)
        Dim grp = Graphics.FromImage(bmp)
        grp.FillRectangle(New SolidBrush(Color.White), 0, 0, cellWidth, cellHeight)
        Dim grpMain As Graphics = Graphics.FromImage(picMain.Image)
        Dim s As Integer = code2loc(sc)
        Dim e As Integer = code2loc(ec)
        If e < s Then
            Exit Sub
        End If
        For j = 0 To codeHeight
            For i = 0 To codeWidth
                If j * codeWidth + i >= s And j * codeWidth + i <= e Then
                    grpMain.DrawImage(bmp, i * (cellWidth + 1), j * (cellHeight + 1))
                End If
            Next
        Next
        picMain.Update()
        picMain.Refresh()
    End Sub

    Private Sub createArray(cp As Integer, width As Integer, height As Integer)
        Dim mapW(256) As Integer
        Dim mapH(256) As Integer
        For i = 0 To 255
            mapW(i) = 0
            mapH(i) = 0
            codeL(i) = 0
            codeH(i) = 0
        Next
        Dim sizeW As Integer = 0
        Dim sizeH As Integer = 0
        For i = 0 To codeLowRange.Length - 1 Step 2
            sizeW = sizeW + codeLowRange(i + 1) - codeLowRange(i) + 1
            For j = codeLowRange(i) To codeLowRange(i + 1)
                mapW(j) = 1
            Next
        Next
        For i = 0 To codeHighRange.Length - 1 Step 2
            sizeH = sizeH + codeHighRange(i + 1) - codeHighRange(i) + 1
            For j = codeHighRange(i) To codeHighRange(i + 1)
                mapH(j) = 1
            Next
        Next
        Dim xC As Integer = 0
        Dim yC As Integer = 0
        For i = 0 To 255
            If mapW(i) = 1 Then
                codeL(xC) = i
                xC = xC + 1
            End If
            If mapH(i) = 1 Then
                codeH(yC) = i
                yC = yC + 1
            End If
        Next

        Dim bmpV As New Bitmap(13, sizeH * (height + 1) + 1)
        Dim bmpH As New Bitmap(sizeW * (width + 1) + 1, 13)
        Dim bmpMain As New Bitmap(sizeW * (width + 1) + 1, sizeH * (height + 1) + 1)

        cellWidth = width
        cellHeight = height
        codeWidth = sizeW
        codeHeight = sizeH
        codePage = cp

        Dim grpOutputHead As Graphics = Graphics.FromImage(bmpHead)
        grpOutputHead.DrawLine(Pens.Blue, 0, 12, 12, 12)
        grpOutputHead.DrawLine(Pens.Blue, 12, 0, 12, 12)
        picHead.Image = bmpHead
        printHead()
        picHead.Refresh()

        Dim grpOutputV As Graphics = Graphics.FromImage(bmpV)
        Dim grpOutputH As Graphics = Graphics.FromImage(bmpH)
        Dim grpOutputMain As Graphics = Graphics.FromImage(bmpMain)
        grpOutputV.FillRectangle(New SolidBrush(Color.White), 0, 0, bmpV.Width, bmpV.Height)
        grpOutputH.FillRectangle(New SolidBrush(Color.White), 0, 0, bmpH.Width, bmpH.Height)
        grpOutputMain.FillRectangle(New SolidBrush(Color.White), 0, 0, bmpMain.Width, bmpMain.Height)
        Dim iCount = 0
        For i = 0 To 255
            If mapW(i) = 1 Then
                grpOutputH.DrawLine(Pens.Blue, iCount * (width + 1) - 1, 0, iCount * (width + 1) - 1, 12)
                If (width >= 18) Then
                    If codeLength >= 2 Then
                        grpOutputH.DrawImage(bmpDigitalL(Int(i / 16)), 2 + iCount * (width + 1), 3)
                        grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 10 + iCount * (width + 1), 3)
                    Else
                        grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 2 + iCount * (width + 1), 3)
                    End If
                ElseIf (width >= 16) Then
                    If codeLength >= 2 Then
                        grpOutputH.DrawImage(bmpDigitalL(Int(i / 16)), 2 + iCount * (width + 1), 3)
                        grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 8 + iCount * (width + 1), 3)
                    Else
                        grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 2 + iCount * (width + 1), 3)
                    End If
                ElseIf (width >= 8) Then
                    If codeLength >= 2 Then
                        grpOutputH.DrawImage(bmpDigitalS(Int(i / 16)), 1 + iCount * (width + 1), 3)
                        grpOutputH.DrawImage(bmpDigitalS(i Mod 16), 5 + iCount * (width + 1), 3)
                    Else
                        grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 1 + iCount * (width + 1), 3)
                    End If
                ElseIf (width >= 6) Then
                    If codeLength >= 2 Then
                        grpOutputH.DrawImage(bmpDigitalS(Int(i / 16)), 2 + iCount * (width + 1), 0)
                        grpOutputH.DrawImage(bmpDigitalS(i Mod 16), 2 + iCount * (width + 1), 6)
                    Else
                        grpOutputH.DrawImage(bmpDigitalS(i Mod 16), 2 + iCount * (width + 1), 4)
                    End If
                End If
                grpOutputMain.DrawLine(Pens.Blue, iCount * (width + 1) - 1, 0, iCount * (width + 1) - 1, sizeH * (height + 1) - 1)
                iCount = iCount + 1
            End If
        Next
        grpOutputH.DrawLine(Pens.Blue, sizeW * (width + 1) - 1, 0, sizeW * (width + 1) - 1, 12)
        grpOutputMain.DrawLine(Pens.Blue, sizeW * (width + 1) - 1, 0, sizeW * (width + 1) - 1, sizeH * (height + 1) - 1)

        iCount = 0
        For i = 0 To 255
            If mapH(i) = 1 Then
                grpOutputV.DrawLine(Pens.Blue, 0, iCount * (height + 1) - 1, 12, iCount * (height + 1) - 1)
                If (height >= 18) Then
                    If codeLength >= 2 Then
                        grpOutputV.DrawImage(bmpDigitalL(Int(i / 16)), 5, 2 + iCount * (height + 1))
                        grpOutputV.DrawImage(bmpDigitalL(i Mod 16), 5, 10 + iCount * (height + 1))
                    Else
                        grpOutputV.DrawImage(bmpDigitalL(i Mod 16), 5, 2 + iCount * (height + 1))
                    End If
                ElseIf (height >= 10) Then
                    If codeLength >= 2 Then
                        grpOutputV.DrawImage(bmpDigitalL(Int(i / 16)), 0, 2 + iCount * (height + 1))
                    End If
                    grpOutputV.DrawImage(bmpDigitalL(i Mod 16), 6, 2 + iCount * (height + 1))
                ElseIf (height >= 8) Then
                    If codeLength >= 2 Then
                        grpOutputV.DrawImage(bmpDigitalS(Int(i / 16)), 2, 2 + iCount * (height + 1))
                    End If
                    grpOutputV.DrawImage(bmpDigitalS(i Mod 16), 6, 2 + iCount * (height + 1))
                ElseIf (height >= 6) Then
                    If codeLength >= 2 Then
                        grpOutputV.DrawImage(bmpDigitalS(Int(i / 16)), 2, 1 + iCount * (height + 1))
                    End If
                    grpOutputV.DrawImage(bmpDigitalS(i Mod 16), 6, 1 + iCount * (height + 1))
                End If
                grpOutputMain.DrawLine(Pens.Blue, 0, iCount * (height + 1) - 1, sizeW * (width + 1) - 1, iCount * (height + 1) - 1)
                iCount = iCount + 1
            End If
        Next
        grpOutputV.DrawLine(Pens.Blue, 0, sizeH * (height + 1) - 1, 12, sizeH * (height + 1) - 1)
        grpOutputMain.DrawLine(Pens.Blue, 0, sizeH * (height + 1) - 1, sizeW * (width + 1) - 1, sizeH * (height + 1) - 1)

        grpOutputV.DrawLine(Pens.Blue, 12, 0, 12, sizeH * (height + 1) - 1)
        grpOutputH.DrawLine(Pens.Blue, 0, 12, sizeW * (width + 1) - 1, 12)
        If Not IsNothing(picV.Image) Then
            picV.Image.Dispose()
        End If
        picV.Image = bmpV
        picV.Width = 13
        picV.Height = sizeH * (height + 1)
        picV.Refresh()
        If Not IsNothing(picH.Image) Then
            picH.Image.Dispose()
        End If
        picH.Image = bmpH
        picH.Width = sizeW * (width + 1)
        picH.Height = 13
        picH.Refresh()
        If Not IsNothing(picMain.Image) Then
            picMain.Image.Dispose()
        End If
        picMain.Image = bmpMain
        picMain.Width = sizeW * (width + 1)
        picMain.Height = sizeH * (height + 1)
        picMain.Refresh()
        updateInfoData()
        updateActiveData()

    End Sub

    Private Sub NewFont(codepage_name)
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
                codeLowRange = {0, in0255(txtNewSizeW.Text - 1)}
                codeHighRange = {0, in0255(txtNewSizeH.Text - 1)}
                codePage = 0
                codeLength = 2
        End Select

    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        NewFont(cboCodepage.SelectedItem)
        createArray(codePage, txtNewWidth.Text, txtNewHeight.Text)
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
            Case ".XML"
                saveXML()
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
            Dim bmp As Bitmap = picMain.Image

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
                                c = bmp.GetPixel(i * (cellWidth + 1) + l, j * (cellHeight + 1) + k)
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
            Dim bmp As Bitmap = picMain.Image

            Dim FS As New System.IO.FileStream(txtSaveImagePath.Text & "\" & txtSaveImage.Text, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.Write)
            Dim Bw As New System.IO.BinaryWriter(FS)

            Dim i, j, k, l
            Dim c As Color
            Dim d As Byte
            For j = HexStrToLong(txtCodeRangeStart.Text) To HexStrToLong(txtCodeRangeEnd.Text)
                For i = 0 To codeWidth - 1
                    For k = 0 To cellHeight - 1
                        For l = 0 To cellWidth - 1
                            c = bmp.GetPixel(i * (cellWidth + 1) + l, j * (cellHeight + 1) + k)
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
            Dim bmp As Bitmap = picMain.Image

            Dim FS As New System.IO.FileStream(txtSaveImagePath.Text & "\" & txtSaveImage.Text, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.Write)
            Dim Bw As New System.IO.BinaryWriter(FS)

            Dim i, j, k, l
            Dim c As Color
            Dim d As Byte
            For j = 0 To codeHeight - 1
                For i = 0 To codeWidth - 1
                    For k = 0 To cellHeight - 1
                        For l = 0 To cellWidth - 1
                            c = bmp.GetPixel(i * (cellWidth + 1) + l, j * (cellHeight + 1) + k)
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
            MessageBox.Show("Error on save RAW file : " & ex2.Message)
        End Try
    End Sub

    Private Sub savePNGs()
        picSave.Visible = False
        picSave.Width = cellWidth
        picSave.Height = cellHeight
        Dim srcSize As Rectangle
        srcSize.Width = cellWidth
        srcSize.Height = cellHeight
        Dim bmpSave As New Bitmap(picSave.Width, picSave.Height)
        Dim grpSave As Graphics = Graphics.FromImage(bmpSave)
        For j = 0 To codeHeight - 1
            For i = 0 To codeWidth - 1
                srcSize.X = i * (cellWidth + 1)
                srcSize.Y = j * (cellHeight + 1)
                grpSave.DrawImage(picMain.Image, 0, 0, srcSize, GraphicsUnit.Pixel)
                picSave.Image = bmpSave
                Try
                    picSave.Image.Save(txtSaveImagePath.Text & "\" & txtSaveImage.Text & "." & hexstr(j, codeLength / 2) & hexstr(i, codeLength / 2) & ".FONT.PNG")
                Catch ex As Exception

                End Try
            Next
        Next
        If Not IsNothing(picSave.Image) Then
            picSave.Image.Dispose()
        End If
        picSave.Image = bmpSave
        picSave.Refresh()
        bmpSave.Dispose()
    End Sub

    Private Sub savePNG()
        picSave.Visible = False
        '        picSave.Width = picHead.Width + picMain.Width
        '       picSave.Height = picHead.Height + picMain.Height
        Dim bmpSave As New Bitmap(picHead.Width + picMain.Width, picHead.Height + picMain.Height)
        Dim grpSave As Graphics = Graphics.FromImage(bmpSave)
        grpSave.DrawImage(picHead.Image, 0, 0)
        grpSave.DrawImage(picH.Image, 13, 0)
        grpSave.DrawImage(picV.Image, 0, 13)
        grpSave.DrawImage(picMain.Image, 13, 13)
        If Not IsNothing(picSave.Image) Then
            picSave.Image.Dispose()
        End If
        picSave.Image = bmpSave
        'picSave.Update()
        '        picSave.Refresh()
        Try
            Dim fn = txtSaveImagePath.Text & "\" & txtSaveImage.Text & ".FONT.PNG"
            picSave.Image.Save(fn)
            bmpSave.Dispose()
        Catch ex As Exception
            MessageBox.Show("error save:" & ex.Message)
        End Try
    End Sub

    Private Function loc2code(x, y) As String
        loc2code = Hex(codeH(y)) & Hex(codeL(x))
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
        Next

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
        Next

        '    currCellX = oldX
        '  currCellY = oldY
        cboCopyType.Text = oldType

        RedrawEditor()
    End Sub

    Private Function bmp2xmltext(bmp As Bitmap, x As Integer, y As Integer) As String
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

        bmp2xmltext = xd.ToString()
    End Function
    Private Sub saveXML()
        Dim oldType = cboCopyType.Text
        '        Dim oldX = currCellX
        '      Dim oldY = currCellY
        cboCopyType.Text = "SVG"
        Dim i, j
        Dim s As String
        '        Dim FS As New System.IO.FileStream(txtSaveImagePath.Text & "\" & txtSaveImage.Text & "." & hexstr(j, codeLength) & hexstr(i, codeLength) & ".SVG", IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.Write)
        For j = 0 To codeHeight - 1
            For i = 0 To codeWidth - 1
                '            currCellX = i
                '          currCellY = j
                '        RedrawEditor()
                s = bmp2xmltext(picMain.Image, i, j)
                Dim b = System.Text.Encoding.UTF8.GetBytes(s)
                '               FS.Write(b, 0, UBound(b) + 1)
            Next
        Next
        '      FS.Close()

        '        currCellX = oldX
        '      currCellY = oldY
        cboCopyType.Text = oldType

        RedrawEditor()
    End Sub

    Private Sub importFontPNG()
        Try
            Dim fs As System.IO.FileStream
            fs = New System.IO.FileStream(txtImportFileName.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read)
            picHead.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            Dim bmpFont As Bitmap = picHead.Image
            Dim bmpV As New Bitmap(13, picHead.Image.Height - 13)
            Dim bmpH As New Bitmap(picHead.Image.Width - 13, 13)
            Dim bmpMain As New Bitmap(picHead.Image.Width - 13, picHead.Image.Height - 13)
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
            For t = 0 To codeHeight - 1
                For l = 0 To codeWidth - 1
                    If t * codeWidth + l >= startLoc And t * codeWidth + 1 <= endloc Then
                        readBs = Bw.ReadBytes(widthBytes * cellHeight)
                        If readBs.Length = 0 Then
                            If codePage = 0 Then
                                codeHeight = t + 1
                                codeHighRange(1) = codeHeight - 1
                                Dim bmpOldMain As Bitmap = picMain.Image
                                Dim h As Integer = (t + 1) * (Height + 1)
                                Dim bmpNew As Bitmap = New Bitmap(bmpOldMain.Width, h)
                                bmpNew = bmpOldMain.Clone(New Rectangle(0, 0, bmpNew.Width, bmpNew.Height), Imaging.PixelFormat.DontCare)
                                picMain.Image = bmpNew
                                bmpOldMain.Dispose()
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
            Next
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

        NewFont(cp)
        '            codeLowRange = {0, sizeW - 1}
        '           codeHighRange = {0, sizeH - 1}
        createArray(codePage, width, height)
        insertRAW(st, ed)
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Select Case cboImportType.Text
            Case ".FONT.PNG"
                importFontPNG()
            Case ".HZCG6"
                'importHZCG6()
            Case Else
                importRAW(txtImportWidth.Text, txtImportHeight.Text, txtImportSizeW.Text, txtImportSizeH.Text, cboImportCodepage.Text, txtInsertStart.Text, txtInsertEnd.Text)
        End Select

        resizeAll()
        updateInfoData()
        updateActiveData()
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
        If e.X < 0 Or e.Y < 0 Or e.X >= picMain.Width Or e.Y >= picMain.Height Then
            Exit Sub
        End If
        btnCopyCharImage.Select()
        SelectChar(Int((e.X) / (cellWidth + 1)), Int((e.Y) / (cellHeight + 1)))
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
        resizeAll()
        cboCodepage.SelectedIndex = 0
        cboSaveFileType.SelectedIndex = 0
        cboImportType.SelectedIndex = 0
        cboCopyType.SelectedIndex = 0
        getFontList()
        txtSaveImagePath.Text = Application.StartupPath
        Me.KeyPreview = True
    End Sub

    Private Sub resizeTab()
        'Dim tab_maxwidth
        'create
        'tab_maxwidth = tagCreate.Size.Width - picEdit.Left
        'cboCodepage.Width = tab_maxwidth - cboCodepage.Left
        'btnCreate.Width = tab_maxwidth - btnCreate.Left
        'txtFontName.Width = tab_maxwidth - txtFontName.Left
        'btnInitCharactors.Width = tab_maxwidth - btnInitCharactors.Left
        ' open
        'tab_maxwidth = tagOpen.Size.Width - picEdit.Left
        'txtImportFileName.Width = tab_maxwidth - txtImportFileName.Left
        'cboImportType.Width = tab_maxwidth - cboImportType.Left
        'btnImport.Width = tab_maxwidth - btnImport.Left
        ' save
        'tab_maxwidth = tagSave.Size.Width - picEdit.Left
        'txtSaveImagePath.Width = tab_maxwidth - txtSaveImagePath.Left
        'txtSaveImage.Width = tab_maxwidth - txtSaveImage.Left
        'cboSaveFileType.Width = tab_maxwidth - cboSaveFileType.Left
        'btnSave.Width = tab_maxwidth - btnSave.Left
    End Sub

    Private Sub resizeAll()
        tabControl.Width = split.Panel2.Width

        '        picHead.Left = 0
        '       picHead.Top = 0
        '      pnlV.Top = 13
        '     pnlV.Width = 13
        '    picV.Left = 0
        '   pnlH.Left = 13
        '  pnlH.Height = 13
        ' picH.Top = 0
        'pnlMain.Width = split.Panel1.Width - pnlMain.Left
        'pnlMain.Height = split.Panel1.Height - pnlMain.Top
        'picEdit.Width = split.Panel2.Width - 2 * picEdit.Left
        'picEdit.Height = split.Panel2.Height - picEdit.Top - 2 * picEdit.Left - chkGrid.Height
        'chkGrid.Top = split.Panel2.Height - chkGrid.Height
        'chkRound.Top = chkGrid.Top
        'chkGap.Top = chkGrid.Top
        RedrawEditor()
        'lblBackColor.Left = split.Panel2.Width - lblBackColor.Width
        'lblBackColor.Top = split.Panel2.Height - lblBackColor.Height
        'lblForeColor.Left = lblBackColor.Left - lblForeColor.Width
        'lblForeColor.Top = lblBackColor.Top
        resizeTab()
        'edit
        'btnCopyCharImage.Width = split.Panel2.Width - btnCopyCharImage.Left
        'btnPasteImage.Width = split.Panel2.Width - btnPasteImage.Left
    End Sub

    Private Sub frmBMPFont_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        resizeAll()
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
        resizeAll()
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

        For i = 0 To codeWidth - 1
            For j = 0 To codeHeight - 1
                rectNew.X = i * (rectNew.Width + 1)
                rectNew.Y = j * (rectNew.Height + 1)
                rectOld.X = i * (rectOld.Width + 1)
                rectOld.Y = j * (rectOld.Width + 1)
                grpNew.DrawImage(bmp, rectNew, rectOld, GraphicsUnit.Pixel)
            Next
        Next
        bmp.Dispose()
        picMain.Refresh()
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
        Next
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
        Next
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
    End Sub

    Private Sub btnImportClean_Click(sender As Object, e As EventArgs) Handles btnImportClean.Click
        cleanArea(txtMoveStart.Text, txtMoveEnd.Text)
    End Sub

    Private Function loc2x(loc As Integer) As Integer
        loc2x = loc Mod codeWidth
    End Function

    Private Function loc2y(loc As Integer) As Integer
        loc2y = Int(loc / codeWidth)
    End Function

    Private Sub CopyCell(locSource As Integer, locDest As Integer, isCopy As Boolean)
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
        Dim grp As Graphics = Graphics.FromImage(bmp)
        Dim dx = loc2x(locDest) * (cellWidth + 1)
        Dim dy = loc2y(locDest) * (cellHeight + 1)
        Dim sx = loc2x(locSource) * (cellWidth + 1)
        Dim sy = loc2y(locSource) * (cellHeight + 1)
        grp.DrawImage(bmp, New Rectangle(dx, dy, cellWidth, cellHeight), New Rectangle(sx, sy, cellWidth, cellHeight), GraphicsUnit.Pixel)
        If isCopy = False Then
            grp.FillRectangle(New SolidBrush(Color.White), New Rectangle(sx, sy, cellWidth, cellHeight))
        End If
    End Sub

    Private Sub CopyCells(codeStart As String, codeEnd As String, codeTo As String, isCopy As Boolean)
        Dim cdStart = code2loc(codeStart)
        Dim cdEnd = code2loc(codeEnd)
        Dim cdTo = code2loc(codeTo)
        Dim cdSize = cdEnd - cdStart + 1
        If cdEnd < cdStart Then
            Exit Sub
        End If
        Dim i As Integer
        If cdTo > cdEnd Or cdTo < cdStart Then
            For i = 0 To cdSize - 1
                CopyCell(i + cdStart, i + cdTo, isCopy)
            Next
        ElseIf cdTo <= cdEnd And cdTo > cdStart Then
            For i = cdSize - 1 To 0 Step -1
                CopyCell(i + cdStart, i + cdTo, isCopy)
            Next
        End If
        picMain.Refresh()
    End Sub

    Private Sub btnMoveCode_Click(sender As Object, e As EventArgs) Handles btnMoveCode.Click
        CopyCells(txtMoveStart.Text, txtMoveEnd.Text, txtMoveTo.Text, False)
    End Sub

    Private Sub btnCopyCode_Click(sender As Object, e As EventArgs) Handles btnCopyCode.Click
        CopyCells(txtMoveStart.Text, txtMoveEnd.Text, txtMoveTo.Text, True)
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

    Private Sub picMain_Click(sender As Object, e As EventArgs) Handles picMain.Click

    End Sub
End Class
