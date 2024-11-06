Imports C1.Excel

Public Class Form1

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click

        ' clear book
        C1XLBook1.Clear()

        ' add some styles
        Dim s1 As New XLStyle(C1XLBook1)
        Dim s2 As New XLStyle(C1XLBook1)
        Dim s3 As New XLStyle(C1XLBook1)
        s1.Format = "#,##0.00000"
        s2.Format = "#,##0.00000"
        s2.Font = New XLFont("Courier New", 14)
        s3.Format = "dd-MMM-yy"

        ' populate sheet with some random values
        Dim sheet As XLSheet = C1XLBook1.Sheets(0)
        Dim r As New Random()
        Dim i As Integer
        For i = 0 To 99
            sheet(i, 0).Value = r.NextDouble() * 100000
            sheet(i, 0).Style = IIf(i Mod 13 = 0, s2, s1)
        Next
        For i = 0 To 99
            sheet(i, 1).Value = New DateTime(2005, r.Next(1, 12), r.Next(1, 28))
            sheet(i, 1).Style = s3
        Next

	Dim tempdir As String = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")+1)

        ' save with default column widths
        C1XLBook1.Save(tempdir + "defaultWidth.xls")

        ' autosize columns
        AutoSizeColumns(sheet)

        ' save again after autosizing
        C1XLBook1.Save(tempdir + "autoSized.xls")

        ' show the autosized version
        System.Diagnostics.Process.Start(tempdir + "autoSized.xls")

    End Sub

    Private Sub AutoSizeColumns(ByVal sheet As XLSheet)

        Using g As Graphics = Graphics.FromHwnd(IntPtr.Zero)

            Dim r As Integer, c As Integer
            For c = 0 To sheet.Columns.Count - 1

                Dim colWidth As Integer = -1
                For r = 0 To sheet.Rows.Count - 1

                    Dim value As Object = sheet(r, c).Value
                    If Not (value Is Nothing) Then

                        ' get value (unformatted at this point)
                        Dim text As String = value.ToString()

                        ' format value if cell has a style with format set
                        Dim s As XLStyle = sheet(r, c).Style
                        If Not (s Is Nothing) And s.Format.Length > 0 Then
                            Dim ifmt As IFormattable = TryCast(value, IFormattable)
                            If Not (ifmt Is Nothing) Then
                                Dim fmt As String = XLStyle.FormatXLToDotNet(s.Format)
                                text = ifmt.ToString(fmt, System.Globalization.CultureInfo.CurrentCulture)
                            End If
                        End If

                        ' get font (default or style)
                        Dim font As Font = ConvertXLFont(sheet.Book.DefaultFont)
                        If Not (s Is Nothing) Then
                            If Not (s.Font Is Nothing) Then
                                font = ConvertXLFont(s.Font)
                            End If
                        End If

                        ' measure string (add a little tolerance)
                        Dim sz As Size = Size.Ceiling(g.MeasureString(text + "XX", font))

                        ' keep widest so far
                        If sz.Width > colWidth Then
                            colWidth = sz.Width
                        End If
                    End If

                    ' done measuring, set column width
                    If colWidth > -1 Then
                        sheet.Columns(c).Width = C1XLBook.PixelsToTwips(colWidth)
                    End If
                Next
            Next
        End Using
    End Sub

    Function ConvertXLFont(ByVal font As XLFont) As Font
        Dim fs As FontStyle = FontStyle.Regular
        If font.Bold Then fs = fs Or FontStyle.Bold
        If font.Italic Then fs = fs Or FontStyle.Italic
        If font.Strikeout Then fs = fs Or FontStyle.Strikeout
        If font.Underline <> XLUnderlineStyle.None Then fs = fs Or FontStyle.Underline
        Return New Font(font.FontName, font.FontSize, fs)
    End Function

End Class
