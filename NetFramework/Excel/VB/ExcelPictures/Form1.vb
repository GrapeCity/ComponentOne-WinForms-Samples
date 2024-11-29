Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports C1.Excel

Public Class Form1

    Private Sub _btCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btCreate.Click
        Save(CreateSample())
    End Sub

    Private Sub Save(ByVal wb As C1XLBook)

        If wb Is Nothing Then
            Exit Sub
        End If

        Dim path As String = System.IO.Path.Combine(Application.StartupPath, "test.xls")

        If _radioDialog.Checked Then

            Using dlg As SaveFileDialog = New SaveFileDialog()
                dlg.Filter = "Open binary MS Excel file (*.xls)|*.xls"
                dlg.Title = "Save As MS Excel File"
                dlg.OverwritePrompt = True
                dlg.RestoreDirectory = True
                If dlg.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
                    Exit Sub
                End If
                path = dlg.FileName
            End Using
        End If

        wb.Save(path)

        If _cbPreview.Checked Then
            Try
                Process.Start(path)
            Catch
            End Try
        End If
    End Sub

    Public Function CreateSample() As C1XLBook

        ' create C1XLBook
        Dim wb As New C1XLBook()

        ' three methods add images to Excel file
        Dim picture As XLPictureShape

        Dim metaData As Byte() = My.Resources.meta

        ' create images
        Dim metafile As Metafile
        Dim spbImage As Image = My.Resources.spb
        Dim googleImage As Image = My.Resources.google
        Dim babyImage As Image = My.Resources.baby
        Dim canadaImage As Image = My.Resources.canada

        Dim ms As MemoryStream = New MemoryStream()
        ms.Write(metaData, 0, metaData.Length)
        ms.Seek(0, SeekOrigin.Begin)
        metafile = System.Drawing.Imaging.Metafile.FromStream(ms)
        ms.Close()

        ''''''''''''''''''''''''''''/
        ' List "Images" -- three methods add images
        ''''''''''''''''''''''''''''/
        Dim sheet As XLSheet = wb.Sheets(0)
        sheet.Name = "Images"

        ' first method
        picture = New XLPictureShape(googleImage, 0, 0, 2200, 5000)
        picture.DashedLineStyle = XLShapeDashedLineStyle.Solid
        picture.LineStyle = XLShapeLineStyle.Simple
        picture.LineColor = Color.BlueViolet
        picture.Rotation = 90.0F
        picture.LineWidth = 10
        sheet(1, 7).Value = picture
        sheet(1, 1).Value = metafile

        ' second method
        picture = New XLPictureShape(spbImage, 1500, 5500, 8000, 6000)
        picture.Brightness = 0.55F
        picture.Contrast = 0.5F
        sheet.Shapes.Add(picture)

        picture = New XLPictureShape(canadaImage)
        picture.LineColor = Color.Aqua
        picture.LineWidth = 100
        sheet.PrintSettings.HeaderPictureLeft = picture

        ' third method
        picture = New XLPictureShape(babyImage)
        picture.Rotation = 30.0F
        picture.LineColor = Color.Aqua
        picture.LineWidth = 100
        sheet(15, 2).Value = picture

        ''''''''''''''''''''''''''''/
        ' List "Types" -- support image types (bmp, png, jpg, emf)
        ''''''''''''''''''''''''''''/
        sheet = wb.Sheets.Add("Types")
        sheet(1, 0).Value = "Bmp:"
        sheet(1, 1).Value = googleImage
        sheet(8, 0).Value = "Png:"
        sheet(8, 1).Value = babyImage
        sheet(25, 0).Value = "Jpeg:"
        sheet(25, 1).Value = spbImage
        sheet(34, 0).Value = "Emf:"
        sheet(34, 1).Value = metafile

        ''''''''''''''''''''''''''''/
        ' List "Borders" -- various picture borders
        ''''''''''''''''''''''''''''/
        sheet = wb.Sheets.Add("Borders")
        Dim row As Integer, col As Integer
        row = 1
        col = 0
        Dim style As XLShapeLineStyle
        For Each style In [Enum].GetValues(GetType(XLShapeLineStyle))

            col = 1
            sheet.Rows(row).Height = 3700

            Dim dashedStyle As XLShapeDashedLineStyle
            For Each dashedStyle In [Enum].GetValues(GetType(XLShapeDashedLineStyle))

                sheet.Columns(col).Width = 2300
                picture = New XLPictureShape(babyImage)
                picture.LineWidth = 100
                picture.LineColor = Color.FromArgb(100, 200, Math.Min(col * 12, 255))
                picture.DashedLineStyle = dashedStyle
                picture.LineStyle = style
                sheet(row, col).Value = picture
                sheet(row + 1, col).Value = "style: " + style.ToString()
                sheet(row + 2, col).Value = "dashed: " + dashedStyle.ToString()

                col = col + 2
            Next

            row = row + 4
        Next

        ''''''''''''''''''''''''''''/
        ' List "Alignment" -- position image using ContentAlignment
        ''''''''''''''''''''''''''''/
        sheet = wb.Sheets.Add("Alignment")
        row = 1
        sheet.Columns(1).Width = 6000
        sheet.Columns(4).Width = 6000
        sheet.Columns(7).Width = 2000
        sheet.Columns(10).Width = 2000

        For Each horizontalAlignment As XLAlignHorz In [Enum].GetValues(GetType(XLAlignHorz))
            For Each verticalAlignment As XLAlignVert In [Enum].GetValues(GetType(XLAlignVert))
                sheet.Rows(row).Height = 2400

                Dim cellSize As New Size(sheet.Columns(1).Width, sheet.Rows(row).Height)
                picture = New XLPictureShape(googleImage, cellSize, horizontalAlignment, verticalAlignment, ImageScaling.Clip)
                sheet(row, 1).Value = picture
                sheet(row, 2).Value = $"clip: {horizontalAlignment} {verticalAlignment}"

                picture = New XLPictureShape(googleImage, cellSize, horizontalAlignment, verticalAlignment, ImageScaling.Scale)
                sheet(row, 4).Value = picture
                sheet(row, 5).Value = $"scale: {horizontalAlignment} {verticalAlignment}"

                row += 4
            Next
        Next

        ''''''''''''''''''''''''''''/
        ' List "Properties" -- various picture properties
        ''''''''''''''''''''''''''''/
        sheet = wb.Sheets.Add("Properties")

        ' associating hyperlink with the shape
        sheet.Rows(1).Height = 2000
        sheet.Columns(1).Width = 3600
        picture = New XLPictureShape(spbImage)
        picture.Hyperlink = "http://www.componentone.com"
        sheet(1, 1).Value = picture
        sheet(2, 1).Value = "hyperlink (click on the picture)"

        ' other view types
        col = 1
        sheet.Rows(4).Height = 2000
        Dim viewType As XLPictureViewType
        For Each viewType In [Enum].GetValues(GetType(XLPictureViewType))

            sheet.Columns(col).Width = 3600
            picture = New XLPictureShape(spbImage)
            picture.ViewType = viewType
            sheet(4, col).Value = picture
            sheet(5, col).Value = "view type: " + viewType.ToString()

            col = col + 2
        Next

        ' brightness & contrast
        col = 1
        sheet.Rows(7).Height = 2000
        sheet.Rows(10).Height = 2000
        Dim i As Integer
        For i = 0 To 100 Step 10

            sheet.Columns(col).Width = 3600
            picture = New XLPictureShape(spbImage)
            picture.Brightness = i / 100.0
            sheet(7, col).Value = picture
            sheet(8, col).Value = String.Format("brightness: {0}", picture.Brightness)

            picture = New XLPictureShape(spbImage)
            picture.Contrast = i / 100.0
            sheet(10, col).Value = picture
            sheet(11, col).Value = String.Format("contrast: {0}", picture.Contrast)

            col = col + 2
        Next

        ' done
        Return wb
    End Function


End Class
