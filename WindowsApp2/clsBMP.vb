Public Class clsBMP
    ' 
    Private charset As clsCharset

    'Private bmpMain As Bitmap
    Private bmpHead As New Bitmap(13, 13)
    'Private bmpV As Bitmap
    'Private bmpH As Bitmap

    'Private bmpEditor As Bitmap

    Private bmpDigitalL() As Bitmap
    Private bmpDigitalS() As Bitmap

    Private picMain As PictureBox
    Private picHead As PictureBox
    Private picV As PictureBox
    Private picH As PictureBox

    Public Sub setup(pic_main As PictureBox, pic_head As PictureBox, pic_v As PictureBox, pic_h As PictureBox, digital_l() As Bitmap, digital_s() As Bitmap)
        picMain = pic_main
        picHead = pic_head
        picV = pic_v
        picH = pic_h
        bmpDigitalL = digital_l
        bmpDigitalS = digital_s
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
        drawHead(charset.codepage / 256, 2, 2)
        drawHead(charset.codepage Mod 256, 2, 3)
        drawHead(charset.cellWidth, 2, 4)
        drawHead(charset.cellHeight, 2, 5)
        drawHead(charset.codeWidth, 2, 6)
        drawHead(charset.codeHeight, 2, 7)
        drawHead(charset.codeUltraHigh, 2, 8)
        drawHead(charset.codepageSubset, 2, 9)
    End Sub

    Private Sub readHead()
        charset.codepage = getHead(2, 2) << 8 + getHead(2, 3)
        charset.cellWidth = getHead(2, 4)
        charset.cellHeight = getHead(2, 5)
        charset.codepageSubset = getHead(2, 9)
        charset.create(charset.codepage, Str(charset.codepageSubset), charset.cellWidth, charset.cellHeight)
        charset.codeWidth = getHead(2, 6)
        charset.codeHeight = getHead(2, 7)
        charset.codeUltraHigh = getHead(2, 8)
    End Sub

    Public Sub create(cs As clsCharset)
        charset = cs

        Dim bmpV As New Bitmap(13, charset.codeHeight * (charset.cellHeight + 1) + 1)
        Dim bmpH As New Bitmap(charset.codeWidth * (charset.cellWidth + 1) + 1, 13)
        Dim bmpMain As New Bitmap(charset.codeWidth * (charset.cellWidth + 1) + 1, charset.codeHeight * (charset.cellHeight + 1) + 1)

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
        For i = 0 To charset.codeWidth - 1
            grpOutputH.DrawLine(Pens.Blue, iCount * (charset.cellWidth + 1) - 1, 0, iCount * (charset.cellWidth + 1) - 1, 12)
            If (charset.cellWidth >= 18) Then
                If charset.codeLength >= 2 Then
                    grpOutputH.DrawImage(bmpDigitalL(Int(i / 16)), 2 + iCount * (charset.cellWidth + 1), 3)
                    grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 10 + iCount * (charset.cellWidth + 1), 3)
                Else
                    grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 2 + iCount * (charset.cellWidth + 1), 3)
                End If
            ElseIf (charset.cellWidth >= 16) Then
                If charset.codeLength >= 2 Then
                    grpOutputH.DrawImage(bmpDigitalL(Int(i / 16)), 2 + iCount * (charset.cellWidth + 1), 3)
                    grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 8 + iCount * (charset.cellWidth + 1), 3)
                Else
                    grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 2 + iCount * (charset.cellWidth + 1), 3)
                End If
            ElseIf (charset.cellWidth >= 8) Then
                If charset.codeLength >= 2 Then
                    grpOutputH.DrawImage(bmpDigitalS(Int(i / 16)), 1 + iCount * (charset.cellWidth + 1), 3)
                    grpOutputH.DrawImage(bmpDigitalS(i Mod 16), 5 + iCount * (charset.cellWidth + 1), 3)
                Else
                    grpOutputH.DrawImage(bmpDigitalL(i Mod 16), 1 + iCount * (charset.cellWidth + 1), 3)
                End If
            ElseIf (charset.cellWidth >= 6) Then
                If charset.codeLength >= 2 Then
                    grpOutputH.DrawImage(bmpDigitalS(Int(i / 16)), 2 + iCount * (charset.cellWidth + 1), 0)
                    grpOutputH.DrawImage(bmpDigitalS(i Mod 16), 2 + iCount * (charset.cellWidth + 1), 6)
                Else
                    grpOutputH.DrawImage(bmpDigitalS(i Mod 16), 2 + iCount * (charset.cellWidth + 1), 4)
                End If
            End If
            grpOutputMain.DrawLine(Pens.Blue, iCount * (charset.cellWidth + 1) - 1, 0, iCount * (charset.cellWidth + 1) - 1, charset.codeHeight * (charset.cellHeight + 1) - 1)
            iCount += 1
        Next
        grpOutputH.DrawLine(Pens.Blue, charset.codeWidth * (charset.cellWidth + 1) - 1, 0, charset.codeWidth * (charset.cellWidth + 1) - 1, 12)
        grpOutputMain.DrawLine(Pens.Blue, charset.codeWidth * (charset.cellWidth + 1) - 1, 0, charset.codeWidth * (charset.cellWidth + 1) - 1, charset.codeHeight * (charset.cellHeight + 1) - 1)

        iCount = 0
        For i = 0 To charset.codeHeight - 1
            grpOutputV.DrawLine(Pens.Blue, 0, iCount * (charset.cellHeight + 1) - 1, 12, iCount * (charset.cellHeight + 1) - 1)
            If (charset.cellHeight >= 18) Then
                If charset.codeLength >= 2 Then
                    grpOutputV.DrawImage(bmpDigitalL(Int(i / 16)), 5, 2 + iCount * (charset.cellHeight + 1))
                    grpOutputV.DrawImage(bmpDigitalL(i Mod 16), 5, 10 + iCount * (charset.cellHeight + 1))
                Else
                    grpOutputV.DrawImage(bmpDigitalL(i Mod 16), 5, 2 + iCount * (charset.cellHeight + 1))
                End If
            ElseIf (charset.cellHeight >= 10) Then
                If charset.codeLength >= 2 Then
                    grpOutputV.DrawImage(bmpDigitalL(Int(i / 16)), 0, 2 + iCount * (charset.cellHeight + 1))
                End If
                grpOutputV.DrawImage(bmpDigitalL(i Mod 16), 6, 2 + iCount * (charset.cellHeight + 1))
            ElseIf (charset.cellHeight >= 8) Then
                If charset.codeLength >= 2 Then
                    grpOutputV.DrawImage(bmpDigitalS(Int(i / 16)), 2, 2 + iCount * (charset.cellHeight + 1))
                End If
                grpOutputV.DrawImage(bmpDigitalS(i Mod 16), 6, 2 + iCount * (charset.cellHeight + 1))
            ElseIf (charset.cellHeight >= 6) Then
                If charset.codeLength >= 2 Then
                    grpOutputV.DrawImage(bmpDigitalS(Int(i / 16)), 2, 1 + iCount * (charset.cellHeight + 1))
                End If
                grpOutputV.DrawImage(bmpDigitalS(i Mod 16), 6, 1 + iCount * (charset.cellHeight + 1))
            End If
            grpOutputMain.DrawLine(Pens.Blue, 0, iCount * (charset.cellHeight + 1) - 1, charset.codeWidth * (charset.cellWidth + 1) - 1, iCount * (charset.cellHeight + 1) - 1)
            iCount = iCount + 1
        Next
        grpOutputV.DrawLine(Pens.Blue, 0, charset.codeHeight * (charset.cellHeight + 1) - 1, 12, charset.codeHeight * (charset.cellHeight + 1) - 1)
        grpOutputMain.DrawLine(Pens.Blue, 0, charset.codeHeight * (charset.cellHeight + 1) - 1, charset.codeWidth * (charset.cellWidth + 1) - 1, charset.codeHeight * (charset.cellHeight + 1) - 1)

        grpOutputV.DrawLine(Pens.Blue, 12, 0, 12, charset.codeHeight * (charset.cellHeight + 1) - 1)
        grpOutputH.DrawLine(Pens.Blue, 0, 12, charset.codeWidth * (charset.cellWidth + 1) - 1, 12)

        If Not IsNothing(picV.Image) Then
            picV.Image.Dispose()
        End If
        picV.Image = bmpV
        picV.Width = 13
        picV.Height = charset.codeHeight * (charset.cellHeight + 1)
        picV.Refresh()

        If Not IsNothing(picH.Image) Then
            picH.Image.Dispose()
        End If
        picH.Image = bmpH
        picH.Width = charset.codeWidth * (charset.cellWidth + 1)
        picH.Height = 13
        picH.Refresh()

        If Not IsNothing(picMain.Image) Then
            picMain.Image.Dispose()
        End If
        picMain.Image = bmpMain
        picMain.Width = charset.codeWidth * (charset.cellWidth + 1)
        picMain.Height = charset.codeHeight * (charset.cellHeight + 1)
        picMain.Refresh()
    End Sub
End Class
