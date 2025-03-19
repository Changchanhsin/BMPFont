Imports System.Xml

Public Class clsTTF


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


    Private Sub saveFontXML(fnt As clsFont, bmp As clsBMP)
        Dim i, j, k, l As Integer
        Dim c As Color
        Dim grid, gap, round As Integer

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
        xmlAddNodeValue(xd, head, "unitsPerEm", fnt.cellWidth * 10)
        xmlAddNodeValue(xd, head, "created", "Tue Jun 28 00:12:30 2011")
        xmlAddNodeValue(xd, head, "modified", "Tue Jun 28 00:12:30 2011")
        xmlAddNodeValue(xd, head, "xMin", 0)
        xmlAddNodeValue(xd, head, "yMin", 0)
        xmlAddNodeValue(xd, head, "xMax", fnt.cellWidth * 10)
        xmlAddNodeValue(xd, head, "yMax", fnt.cellHeight * 10)
        xmlAddNodeValue(xd, head, "macStyle", "00000000 00000000")
        xmlAddNodeValue(xd, head, "lowestRecPPEM", 8)
        xmlAddNodeValue(xd, head, "fontDirectionHint", 2)
        xmlAddNodeValue(xd, head, "indexToLocFormat", 1)
        xmlAddNodeValue(xd, head, "glyphDataFormat", 0)

        Dim hhea = xd.CreateElement("hhea")
        xmlAddNodeValue(xd, hhea, "tableVersion", "0x00010000")
        xmlAddNodeValue(xd, hhea, "ascent", fnt.cellWidth * 10)
        xmlAddNodeValue(xd, hhea, "descent", -fnt.cellWidth * 3)
        xmlAddNodeValue(xd, hhea, "lineGap", 0)
        xmlAddNodeValue(xd, hhea, "advanceWidthMax", fnt.cellWidth * 10)
        xmlAddNodeValue(xd, hhea, "minLeftSideBearing", -fnt.cellWidth)
        xmlAddNodeValue(xd, hhea, "minRightSideBearing", fnt.cellWidth)
        xmlAddNodeValue(xd, hhea, "xMaxExtent", fnt.cellWidth * 10)
        xmlAddNodeValue(xd, hhea, "caretSlopeRise", 1)
        xmlAddNodeValue(xd, hhea, "caretSlopeRun", 0)
        xmlAddNodeValue(xd, hhea, "caretOffset", 0)
        xmlAddNodeValue(xd, hhea, "reserved0", 0)
        xmlAddNodeValue(xd, hhea, "reserved1", 0)
        xmlAddNodeValue(xd, hhea, "reserved2", 0)
        xmlAddNodeValue(xd, hhea, "reserved3", 0)
        xmlAddNodeValue(xd, hhea, "metricDataFormat", 0)
        xmlAddNodeValue(xd, hhea, "numberOfHMetrics", fnt.codeWidth * fnt.codeHeight)

        Dim maxp = xd.CreateElement("maxp")
        xmlAddNodeValue(xd, maxp, "tableVersion", "0x10000")
        xmlAddNodeValue(xd, maxp, "numGlyphs", fnt.codeWidth * fnt.codeHeight)
        xmlAddNodeValue(xd, maxp, "maxPoints", fnt.codeWidth * fnt.codeHeight)
        xmlAddNodeValue(xd, maxp, "maxContours", fnt.cellWidth * fnt.cellHeight)
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
        xmlAddNodeValue(xd, os2, "xAvgCharWidth", fnt.cellWidth * 10)
        xmlAddNodeValue(xd, os2, "usWeightClass", fnt.cellHeight * 10)
        xmlAddNodeValue(xd, os2, "usWidthClass", 5)
        xmlAddNodeValue(xd, os2, "fsType", "00000000 00000100")
        xmlAddNodeValue(xd, os2, "ySubscriptXSize", fnt.cellWidth * 5)
        xmlAddNodeValue(xd, os2, "ySubscriptYSize", fnt.cellHeight * 5)
        xmlAddNodeValue(xd, os2, "ySubscriptXOffset", 0)
        xmlAddNodeValue(xd, os2, "ySubscriptYOffset", 0)
        xmlAddNodeValue(xd, os2, "ySuperscriptXSize", fnt.cellWidth * 5)
        xmlAddNodeValue(xd, os2, "ySuperscriptYSize", fnt.cellHeight * 5)
        xmlAddNodeValue(xd, os2, "ySuperscriptXOffset", 0)
        xmlAddNodeValue(xd, os2, "ySuperscriptYOffset", fnt.cellHeight * 5)
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
        xmlAddNodeValue(xd, os2, "sTypoAscender", fnt.cellHeight * 5)
        xmlAddNodeValue(xd, os2, "sTypoDescender", 0)
        xmlAddNodeValue(xd, os2, "sTypoLineGap", 0)
        xmlAddNodeValue(xd, os2, "usWinAscent", fnt.cellHeight * 10)
        xmlAddNodeValue(xd, os2, "usWinDescent", fnt.cellHeight * 2)
        xmlAddNodeValue(xd, os2, "ulCodePageRange1", "00000000 00000000 00000000 00000001")
        xmlAddNodeValue(xd, os2, "ulCodePageRange2", "00000000 00000000 00000000 00000000")
        xmlAddNodeValue(xd, os2, "sxHeight", fnt.cellHeight * 10)
        xmlAddNodeValue(xd, os2, "sCapHeight", fnt.cellHeight * 10)
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
        For j = 0 To fnt.codeHeight - 1
            For i = 0 To fnt.codeWidth - 1
                Dim GlyphID = xd.CreateElement("GlyphID")
                GlyphID.SetAttribute("name", $"char{fnt.loc2code(i, j)}")
                GlyphOrder.AppendChild(GlyphID)

                Dim mtx = xd.CreateElement("mtx")
                mtx.SetAttribute("name", "char" & fnt.loc2code(i, j))
                mtx.SetAttribute("width", fnt.cellWidth * 10)
                mtx.SetAttribute("lsb", "0")
                hmtx.AppendChild(mtx)

                Dim map = xd.CreateElement("map")
                map.SetAttribute("name", "char" & fnt.loc2code(i, j))
                map.SetAttribute("code", "0x" & fnt.loc2code(i, j))
                cmap_format_4_1.AppendChild(map)
                cmap_format_4_2.AppendChild(map.Clone)

                Dim TTGlyph = xd.CreateElement("TTGlyph")
                TTGlyph.SetAttribute("name", "char" & fnt.loc2code(i, j))
                TTGlyph.SetAttribute("xMin", "0")
                TTGlyph.SetAttribute("yMin", "0")
                TTGlyph.SetAttribute("xMax", fnt.cellWidth * 10)
                TTGlyph.SetAttribute("yMax", fnt.cellHeight * 10)

                'If chkGap.Checked Then
                gap = 1
                'Else
                'gap = 0
                'End If
                Dim b As Bitmap = bmp.picMain.Image
                For k = 0 To fnt.cellHeight - 1
                    For l = 0 To fnt.cellWidth - 1
                        c = b.GetPixel(i * (fnt.cellWidth + 1) + l, j * (fnt.cellHeight + 1) + k)
                        If (c.R * 9 + c.G * 19 + c.B * 4 >> 5) < 128 And c.A > 128 Then
                            Dim contour = xd.CreateElement("contour")
                            Dim pt1 = xd.CreateElement("pt")
                            pt1.SetAttribute("x", l * 10 + 10 - gap)
                            pt1.SetAttribute("y", fnt.cellHeight * 7 - k * 10 + gap)
                            pt1.SetAttribute("on", "1")
                            contour.AppendChild(pt1)
                            Dim pt2 = xd.CreateElement("pt")
                            pt2.SetAttribute("x", l * 10 + 10 - gap)
                            pt2.SetAttribute("y", fnt.cellHeight * 7 - k * 10 + 10 - gap)
                            pt2.SetAttribute("on", "1")
                            contour.AppendChild(pt2)
                            Dim pt3 = xd.CreateElement("pt")
                            pt3.SetAttribute("x", l * 10 + gap)
                            pt3.SetAttribute("y", fnt.cellHeight * 7 - k * 10 + 10 - gap)
                            pt3.SetAttribute("on", "1")
                            contour.AppendChild(pt3)
                            Dim pt4 = xd.CreateElement("pt")
                            pt4.SetAttribute("x", l * 10 + gap)
                            pt4.SetAttribute("y", fnt.cellHeight * 7 - k * 10 + gap)
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
            'goProgress(j + 1)
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
        '        xmlAddNamerecord(xd, _name, "1", txtSaveImage.Text) ' font name
        xmlAddNamerecord(xd, _name, "2", "Regular") ' font type
        '       xmlAddNamerecord(xd, _name, "3", "BMPFont " & txtSaveImage.Text) ' font name full
        '      xmlAddNamerecord(xd, _name, "4", txtSaveImage.Text & " Regular") ' font type full
        xmlAddNamerecord(xd, _name, "5", "Version 1.0") ' version
        '     xmlAddNamerecord(xd, _name, "6", txtSaveImage.Text) ' font name
        xmlAddNamerecord(xd, _name, "7", "BMPFont, is a tool from Chanhsin") ' builder note
        xmlAddNamerecord(xd, _name, "8", "http://github") ' builder url
        xmlAddNamerecord(xd, _name, "9", "Chanhsin") ' builder name
        '    xmlAddNamerecord(xd, _name, "10", txtSaveImage.Text & " was build with BMPFont") ' builder name
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
        '  xd.Save(txtSaveImagePath.Text & "\" & txtSaveImage.Text & ".TTX")
        '   endProgress()
    End Sub
End Class
