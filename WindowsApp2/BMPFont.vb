Public Class frmBMPFont
    Private codePage As Integer  '0=raw/unicode;932=shift_jis;936=gb2312;950=big5;0/20217=ascii
    Private cellWidth As Integer
    Private cellHeight As Integer
    Private codeWidth As Integer
    Private codeHeight As Integer
    Private fontName As Char()
    Private currCodeX As Integer = -1
    Private currCodeY As Integer = -1
    Private bmpDigitalL(16) As Bitmap
    Private bmpDigitalS(16) As Bitmap

    Private Function in0255(v As Integer) As Integer
        If v < 0 Then
            in0255 = 0
        End If
        If v > 256 Then
            in0255 = 255
        End If
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

    Private Sub createArray(cp As Integer, width As Integer, height As Integer, codeLowRange() As Integer, codeHighRange() As Integer)
        Dim sizeW As Integer
        Dim sizeH As Integer

        sizeW = 0
        sizeH = 0
        Dim mapW(256)
        Dim mapH(256)
        For i = 0 To 255
            mapW(i) = 0
            mapH(i) = 0
        Next
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

        Dim bmpHead As New Bitmap(13, 13)
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

    Private Sub createBIG5(width As Integer, height As Integer)
        Dim l() = {&H40, &H7E, &HA1, &HFE}
        Dim h() = {&H81, &HFE}
        createArray(950, width, height, l, h)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim l() As Integer = {0, txtNewSizeW.Text - 1}
        Dim h() As Integer = {0, txtNewSizeH.Text - 1}
        createArray(0, txtNewWidth.Text, txtNewHeight.Text, l, h)
    End Sub

    Private Sub picMain_Move(sender As Object, e As EventArgs) Handles picMain.Move
        picH.Left = picMain.Left
        picV.Top = picMain.Top
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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
            picSave.Image.Save(txtSaveImage.Text)
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

            Dim grpMain As Graphics = Graphics.FromImage(picMain.Image)

            FS.Seek(txtImportOffset.Text, IO.SeekOrigin.Begin)
            Dim widthBytes As Integer = Int((width + 7) / 8)
            cellWidth = width
            cellHeight = height
            codeWidth = sizeW
            codeHeight = sizeH
            codePage = 0
            Try
                For t = 0 To sizeH - 1
                    For l = 0 To sizeW - 1
                        readBs = Bw.ReadBytes(widthBytes * height)
                        For j = 0 To height - 1
                            For i = 0 To widthBytes * 8 - 1
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
            Catch ex As Exception
                MessageBox.Show("Error on open RAW file : " & ex.Message)
                picMain.Refresh()
                FS.Close()
            End Try
            FS.Close()
        Catch ex2 As Exception
            MessageBox.Show("Error on open RAW file : " & ex2.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        importRAW(txtImportWidth.Text, txtImportHeight.Text, txtImportSizeW.Text, txtImportSizeH.Text)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnBIG5.Click
        Dim l() = {&H40, &H7E, &HA1, &HFE}
        Dim h() = {&H81, &HFE}
        createArray(950, txtNewWidth.Text, txtNewHeight.Text, l, h)
    End Sub

    Private Sub picMain_MouseClick(sender As Object, e As MouseEventArgs) Handles picMain.MouseClick
        currCodeX = Int((e.X) / (cellWidth + 1))
        currCodeY = Int((e.Y) / (cellHeight + 1))
        RedrawEditor()
    End Sub

    Private Sub picEditor_MouseClick(sender As Object, e As MouseEventArgs) Handles picEditor.MouseClick

    End Sub

    Private Sub picEditor_Resize(sender As Object, e As EventArgs) Handles picEditor.Resize
        RedrawEditor()
    End Sub
    Private Sub RedrawEditor()
        If currCodeX = -1 Then
            Exit Sub
        End If
        If picEditor.Width <= 1 Or picEditor.Height <= 1 Then
            Exit Sub
        End If

        Dim bmp = New Bitmap(cellWidth, cellHeight)
        Dim grp = Graphics.FromImage(bmp)
        Dim bmpD = New Bitmap(picEditor.Width, picEditor.Height)
        Dim grpD = Graphics.FromImage(bmpD)

        grp.DrawImage(picMain.Image, New RectangleF(0, 0, cellWidth, cellHeight), New RectangleF(currCodeX * (cellWidth + 1), currCodeY * (cellHeight + 1), cellWidth, cellHeight), GraphicsUnit.Pixel)
        Dim a As Single = picEditor.Width / cellWidth
        Dim b As Single = picEditor.Height / cellHeight

        For j = 0 To cellHeight - 1
            For i = 0 To cellWidth - 1
                grpD.FillRectangle(New SolidBrush(bmp.GetPixel(i, j)), i * a, j * b, a, b)
            Next
        Next
        picEditor.BackgroundImage = bmpD
        picEditor.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top Or AnchorStyles.Bottom
    End Sub

    Private Sub frmBMPFont_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initGraphicResource()
        resizeAll()
    End Sub

    Private Sub resizeAll()
        pnlMain.Width = SplitContainer1.Panel1.Width - pnlMain.Left
        pnlMain.Height = SplitContainer1.Panel1.Height - pnlMain.Top
        picEditor.Width = SplitContainer1.Panel2.Width - picEditor.Left * 2
        picEditor.Height = SplitContainer1.Panel2.Height - picEditor.Top - picEditor.Left
    End Sub

    Private Sub frmBMPFont_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        resizeAll()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnGB2312.Click
        Dim l() = {&HA1, &HFE}
        Dim h() = {&HA1, &HFE}
        createArray(936, txtNewWidth.Text, txtNewHeight.Text, l, h)
    End Sub

    Private Sub btbGBK_Click(sender As Object, e As EventArgs) Handles btbGBK.Click
        Dim l() = {&H40, &H7E, &H80, &HFE}
        Dim h() = {&H81, &HFE}
        createArray(936, txtNewWidth.Text, txtNewHeight.Text, l, h)
    End Sub

    Private Sub btnSJIS_Click(sender As Object, e As EventArgs) Handles btnSJIS.Click
        Dim l() = {&H40, &H7E, &H80, &HFC}
        Dim h() = {&H81, &H9F, &HE0, &HFC}
        createArray(932, txtNewWidth.Text, txtNewHeight.Text, l, h)
    End Sub
End Class
