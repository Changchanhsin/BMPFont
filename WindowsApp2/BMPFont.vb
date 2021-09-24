Public Class frmBMPFont
    Private fontName As String = ""
    Private codePage As Integer = 0 '0=raw/unknown;1200=usc;932=shift_jis;936=gb2312;950=big5;1252=ascii
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
                    currChar(0) = &HF0
                    currChar(1) = &H80 + (codeUltraHigh << 4) + (codeH(i) >> 4)
                    currChar(2) = &H80 + ((codeH(i) And &HF) << 2) + (codeL(j) >> 6)
                    currChar(3) = &H80 + (codeL(j) And &H3F)
                    'currChar(0) = 0
                    'currChar(1) = codeUltraHigh
                    'currChar(2) = codeH(j)
                    'currChar(3) = codeL(i)
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
        drawHead(0, 2, 8)
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
        lblInfo.Text = "Cell:" & cellWidth & " x " & cellHeight
        lblCode.Text = "Codepage:" & codePage
    End Sub


    Private Sub Create_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        Select Case cboCodepage.SelectedItem
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
        createArray(codePage, txtNewWidth.Text, txtNewHeight.Text)
    End Sub

    Private Sub picMain_Move(sender As Object, e As EventArgs) Handles picMain.Move
        picH.Left = picMain.Left
        picV.Top = picMain.Top
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Select Case cboSaveFileType.Text
            Case ".HZCG6"

            Case ".CODE.PNG(多个)"
                savePNGs()
            Case "RAW"
                saveRAW()
            Case Else
                savePNG()
        End Select
    End Sub

    Private Sub saveRAW()
        Dim i, j, k, l
        Dim c As Color
        Dim d As Byte
        Try
            Dim bmp As Bitmap = picMain.Image

            Dim FS As New System.IO.FileStream(txtSaveImagePath.Text & "\" & txtSaveImage.Text, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.Write)
            Dim Bw As New System.IO.BinaryWriter(FS)

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
                    picSave.Image.Save(txtSaveImagePath.Text & "\" & txtSaveImage.Text & "." & codeH(j) & codeL(i) & ".FONT.PNG")
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
        picSave.Width = picHead.Width + picMain.Width
        picSave.Height = picHead.Height + picMain.Height
        Dim bmpSave As New Bitmap(picSave.Width, picSave.Height)
        Dim grpSave As Graphics = Graphics.FromImage(bmpSave)
        grpSave.DrawImage(picHead.Image, 0, 0)
        grpSave.DrawImage(picH.Image, 13, 0)
        grpSave.DrawImage(picV.Image, 0, 13)
        grpSave.DrawImage(picMain.Image, 13, 13)
        If Not IsNothing(picSave.Image) Then
            picSave.Image.Dispose()
        End If
        picSave.Image = bmpSave
        picSave.Refresh()
        Try
            Dim fn = txtSaveImagePath.Text & "\" & txtSaveImage.Text & ".FONT.PNG"
            picSave.Image.Save(txtSaveImagePath.Text & "\" & txtSaveImage.Text & ".FONT.PNG")
            bmpSave.Dispose()
        Catch ex As Exception
            MessageBox.Show("error")
        End Try
    End Sub

    Private Sub importFontPNG()
        Try
            picHead.ImageLocation = txtImportFileName.Text
            picHead.Load()
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
            picHead.Image = bmpHead
            readHead()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub importRAW(width As Integer, height As Integer, sizeW As Integer, sizeH As Integer)

        Try

            Dim FS As New System.IO.FileStream(txtImportFileName.Text, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)

            Dim Bw As New System.IO.BinaryReader(FS)
            Dim readBs As Byte()
            Dim bmp = New Bitmap(width, height)

            codeLowRange = {0, sizeW - 1}
            codeHighRange = {0, sizeH - 1}
            createArray(0, width, height)


            FS.Seek(txtImportOffset.Text, IO.SeekOrigin.Begin)
            Dim widthBytes As Integer = Int((width + 7) / 8)
            cellWidth = width
            cellHeight = height
            codeWidth = sizeW
            codeHeight = sizeH
            codePage = 0
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
            For t = 0 To sizeH - 1
                For l = 0 To sizeW - 1
                    readBs = Bw.ReadBytes(widthBytes * height)
                    If readBs.Length = 0 Then
                        codeHeight = t + 1
                        codeHighRange(1) = codeHeight - 1
                        Dim bmpOldMain As Bitmap = picMain.Image
                        Dim h As Integer = (t + 1) * (height + 1)
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
                        FS.Close()
                        Exit Sub
                    End If
                    For j = 0 To (readBs.Length + 1) / widthBytes - 1 ' height - 1
                        For i = 0 To width - 1 'widthBytes * 8 - 1
                            If (j * widthBytes + Int(i / 8)) < readBs.Length Then
                                If ((readBs(j * widthBytes + Int(i / 8)) >> (7 - (i Mod 8))) Mod 2) = 1 Then
                                    bmp.SetPixel(i, j, c1)
                                Else
                                    bmp.SetPixel(i, j, c0)
                                End If
                            End If
                        Next
                    Next
                    grpMain.DrawImage(bmp, l * (width + 1), t * (height + 1))
                Next
            Next
            picMain.Refresh()
            printHead()
            FS.Close()
        Catch ex2 As Exception
            MessageBox.Show("Error on open RAW file : " & vbCrLf & ex2.Message & vbCrLf & ex2.StackTrace)
            picMain.Refresh()
            Exit Sub
        End Try

    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Select Case cboImportType.Text
            Case ".FONT.PNG"
                importFontPNG()
            Case ".HZCG6"
                'importHZCG6()
            Case Else
                importRAW(txtImportWidth.Text, txtImportHeight.Text, txtImportSizeW.Text, txtImportSizeH.Text)
        End Select

        resizeAll()
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
        Dim grpD = Graphics.FromImage(picMain.Image)
        grpD.DrawRectangle(New Pen(Color.Blue), currCellX * (cellWidth + 1) - 1, currCellY * (cellHeight + 1) - 1, cellWidth + 1, cellHeight + 1)
        currCellX = Int((e.X) / (cellWidth + 1))
        currCellY = Int((e.Y) / (cellHeight + 1))
        lblCode.Text = "Codepage:" & codePage & " Code:" & Strings.Right("00" & Hex(codeH(currCellY)), 2) & Strings.Right("00" & Hex(codeL(currCellX)), 2)
        lblColRow.Text = "Edit: " & currCellX & "(" & Strings.Right("00" & Hex(currCellX), 2) & ") " & currCellY & "(" & Strings.Right("00" & Hex(currCellY), 2) & ")"
        grpD.DrawRectangle(New Pen(Color.Red), currCellX * (cellWidth + 1) - 1, currCellY * (cellHeight + 1) - 1, cellWidth + 1, cellHeight + 1)
        picMain.Refresh()
        RedrawEditor()
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
        Dim a As Single = (picEdit.Width - 1) / cellWidth
        Dim b As Single = (picEdit.Height - 1) / cellHeight

        If chkRound.Checked = False Then
            For j = 0 To cellHeight - 1
                For i = 0 To cellWidth - 1
                    grpD.FillRectangle(New SolidBrush(bmp.GetPixel(i, j)), i * a, j * b, a, b)
                    If chkGrid.checked = True Then
                        grpD.DrawRectangle(New Pen(Color.LightGray), i * a, j * b, a, b)
                    End If
                Next
            Next
        Else
            For j = 0 To cellHeight - 1
                For i = 0 To cellWidth - 1
                    grpD.FillEllipse(New SolidBrush(bmp.GetPixel(i, j)), i * a + 1, j * b + 1, a - 2, b - 2)
                    If chkGrid.Checked = True Then
                        grpD.DrawRectangle(New Pen(Color.LightGray), i * a, j * b, a, b)
                    End If
                Next
            Next
        End If
        bmp.Dispose()
        If Not IsNothing(picEdit.Image) Then
            picEdit.Image.Dispose()
        End If
        picEdit.Image = bmpD
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
        Dim tab_maxwidth
        'create
        tab_maxwidth = tagCreate.Size.Width - picEdit.Left
        cboCodepage.Width = tab_maxwidth - cboCodepage.Left
        btnCreate.Width = tab_maxwidth - btnCreate.Left
        txtFontName.Width = tab_maxwidth - txtFontName.Left
        btnInitCharactors.Width = tab_maxwidth - btnInitCharactors.Left
        ' open
        tab_maxwidth = tagOpen.Size.Width - picEdit.Left
        txtImportFileName.Width = tab_maxwidth - txtImportFileName.Left
        cboImportType.Width = tab_maxwidth - cboImportType.Left
        btnImport.Width = tab_maxwidth - btnImport.Left
        ' save
        tab_maxwidth = tagSave.Size.Width - picEdit.Left
        txtSaveImagePath.Width = tab_maxwidth - txtSaveImagePath.Left
        txtSaveImage.Width = tab_maxwidth - txtSaveImage.Left
        cboSaveFileType.Width = tab_maxwidth - cboSaveFileType.Left
        btnSave.Width = tab_maxwidth - btnSave.Left
    End Sub

    Private Sub resizeAll()
        tabControl.Width = SplitContainer1.Panel2.Width

        pnlMain.Width = SplitContainer1.Panel1.Width - pnlMain.Left
        pnlMain.Height = SplitContainer1.Panel1.Height - pnlMain.Top
        picEdit.Width = SplitContainer1.Panel2.Width - 2 * picEdit.Left
        picEdit.Height = SplitContainer1.Panel2.Height - picEdit.Top - 2 * picEdit.Left - chkGrid.Height
        chkGrid.Top = SplitContainer1.Panel2.Height - chkGrid.Height
        chkRound.Top = chkGrid.Top
        RedrawEditor()
        lblBackColor.Left = SplitContainer1.Panel2.Width - lblBackColor.Width
        lblBackColor.Top = SplitContainer1.Panel2.Height - lblBackColor.Height
        lblForeColor.Left = lblBackColor.Left - lblForeColor.Width
        lblForeColor.Top = lblBackColor.Top
        resizeTab()
        'edit
        btnCopyCharImage.Width = SplitContainer1.Panel2.Width - btnCopyCharImage.Left
        btnPasteImage.Width = SplitContainer1.Panel2.Width - btnPasteImage.Left
    End Sub

    Private Sub frmBMPFont_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        resizeAll()
    End Sub


    Private Sub btnCopyImage_Click(sender As Object, e As EventArgs) Handles btnCopyCharImage.Click
        If currCellX = -1 Then
            Exit Sub
        End If
        If picEdit.Width <= 1 Or picEdit.Height <= 1 Then
            Exit Sub
        End If
        Dim s As String
        Dim bmp As Bitmap
        Dim c As Color
        Dim d As Integer
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
                bmp = picMain.Image
                s = ""
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
                Clipboard.SetText(s)
            Case "SVG"
                bmp = picMain.Image
                s = "<?xml version=""1.0"" encoding=""UTF-8"" standalone=""no""?>" & vbCrLf
                s = s & "<svg xmlns=""http://www.w3.org/2000/svg""" & vbCrLf
                s = s & "     enable-background=""new 0 0 " & cellWidth * 10 & " " & cellHeight * 10 & """" & vbCrLf
                s = s & "     width=""" & cellWidth * 10 & """ height=""" & cellHeight * 10 & """ viewBox=""0 0 " & cellWidth * 10 & " " & cellHeight * 10 & """>" & vbCrLf
                s = s & "  <g style=""display:inline"">" & vbCrLf
                If chkGrid.Checked = True Then
                    For i = 0 To cellWidth
                        s = s & "    <line x1=""" & i * 10 & """ y1=""0"" x2=""" & i * 10 & """ y2=""" & cellHeight * 10 & """ style=""stroke:#000;stroke-width:0.4px""/>" & vbCrLf
                    Next
                    For j = 0 To cellHeight
                        s = s & "    <line y1=""" & j * 10 & """ x1=""0"" y2=""" & j * 10 & """ x2=""" & cellWidth * 10 & """ style=""stroke:#000;stroke-width:0.4px""/>" & vbCrLf
                    Next
                End If
                For j = 0 To cellHeight - 1
                    For i = 0 To cellWidth - 1
                        c = bmp.GetPixel(currCellX * (cellWidth + 1) + i, currCellY * (cellHeight + 1) + j)
                        If (c.R * 9 + c.G * 19 + c.B * 4 >> 5) < 128 And c.A > 128 Then
                            If chkRound.Checked = True Then
                                s = s & "    <circle r=""4"" cy=""" & j * 10 + 5 & """ cx=""" & i * 10 + 5 & """ style=""fill:rgb(" & c.R & "," & c.G & "," & c.B & ");fill-opacity:1""/>" & vbCrLf
                            Else
                                s = s & "    <rect width=""10"" height=""10"" y=""" & j * 10 & """ x=""" & i * 10 & """ style=""fill:rgb(" & c.R & "," & c.G & "," & c.B & ");fill-opacity:1""/>" & vbCrLf
                            End If
                        End If
                    Next
                    s = s & vbCrLf
                Next
                s = s & "  </g>" & vbCrLf
                s = s & "</svg>"
                Clipboard.SetText(s)
        End Select
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

    Private Sub picEditor_MouseMove(sender As Object, e As MouseEventArgs) Handles picEdit.MouseMove
        If picEdit.Image Is Nothing Then
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
        Dim grpD As Graphics = Graphics.FromImage(picEdit.Image)
        Dim bmpM As Bitmap = picMain.Image
        Dim grpM As Graphics = Graphics.FromImage(picMain.Image)

        Dim a As Single = (picEdit.Width - 1) / cellWidth
        Dim b As Single = (picEdit.Height - 1) / cellHeight

        Dim dotX As Integer = (e.X + a / 2) / a - 1
        Dim dotY As Integer = (e.Y + b / 2) / b - 1
        lblCursor.Text = "Cursor: " & dotX & "-" & dotY
        If dotX >= cellWidth Or dotY >= cellHeight Then
            Exit Sub
        End If
        If e.Button = MouseButtons.Left Then
            If isShiftPress = False Then
                If chkRound.Checked = False Then
                    grpD.FillRectangle(New SolidBrush(lblForeColor.BackColor), dotX * a, dotY * b, a, b)
                Else
                    grpD.FillEllipse(New SolidBrush(lblForeColor.BackColor), dotX * a + 1, dotY * b + 1, a - 2, b - 2)
                End If
                bmpM.SetPixel(currCellX * (cellWidth + 1) + dotX, currCellY * (cellHeight + 1) + dotY, lblForeColor.BackColor)
                If chkGrid.Checked = True Then
                    grpD.DrawRectangle(New Pen(Color.LightGray), dotX * a, dotY * b, a, b)
                End If
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
                If chkRound.Checked = False Then
                    grpD.FillRectangle(New SolidBrush(lblBackColor.BackColor), dotX * a, dotY * b, a, b)
                Else
                    grpD.FillEllipse(New SolidBrush(lblBackColor.BackColor), dotX * a + 1, dotY * b + 1, a - 2, b - 2)
                End If
                bmpM.SetPixel(currCellX * (cellWidth + 1) + dotX, currCellY * (cellHeight + 1) + dotY, lblBackColor.BackColor)
                If chkGrid.Checked = True Then
                    grpD.DrawRectangle(New Pen(Color.LightGray), dotX * a, dotY * b, a, b)
                End If
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

    Private Sub SplitContainer1_Resize(sender As Object, e As EventArgs) Handles SplitContainer1.Resize
        resizeAll()
    End Sub

    Private Sub btnScale_Click(sender As Object, e As EventArgs) Handles btnScale.Click, btnMove.Click

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
            Dim a = Split(txtScale.Text, "x")
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
        Process.Start("explorer.exe", Application.StartupPath)
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

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub chkRound_CheckedChanged(sender As Object, e As EventArgs) Handles chkRound.CheckedChanged
        RedrawEditor()
    End Sub

    Private Sub chkGrid_CheckedChanged(sender As Object, e As EventArgs) Handles chkGrid.CheckedChanged
        RedrawEditor()
    End Sub

    Private Sub picEdit_Click(sender As Object, e As EventArgs) Handles picEdit.Click

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

    Private Sub picEdit_MouseEnter(sender As Object, e As EventArgs) Handles picEdit.MouseEnter

    End Sub

    Private Sub picEdit_Layout(sender As Object, e As LayoutEventArgs) Handles picEdit.Layout

    End Sub
End Class
