Public Class frmPrint

    Private Function ReadChar(r As System.IO.BinaryReader, w As Integer, h As Integer, ByRef b As Bitmap) As String
        Try
            Dim widthBytes As Integer = Int((w + 7) / 8)
            Dim readBs = r.ReadBytes(widthBytes * h)
            If (readBs.Length < widthBytes * h) Then
                Return -1
            End If
            For j = 0 To (readBs.Length + 1) / widthBytes - 1 ' height - 1
                For i = 0 To w - 1 'widthBytes * 8 - 1
                    If (j * widthBytes + Int(i / 8)) < readBs.Length Then
                        If ((readBs(j * widthBytes + Int(i / 8)) >> (7 - (i Mod 8))) Mod 2) = 1 Then
                            b.SetPixel(i, j, Color.Black)
                        Else
                            b.SetPixel(i, j, Color.White)
                        End If
                    End If
                Next
            Next
            Return 0
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Private Sub RanderPage(r() As System.IO.BinaryReader, map() As Integer, grpmain As Graphics, mfont As Font, mfont2 As Font, mbrush As Brush, p As Pen,
                           bmpmain As Bitmap, files As Integer, charsizew() As Integer, charsizeh() As Integer, bmp() As Bitmap, destrect() As RectangleF,
                           start As Integer)
        Dim p1 As Point
        Dim p2 As Point
        Dim u(4) As Byte
        'grpmain.DrawString("GB/T 13000", mfont2, mbrush, 0, 7)
        'grpmain.DrawString("15x16", mfont2, mbrush, 150, 7)
        'grpmain.DrawString("24x24", mfont2, mbrush, 270, 7)
        'grpmain.DrawString("48x48", mfont2, mbrush, 390, 7)
        'grpmain.DrawString("48x48", mfont2, mbrush, 0, 7)
        p1.Y = 0
        p2.Y = 40
        For i = 0 To files
            p1.X = i * 120 + 120
            p2.X = i * 120 + 120
            grpmain.DrawString(charsizew(i) & "x" & charsizeh(i), mfont2, mbrush, i * 150, 7)
            grpmain.DrawLine(p, p1, p2)
        Next
        p1.X = 0
        p1.Y = 40
        p2.X = bmpmain.Width
        p2.Y = 40
        grpmain.DrawLine(p, p1, p2)

        For j = 0 To Int(txtItemPerPage.Text) - 1
            'u(0) = &HF0
            'u(1) = &H80 + ((map(j + start) And &H3F000) >> 12)
            'u(2) = &H80 + ((map(j + start) And &HFC0) >> 6)
            'u(3) = &H80 + (map(j + start) And &H3F)
            'Dim s = System.Text.Encoding.UTF8.GetString(u)
            'grpmain.DrawString(s, mfont, mbrush, 15, 15 + 120 * j + 40)
            grpmain.DrawString(Hex(map(j + start)), mfont2, mbrush, 30, 100 + 120 * j + 40)
            'p1.X = 0
            'p1.Y = j * 120 + 120 + 40
            'p2.X = bmpmain.Width
            'p2.Y = j * 120 + 120 + 40
            'grpmain.DrawLine(p, p1, p2)
            For i = 0 To files
                If ReadChar(r(i), charsizew(i), charsizeh(i), bmp(i)) = -1 Then
                    picMain.Refresh()
                    Exit Sub
                End If
                grpmain.DrawImage(bmp(i), destrect(i).X, destrect(i).Y + 120 * j + 40, destrect(i).Width, destrect(i).Height)
                p1.X = i * 120 + 120
                p1.Y = j * 120 + 40
                p2.X = i * 120 + 120
                p2.Y = j * 120 + 120 + 40
                grpmain.DrawLine(p, p1, p2)
            Next
            p1.X = (files) * 120 + 120
            p1.Y = j * 120 + 40
            p2.X = (files) * 120 + 120
            p2.Y = j * 120 + 120 + 40
            grpmain.DrawLine(p, p1, p2)
            p1.X = 0
            p1.Y = j * 120 + 160
            p2.X = bmpmain.Width
            p2.Y = j * 120 + 160
            grpmain.DrawLine(p, p1, p2)
        Next
        picMain.Refresh()
    End Sub

    Private Sub Rander()
        Try
            ' Init Files
            Dim files() As String
            files = Split(txtFileNames.Text, ",")
            If files.Length <= 0 Then
                Exit Sub
            End If
            Dim fs(files.Length) As System.IO.FileStream
            Dim bw(files.Length) As System.IO.BinaryReader
            Dim charsizeW(files.Length) As Integer
            Dim charsizeH(files.Length) As Integer
            For i = 0 To UBound(files)
                fs(i) = New System.IO.FileStream(txtStartupFolder.Text & files(i), IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
                bw(i) = New System.IO.BinaryReader(fs(i))
                charsizeW(i) = files(i).Substring(4, 2)
                charsizeH(i) = files(i).Substring(6, 2)
            Next

            ' Init code range
            Dim codeSect() As String
            Dim codeStart As Integer
            Dim codeEnd As Integer
            codeSect = Split(txtCodeRange.Text, ",")
            If codeSect.Length <= 0 Then
                Exit Sub
            End If
            Dim a = codeSect(0).Split("-")
            codeStart = Val("&H" & a(0))
            a = codeSect(UBound(codeSect)).Split("-")
            codeEnd = Val("&H" & a(UBound(a)))
            Dim map(codeEnd - codeStart + 1) As Integer
            Dim n = 0
            For i = 0 To codeSect.Length - 1
                a = codeSect(i).Split("-")
                For j = Val("&H" & a(0)) To Val("&H" & a(1))
                    map(n) = j
                    n += 1
                Next
            Next

            ' read data
            Dim bmp(UBound(files)) As Bitmap
            Dim destRect(UBound(files)) As RectangleF
            Dim srcRect(UBound(files)) As RectangleF
            For i = 0 To UBound(files)
                bmp(i) = New Bitmap(charsizeW(i), charsizeH(i))
                destRect(i).X = 120 * (i) + 20
                destRect(i).Y = 20
                destRect(i).Width = 80
                destRect(i).Height = 80
                'srcRect(i).X = 0
                'srcRect(i).Y = 0
                'srcRect(i).Width = charsizeW(i)
                'srcRect(i).Height = charsizeH(i)
            Next
            Dim bmpMain As New Bitmap(120 * (files.Length + 1) + 360, 120 * Int(txtItemPerPage.Text) + 40)
            picMain.Image = bmpMain
            Dim grpMain As Graphics = Graphics.FromImage(picMain.Image)

            'For j = codeStart To codeEnd
            grpMain.SmoothingMode = Drawing2D.SmoothingMode.None
            grpMain.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor
            grpMain.FillRectangle(New SolidBrush(Color.White), 0, 0, bmpMain.Width, bmpMain.Height)
            Dim mFont = New Font("方正宋一扩展B", 54)
            Dim mFont2 = New Font("宋体", 16)
            Dim mBrush As New SolidBrush(Color.Black)
            Dim u(4) As Byte
            Dim p = New Pen(mBrush)

            For i = 0 To (n + Int(txtItemPerPage.Text) - 1) / Int(txtItemPerPage.Text)
                grpMain.FillRectangle(New SolidBrush(Color.White), 0, 0, bmpMain.Width, bmpMain.Height)
                RanderPage(bw, map, grpMain, mFont, mFont2, mBrush, p, bmpMain, files.Length - 1, charsizeW, charsizeH, bmp, destRect, i * Int(txtItemPerPage.Text))
                picMain.Refresh()
                picMain.Image.Save(txtSubFolder.Text & "." & map(i * Int(txtItemPerPage.Text)) & ".png")
            Next

            For i = 0 To UBound(files) - 1
                bmp(i).Dispose()
                bw(i).Dispose()
                fs(i).Close()
                fs(i).Dispose()
            Next

        Catch ex2 As Exception
            MessageBox.Show("Error on open RAW file : " & vbCrLf & ex2.Message & vbCrLf & ex2.StackTrace)
            picMain.Refresh()
            Exit Sub
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Rander()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        picMain.Image.Save(txtSubFolder.Text & ".png")
    End Sub

    Private Sub txtCodeRange_TextChanged(sender As Object, e As EventArgs) Handles txtCodeRange.TextChanged

    End Sub
End Class