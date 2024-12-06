Public Class clsCharset
    Public codepage As Integer = 0
    Public codepageSubset As Integer

    Public codeLength As Integer = 0
    Public codeUltraHigh As Integer ' for ISO/IEC 10646 SMP, SIP, TIP
    Public codeHigh(256) As Integer ' list of high byte(len=2,3), high 4bits(len=1)
    Public codeLow(256) As Integer  ' list of low byte(len=2,3), low 4bits(len=1)

    Public codeWidth As Integer = 0
    Public codeHeight As Integer = 0
    Public cellWidth As Integer = 0
    Public cellHeight As Integer = 0

    Public Sub create(cp As Integer, subset As String)
        Dim codeHighRange() As Integer
        Dim codeLowRange() As Integer

        codepage = cp
        Select Case cp
            Case 1200 ' "UnicodeUCS16(1200)", "ISO/IEC10646BMP(1200)"
                codepageSubset = 0
                codeLength = 2
                codeUltraHigh = 0
                codeHighRange = {0, 255}
                codeLowRange = {0, 255}
            Case 65005 ' "ISO/IEC10646SMP(65005)", "ISO/IEC10646SIP(65005)", "ISO/ IEC10646TIP(65005)", "ISO/ IEC10646 - Fxxxx(65005)"
                codeLength = 3
                Select Case subset
                    Case "smp", "1"
                        codeUltraHigh = 1
                        codepageSubset = 1
                    Case "sip", "2"
                        codeUltraHigh = 2
                        codepageSubset = 2
                    Case "tip", "3"
                        codeUltraHigh = 3
                        codepageSubset = 3
                    Case Else
                        codeUltraHigh = Int(subset)
                End Select
                codeHighRange = {0, 255}
                codeLowRange = {0, 255}
            Case 1252 '"ASCII-7(1252)"，"ASCII-8(1252)"
                codeLength = 1
                Select Case subset
                    Case "7bit", "7"
                        codepageSubset = 7
                        codeHighRange = {0, 7}
                        codeLowRange = {0, 15}
                    Case "8bit", "8"
                        codepageSubset = 8
                        codeHighRange = {0, 15}
                        codeLowRange = {0, 15}
                    Case Else
                        codepageSubset = 8
                        codeHighRange = {0, 15}
                        codeLowRange = {0, 15}
                End Select
            Case 936 ' "GB2312双字节(936)","GBK双字节(936)","GB18030双字节(936)","GB2312单字节(936)"
                codeUltraHigh = 0
                Select Case subset
                    Case "single", "1"
                        codepageSubset = 1
                        codeLength = 1
                        codeHighRange = {0, 7}
                        codeLowRange = {0, 15}
                    Case "gb2312", "2"
                        codepageSubset = 2
                        codeLength = 2
                        codeHighRange = {&HA1, &HFE}
                        codeLowRange = {&HA1, &HFE}
                    Case "gbk", "gb18030", "3"
                        codepageSubset = 3
                        codeLength = 2
                        codeHighRange = {&H81, &HFE}
                        codeLowRange = {&H40, &H7E, &H80, &HFE}
                    Case Else
                        codeLength = 2
                        codepageSubset = 3
                        codeHighRange = {&H81, &HFE}
                        codeLowRange = {&H40, &H7E, &H80, &HFE}
                End Select
            Case 950 '"Big-5双字节(950)"，"Big-5单字节(950)"
                codeUltraHigh = 0
                Select Case subset
                    Case "single", "1"
                        codepageSubset = 1
                        codeLength = 1
                        codeHighRange = {0, 15}
                        codeLowRange = {0, 7}
                    Case "double", "2"
                        codepageSubset = 2
                        codeLength = 2
                        codeHighRange = {&H81, &HFE}
                        codeLowRange = {&H40, &H7E, &HA1, &HFE}
                    Case Else
                        codepageSubset = 2
                        codeLength = 2
                        codeHighRange = {&H81, &HFE}
                        codeLowRange = {&H40, &H7E, &HA1, &HFE}
                End Select
            Case 932 '"Shift-JIS双字节(932)","Shift-JIS单字节(932)"
                codeUltraHigh = 0
                Select Case subset
                    Case "single", "1"
                        codepageSubset = 1
                        codeLength = 1
                        codeHighRange = {0, 7, &HA, &HD}
                        codeLowRange = {0, 15}
                    Case "double", "2"
                        codepageSubset = 2
                        codeLength = 2
                        codeHighRange = {&H81, &H9F, &HE0, &HFC}
                        codeLowRange = {&H40, &H7E, &H80, &HFC}
                    Case Else
                        codepageSubset = 2
                        codeLength = 2
                        codeHighRange = {&H81, &H9F, &HE0, &HFC}
                        codeLowRange = {&H40, &H7E, &H80, &HFC}
                End Select
            Case Else
                codepageSubset = 0
                codeLength = 2
                codeUltraHigh = 0
                codeHighRange = {0, 255}
                codeLowRange = {0, 255}
        End Select

        Dim i, j As Integer
        For i = 0 To 255
            codeLow(i) = 0
            codeHigh(i) = 0
        Next
        codeWidth = 0
        codeHeight = 0
        Dim c As Integer
        c = 0
        For i = 0 To codeHighRange.Length - 1 Step 2
            codeHeight = codeHeight + codeHighRange(i + 1) - codeHighRange(i) + 1
            For j = codeHighRange(i) To codeHighRange(i + 1)
                codeHigh(c) = j
                c += 1
            Next
        Next
        c = 0
        For i = 0 To codeLowRange.Length - 1 Step 2
            codeWidth = codeWidth + codeLowRange(i + 1) - codeLowRange(i) + 1
            For j = codeLowRange(i) To codeLowRange(i + 1)
                codeLow(c) = j
                c += 1
            Next
        Next
    End Sub

    Public Sub create(codepage_name As String)
        Select Case codepage_name
            Case "ASCII-7(1252)"
                create(1252, "7")
            Case "ASCII-8(1252)"
                create(1252, "8")
            Case "UnicodeUCS16(1200)", "ISO/IEC10646BMP(1200)"
                create(1200, "0")
            Case "ISO/IEC10646SMP(65005)"
                create(65005, "1")
            Case "ISO/IEC10646SIP(65005)"
                create(65005, "2")
            Case "ISO/IEC10646TIP(65005)"
                create(65005, "3")
            Case "ISO/IEC10646-Fxxxx(65005)"
                create(65005, "15")
            Case "GB2312双字节(936)"
                create(936, "2")
            Case "GBK双字节(936)"
                create(936, "3")
            Case "GB18030双字节(936)"
                create(936, "3")
            Case "GB18030单字节(936)"
                create(936, "1")
            Case "Big-5双字节(950)"
                create(950, "2")
            Case "Big-5单字节(950)"
                create(950, "1")
            Case "Shift-JIS双字节(932)"
                create(932, "2")
            Case "Shift-JIS单字节(932)"
                create(932, "1")
            Case Else
                create(0, "0")
        End Select
    End Sub

    Public Sub create(cp As Integer, subset As String, w As Integer, h As Integer)
        create(cp, subset)
        cellWidth = w
        cellHeight = h
    End Sub

End Class
