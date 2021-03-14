Public Class frmBMPFont
    Private codePage As Integer  '0=raw/unicode;932=shift_jis;936=gb2312;950=big5;0/20217=ascii
    Private cellWidth As Integer
    Private cellHeight As Integer
    Private codeWidth As Integer
    Private codeHeight As Integer
    Private fontName As Char()
    Private currCodeX As Integer = -1
    Private currCodeY As Integer = -1

    Private Sub createBIG5(width As Integer, height As Integer)
        Dim sizeW As Integer = (&H7E - &H40 + 1) + (&HFE - &HA1 + 1)
        Dim sizeH As Integer = &HFE - &H81 + 1
        Dim bmpHead As New Bitmap(13, 13)
        Dim bmpV As New Bitmap(13, sizeH * (height + 1) + 1)
        Dim bmpH As New Bitmap(sizeW * (width + 1) + 1, 13)
        Dim bmpMain As New Bitmap(sizeW * (width + 1) + 1, sizeH * (height + 1) + 1)

        cellWidth = width
        cellHeight = height
        codeWidth = sizeW
        codeHeight = sizeH
        codePage = 950

        Dim grpTemp As Graphics
        Dim bmpDigitalL(16) As Bitmap
        Dim bmpDigitalS(16) As Bitmap
        For i = 0 To 15
            bmpDigitalL(i) = New Bitmap(5, 7)
            grpTemp = Graphics.FromImage(bmpDigitalL(i))
            grpTemp.DrawImage(iml57.Images(0), 0 - i * 5, 0)
            bmpDigitalS(i) = New Bitmap(3, 5)
            grpTemp = Graphics.FromImage(bmpDigitalS(i))
            grpTemp.DrawImage(iml35.Images(0), 0 - i * 3, 0)
        Next

        Dim grpOutputHead As Graphics = Graphics.FromImage(bmpHead)
        grpOutputHead.DrawLine(Pens.Blue, 0, 12, 12, 12)
        grpOutputHead.DrawLine(Pens.Blue, 12, 0, 12, 12)
        picHead.Image = bmpHead
        picHead.Refresh()
        Dim grpOutputV As Graphics = Graphics.FromImage(bmpV)
        Dim grpOutputH As Graphics = Graphics.FromImage(bmpH)
        Dim grpOutputMain As Graphics = Graphics.FromImage(bmpMain)
        Dim iCount = 0
        For i = 0 To 254
            If (i >= &H40 And i <= &H7E) Or (i >= &HA1 And i <= &HFE) Then
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
        For i = 0 To 254
            If i >= &H81 And i <= &HFE Then
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

    Private Sub createFont(width As Integer, height As Integer, sizeW As Integer, sizeH As Integer)
        Dim bmpHead As New Bitmap(13, 13)
        Dim bmpV As New Bitmap(13, sizeH * (height + 1) + 1)
        Dim bmpH As New Bitmap(sizeW * (width + 1) + 1, 13)
        Dim bmpMain As New Bitmap(sizeW * (width + 1) + 1, sizeH * (height + 1) + 1)

        cellWidth = width
        cellHeight = height
        codeWidth = sizeW
        codeHeight = sizeH
        codePage = 0

        Dim grpTemp As Graphics
        Dim bmpDigitalL(16) As Bitmap
        Dim bmpDigitalS(16) As Bitmap
        For i = 0 To 15
            bmpDigitalL(i) = New Bitmap(5, 7)
            grpTemp = Graphics.FromImage(bmpDigitalL(i))
            grpTemp.DrawImage(iml57.Images(0), 0 - i * 5, 0)
            bmpDigitalS(i) = New Bitmap(3, 5)
            grpTemp = Graphics.FromImage(bmpDigitalS(i))
            grpTemp.DrawImage(iml35.Images(0), 0 - i * 3, 0)
        Next

        Dim grpOutputHead As Graphics = Graphics.FromImage(bmpHead)
        grpOutputHead.DrawLine(Pens.Blue, 0, 12, 12, 12)
        grpOutputHead.DrawLine(Pens.Blue, 12, 0, 12, 12)
        picHead.Image = bmpHead
        picHead.Refresh()
        Dim grpOutputV As Graphics = Graphics.FromImage(bmpV)
        Dim grpOutputH As Graphics = Graphics.FromImage(bmpH)
        Dim grpOutputMain As Graphics = Graphics.FromImage(bmpMain)
        For i = 0 To sizeW - 1
            grpOutputH.DrawLine(Pens.Blue, i * (width + 1) - 1, 0, i * (width + 1) - 1, 12)
            If (width >= 18) Then
                If sizeW > 16 Then
                    grpOutputH.DrawImage(bmpDigitalL(Int(i / 16)), 2 + i * (width + 1), 3)
                    grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 10 + i * (width + 1), 3)
                Else
                    grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 4 + i * (width + 1), 3)
                End If
            ElseIf (width >= 16) Then
                If sizeW > 16 Then
                    grpOutputH.DrawImage(bmpDigitalL(Int(i / 16)), 2 + i * (width + 1), 3)
                    grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 8 + i * (width + 1), 3)
                Else
                    grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 6 + i * (width + 1), 3)
                End If
            ElseIf (width >= 8) Then
                If sizeW > 16 Then
                    grpOutputH.DrawImage(bmpDigitalS(Int(i / 16)), 1 + i * (width + 1), 3)
                    grpOutputH.DrawImage(bmpDigitalS(i Mod 16), 5 + i * (width + 1), 3)
                Else
                    grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 1 + i * (width + 1), 3)
                End If
            ElseIf (width >= 6) Then
                If sizeW > 16 Then
                    grpOutputH.DrawImage(bmpDigitalS(Int(i / 16)), 2 + i * (width + 1), 0)
                    grpOutputH.DrawImage(bmpDigitalS(i Mod 16), 2 + i * (width + 1), 6)
                Else
                    grpOutputH.DrawImage(bmpDigitalS(i Mod 16), 2 + i * (width + 1), 3)
                End If
            End If
            grpOutputMain.DrawLine(Pens.Blue, i * (width + 1) - 1, 0, i * (width + 1) - 1, sizeH * (height + 1) - 1)
        Next
        grpOutputH.DrawLine(Pens.Blue, sizeW * (width + 1) - 1, 0, sizeW * (width + 1) - 1, 12)
        grpOutputMain.DrawLine(Pens.Blue, sizeW * (width + 1) - 1, 0, sizeW * (width + 1) - 1, sizeH * (height + 1) - 1)

        For i = 0 To sizeH - 1
            grpOutputV.DrawLine(Pens.Blue, 0, i * (height + 1) - 1, 12, i * (height + 1) - 1)
            If (height >= 18) Then
                If (sizeH > 16) Then
                    grpOutputV.DrawImage(bmpDigitalL(Int(i / 16)), 5, 2 + i * (height + 1))
                    grpOutputV.DrawImage(bmpDigitalL(i Mod 16), 5, 10 + i * (height + 1))
                Else
                    grpOutputV.DrawImage(bmpDigitalL(i Mod 16), 5, 2 + i * (height + 1))
                End If
            ElseIf (height >= 10) Then
                If (sizeH > 16) Then
                    grpOutputV.DrawImage(bmpDigitalL(Int(i / 16)), 0, 2 + i * (height + 1))
                    grpOutputV.DrawImage(bmpDigitalL(i Mod 16), 6, 2 + i * (height + 1))
                Else
                    grpOutputV.DrawImage(bmpDigitalL(i Mod 16), 3, 1 + i * (height + 1))
                End If
            ElseIf (height >= 8) Then
                If (sizeH > 16) Then
                    grpOutputV.DrawImage(bmpDigitalS(Int(i / 16)), 2, 2 + i * (height + 1))
                    grpOutputV.DrawImage(bmpDigitalS(i Mod 16), 6, 2 + i * (height + 1))
                Else
                    grpOutputV.DrawImage(bmpDigitalL(i Mod 16), 3, 1 + i * (height + 1))
                End If
            ElseIf (height >= 6) Then
                If (sizeH >= 16) Then
                    grpOutputV.DrawImage(bmpDigitalS(Int(i / 16)), 2, 1 + i * (height + 1))
                    grpOutputV.DrawImage(bmpDigitalS(i Mod 16), 6, 1 + i * (height + 1))
                Else
                    grpOutputV.DrawImage(bmpDigitalS(i Mod 16), 4, 1 + i * (height + 1))
                End If
            End If
            grpOutputMain.DrawLine(Pens.Blue, 0, i * (height + 1) - 1, sizeW * (width + 1) - 1, i * (height + 1) - 1)
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
        createFont(txtNewWidth.Text, txtNewHeight.Text, txtNewSizeW.Text, txtNewSizeH.Text)
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
            Dim FS As New System.IO.FileStream(txtImportFileName.Text, IO.FileMode.Open)

            Dim Bw As New System.IO.BinaryReader(FS)
            Dim readBs As Byte()
            Dim bmp = New Bitmap(width, height)

            createFont(width, height, sizeW, sizeH)
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        createBIG5(txtNewWidth.Text, txtNewHeight.Text)
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
                grpD.DrawLine(New Pen(bmp.GetPixel(i, j)), i * a, j * b, i * a + a, j * b + b)
                grpD.DrawLine(New Pen(bmp.GetPixel(i, j)), i * a, j * b + b, i * a + a, j * b)
                grpD.DrawRectangle(New Pen(bmp.GetPixel(i, j)), i * a + a / 3, j * b + b / 3, a / 3, b / 3)
                grpD.DrawRectangle(New Pen(bmp.GetPixel(i, j)), i * a + a / 5, j * b + b / 5, a * 3 / 5, b * 3 / 5)
                grpD.DrawRectangle(New Pen(bmp.GetPixel(i, j)), i * a + a / 12, j * b + b / 12, a * 10 / 12, b * 10 / 12)
            Next
        Next
        picEditor.BackgroundImage = bmpD
        picEditor.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top Or AnchorStyles.Bottom
    End Sub

End Class
