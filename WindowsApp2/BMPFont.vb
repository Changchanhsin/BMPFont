Public Class frmBMPFont
    Private fontName As String = ""
    Private codePage As Integer = 0 '0=raw/unicode;932=shift_jis;936=gb2312;950=big5;0/20217=ascii
    Private codeL(256) As Integer
    Private codeH(256) As Integer

    Private cellWidth As Integer = 0
    Private cellHeight As Integer = 0
    Private codeWidth As Integer = 0
    Private codeHeight As Integer = 0
    Private currCellX As Integer = -1
    Private currCellY As Integer = -1

    Private bmpDigitalL(16) As Bitmap
    Private bmpDigitalS(16) As Bitmap

    Dim bmpHead As New Bitmap(13, 13)

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
        Dim grpTemp As Graphics
        For i = 0 To 15
            bmpDigitalL(i) = New Bitmap(5, 7)
            grpTemp = Graphics.FromImage(bmpDigitalL(i))
            grpTemp.DrawImage(iml57.Images(0), 0 - i * 5, 0)
            bmpDigitalS(i) = New Bitmap(3, 5)
            grpTemp = Graphics.FromImage(bmpDigitalS(i))
            grpTemp.DrawImage(iml35.Images(0), 0 - i * 3, 0)
        Next
    End Sub

    Private Sub initCharactor()
        If codePage < 0 Then
            Exit Sub
        End If
        Dim grpMain As Graphics = Graphics.FromImage(picMain.Image)
        Dim mBrush As New SolidBrush(Color.LightPink)
        Dim size As Integer
        Dim offset As Integer
        If (cellWidth >= 16) Then
            size = 12
            offset = -3
        ElseIf (cellWidth >= 14) Then
            size = 11
            offset = -3
        ElseIf (cellWidth >= 13) Then
            size = 10
            offset = -3
        ElseIf (cellWidth >= 12) Then
            size = 9
            offset = -2
        Else
            Exit Sub
        End If
        Dim mFont As New Font("宋体", size)
        Dim currChar(4) As Byte
        Dim unicodeString As String
        Dim bmp As New Bitmap(cellWidth, cellHeight)
        Dim grp As Graphics = Graphics.FromImage(bmp)
        Dim brs As New SolidBrush(Color.White)
        For i = 0 To codeHeight - 1
            For j = 0 To codeWidth - 1
                If codePage = 1200 Then
                    currChar(0) = &HFF
                    currChar(1) = &HFE
                    currChar(2) = codeH(i)
                    currChar(3) = codeL(j)
                ElseIf codePage = 1252 Then
                    currChar(0) = codeH(i) * 8 + codeL(j)
                    currChar(1) = 0
                Else
                    currChar(0) = codeH(i)
                    currChar(1) = codeL(j)
                    currChar(2) = 0
                End If
                unicodeString = System.Text.Encoding.GetEncoding(codePage).GetString(currChar)

                'grpMain.DrawString(unicodeString, mFont, mBrush, j * (cellWidth + 1) + offset, i * (cellHeight + 1))
                grp.FillRectangle(brs, 0, 0, cellWidth, cellHeight)
                grp.DrawString(unicodeString, mFont, mBrush, offset, 0)
                grpMain.DrawImage(bmp, j * (cellWidth + 1), i * (cellHeight + 1))
            Next
        Next
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

    Private Sub createArray(cp As Integer, width As Integer, height As Integer, codeLowRange() As Integer, codeHighRange() As Integer)
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
                    grpOutputH.DrawImage(bmpDigitalL(Int(i / 16)), 2 + iCount * (width + 1), 3)
                    grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 10 + iCount * (width + 1), 3)
                ElseIf (width >= 16) Then
                    grpOutputH.DrawImage(bmpDigitalL(Int(i / 16)), 2 + iCount * (width + 1), 3)
                    grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 8 + iCount * (width + 1), 3)
                ElseIf (width >= 8) Then
                    grpOutputH.DrawImage(bmpDigitalS(Int(i / 16)), 1 + iCount * (width + 1), 3)
                    grpOutputH.DrawImage(bmpDigitalS(i Mod 16), 5 + iCount * (width + 1), 3)
                ElseIf (width >= 6) Then
                    grpOutputH.DrawImage(bmpDigitalS(Int(i / 16)), 2 + iCount * (width + 1), 0)
                    grpOutputH.DrawImage(bmpDigitalS(i Mod 16), 2 + iCount * (width + 1), 6)
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
                    grpOutputV.DrawImage(bmpDigitalL(Int(i / 16)), 5, 2 + iCount * (height + 1))
                    grpOutputV.DrawImage(bmpDigitalL(i Mod 16), 5, 10 + iCount * (height + 1))
                ElseIf (height >= 10) Then
                    grpOutputV.DrawImage(bmpDigitalL(Int(i / 16)), 0, 2 + iCount * (height + 1))
                    grpOutputV.DrawImage(bmpDigitalL(i Mod 16), 6, 2 + iCount * (height + 1))
                ElseIf (height >= 8) Then
                    grpOutputV.DrawImage(bmpDigitalS(Int(i / 16)), 2, 2 + iCount * (height + 1))
                    grpOutputV.DrawImage(bmpDigitalS(i Mod 16), 6, 2 + iCount * (height + 1))
                ElseIf (height >= 6) Then
                    grpOutputV.DrawImage(bmpDigitalS(Int(i / 16)), 2, 1 + iCount * (height + 1))
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
        picV.Image = bmpV
        picV.Width = 13
        picV.Height = sizeH * (height + 1)
        picV.Refresh()
        picH.Image = bmpH
        picH.Width = sizeW * (width + 1)
        picH.Height = 13
        picH.Refresh()
        picMain.Image = bmpMain
        picMain.Width = sizeW * (width + 1)
        picMain.Height = sizeH * (height + 1)
        picMain.Refresh()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim l() As Integer
        Dim h() As Integer
        Dim c As Integer
        Select Case cboCodepage.SelectedItem
            Case "Unknown(0)"
                l = {0, in0255(txtNewSizeW.Text - 1)}
                h = {0, in0255(txtNewSizeH.Text - 1)}
                c = 0
            Case "ASCII-7(0)"
                l = {0, 15}
                h = {0, 7}
                c = 1252
            Case "ASCII-8(0)"
                l = {0, 15}
                h = {0, 15}
                c = 1252
            Case "Unicode(0)"
                l = {0, 255}
                h = {0, 255}
                c = 1200
            Case "ISO/IEC13000BMP(0)"
                l = {0, 255}
                h = {0, 255}
                c = 1200
            Case "GB2312双字节(936)"
                l = {&HA1, &HFE}
                h = {&HA1, &HFE}
                c = 936
            Case "GBK双字节(936)"
                l = {&H40, &H7E, &H80, &HFE}
                h = {&H81, &HFE}
                c = 936
            Case "GB18030双字节(936)"
                l = {&H40, &H7E, &H80, &HFE}
                h = {&H81, &HFE}
                c = 936
            Case "Big-5(950)"
                l = {&H40, &H7E, &HA1, &HFE}
                h = {&H81, &HFE}
                c = 950
            Case "Shift-JIS(932)"
                l = {&H40, &H7E, &H80, &HFC}
                h = {&H81, &H9F, &HE0, &HFC}
                c = 932
            Case Else
                l = {0, in0255(txtNewSizeW.Text - 1)}
                h = {0, in0255(txtNewSizeH.Text - 1)}
                c = 0
        End Select
        createArray(c, txtNewWidth.Text, txtNewHeight.Text, l, h)
    End Sub

    Private Sub picMain_Move(sender As Object, e As EventArgs) Handles picMain.Move
        picH.Left = picMain.Left
        picV.Top = picMain.Top
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Select Case cboSaveFileType.Text
            Case ".HZCG6"

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

            Dim FS As New System.IO.FileStream(txtSaveImage.Text, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.Write)
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
        picSave.Image = bmpSave
        picSave.Refresh()
        Try
            picSave.Image.Save(txtSaveImage.Text & ".FONT.PNG")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub importRAW(width As Integer, height As Integer, sizeW As Integer, sizeH As Integer)

        Try

            Dim FS As New System.IO.FileStream(txtImportFileName.Text, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)

            Dim Bw As New System.IO.BinaryReader(FS)
            Dim readBs As Byte()
            Dim bmp = New Bitmap(width, height)

            Dim lc() As Integer = {0, sizeW - 1}
            Dim hc() As Integer = {0, sizeH - 1}
            createArray(0, width, height, lc, hc)


            FS.Seek(txtImportOffset.Text, IO.SeekOrigin.Begin)
            Dim widthBytes As Integer = Int((width + 7) / 8)
            cellWidth = width
            cellHeight = height
            codeWidth = sizeW
            codeHeight = sizeH
            codePage = 0
            Dim grpMain As Graphics = Graphics.FromImage(picMain.Image)
            For t = 0 To sizeH - 1
                For l = 0 To sizeW - 1
                    readBs = Bw.ReadBytes(widthBytes * height)
                    For j = 0 To height - 1
                        For i = 0 To width - 1 'widthBytes * 8 - 1
                            If ((readBs(j * widthBytes + Int(i / 8)) >> (7 - (i Mod 8))) Mod 2) = 1 Then
                                bmp.SetPixel(i, j, Color.Black)
                            Else
                                bmp.SetPixel(i, j, Color.White)
                            End If
                        Next
                    Next
                    grpMain.DrawImage(bmp, l * (width + 1), t * (height + 1))
                Next
            Next
            picMain.Refresh()

            FS.Close()
        Catch ex2 As Exception
            MessageBox.Show("Error on open RAW file : " & ex2.Message)
            picMain.Refresh()
            Exit Sub
        End Try

    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Select Case cboImportType.Text
            Case ".FONT.PNG"
                savePNG()
            Case ".HZCG6"

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
        lblColRow.Text = "Col:" & currCellX & "(" & Strings.Right("00" & Hex(currCellX), 2) & ") Row:" & currCellY & "(" & Strings.Right("00" & Hex(currCellY), 2) & ")"
        grpD.DrawRectangle(New Pen(Color.Red), currCellX * (cellWidth + 1) - 1, currCellY * (cellHeight + 1) - 1, cellWidth + 1, cellHeight + 1)
        picMain.Refresh()
        RedrawEditor()
    End Sub

    Private Sub picEditor_Resize(sender As Object, e As EventArgs) Handles picEditor.Resize
        RedrawEditor()
    End Sub
    Private Sub RedrawEditor()
        If currCellX = -1 Then
            Exit Sub
        End If
        If picEditor.Width <= 1 Or picEditor.Height <= 1 Then
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
        Dim bmpD = New Bitmap(picEditor.Width, picEditor.Height)
        Dim grpD = Graphics.FromImage(bmpD)

        grp.DrawImage(picMain.Image, New RectangleF(0, 0, cellWidth, cellHeight), New RectangleF(currCellX * (cellWidth + 1), currCellY * (cellHeight + 1), cellWidth, cellHeight), GraphicsUnit.Pixel)
        Dim a As Single = picEditor.Width / cellWidth
        Dim b As Single = picEditor.Height / cellHeight

        For j = 0 To cellHeight - 1
            For i = 0 To cellWidth - 1
                grpD.FillRectangle(New SolidBrush(bmp.GetPixel(i, j)), i * a, j * b, a, b)
            Next
        Next
        picEditor.BackgroundImage = bmpD
    End Sub

    Private Sub frmBMPFont_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initGraphicResource()
        resizeAll()
        cboCodepage.SelectedIndex = 0
        cboSaveFileType.SelectedIndex = 0
        cboImportType.SelectedIndex = 0
    End Sub

    Private Sub resizeAll()
        Dim border = picEditor.Left
        pnlMain.Width = SplitContainer1.Panel1.Width - pnlMain.Left
        pnlMain.Height = SplitContainer1.Panel1.Height - pnlMain.Top
        picEditor.Width = SplitContainer1.Panel2.Width - border * 2
        picEditor.Height = SplitContainer1.Panel2.Height - picEditor.Top - border
        RedrawEditor()
        cboCodepage.Width = SplitContainer1.Panel2.Width - cboCodepage.Left - border
        cboSaveFileType.Width = SplitContainer1.Panel2.Width - cboSaveFileType.Left - border
        btnCreate.Width = SplitContainer1.Panel2.Width - btnCreate.Left - border
        btnSave.Width = SplitContainer1.Panel2.Width - btnSave.Left - border
        btnImport.Width = SplitContainer1.Panel2.Width - btnImport.Left - border
        btnCopyCharImage.Width = SplitContainer1.Panel2.Width - btnCopyCharImage.Left - border
        btnPasteImage.Width = SplitContainer1.Panel2.Width - btnPasteImage.Left - border
        txtImportFileName.Width = SplitContainer1.Panel2.Width - txtImportFileName.Left - border
    End Sub

    Private Sub frmBMPFont_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        resizeAll()
    End Sub


    Private Sub btnCopyCharImage_Click(sender As Object, e As EventArgs) Handles btnCopyCharImage.Click
        If currCellX = -1 Then
            Exit Sub
        End If
        If picEditor.Width <= 1 Or picEditor.Height <= 1 Then
            Exit Sub
        End If

        Dim bmp = New Bitmap(cellWidth, cellHeight)
        Dim grp = Graphics.FromImage(bmp)
        grp.DrawImage(picMain.Image, New RectangleF(0, 0, cellWidth, cellHeight), New RectangleF(currCellX * (cellWidth + 1), currCellY * (cellHeight + 1), cellWidth, cellHeight), GraphicsUnit.Pixel)
        Clipboard.SetImage(bmp)
    End Sub

    Private Sub btnPasteImage_Click(sender As Object, e As EventArgs) Handles btnPasteImage.Click
        If currCellX = -1 Then
            Exit Sub
        End If
        If picEditor.Width <= 1 Or picEditor.Height <= 1 Then
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
        resizeAll()
    End Sub

    Private Sub picEditor_MouseMove(sender As Object, e As MouseEventArgs) Handles picEditor.MouseMove
        If picEditor.BackgroundImage Is Nothing Then
            Exit Sub
        End If
        If e.X < 0 Or e.Y < 0 Or e.X > picEditor.Width Or e.Y > picEditor.Height Then
            Exit Sub
        End If
        Dim grpD As Graphics = Graphics.FromImage(picEditor.BackgroundImage)
        Dim bmpM As Bitmap = picMain.Image
        Dim grpM As Graphics = Graphics.FromImage(picMain.Image)

        Dim a As Single = picEditor.Width / cellWidth
        Dim b As Single = picEditor.Height / cellHeight

        Dim dotX As Integer = (e.X + a / 2) / a - 1
        Dim dotY As Integer = (e.Y + b / 2) / b - 1
        'lblXY.Text = e.X & "," & e.Y & "@" & dotX & "," & dotY
        If e.Button = MouseButtons.Left Then
            grpD.FillRectangle(New SolidBrush(Color.Black), dotX * a, dotY * b, a, b)
            bmpM.SetPixel(currCellX * (cellWidth + 1) + dotX, currCellY * (cellHeight + 1) + dotY, Color.Black)
        End If
        If e.Button = MouseButtons.Right Then
            grpD.FillRectangle(New SolidBrush(Color.White), dotX * a, dotY * b, a, b)
            bmpM.SetPixel(currCellX * (cellWidth + 1) + dotX, currCellY * (cellHeight + 1) + dotY, Color.White)
        End If
        picMain.Refresh()
        picEditor.Refresh()
    End Sub

    Private Sub picEditor_MouseClick(sender As Object, e As MouseEventArgs) Handles picEditor.MouseClick
        picEditor_MouseMove(sender, e)
    End Sub

    Private Sub picMain_MouseMove(sender As Object, e As MouseEventArgs) Handles picMain.MouseMove
        If e.Button = MouseButtons.Left Then
            picMain_MouseClick(sender, e)
        End If
    End Sub

    Private Sub btbInitCharactors_Click(sender As Object, e As EventArgs) Handles btbInitCharactors.Click
        initCharactor()
    End Sub


    Private Sub SplitContainer1_Resize(sender As Object, e As EventArgs) Handles SplitContainer1.Resize
        resizeAll()
    End Sub
End Class
