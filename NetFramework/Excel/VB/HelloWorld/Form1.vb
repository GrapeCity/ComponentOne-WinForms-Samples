Imports C1.Excel

Public Class Form1

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click

        ' step 1: create a new workbook
        Dim book As C1XLBook = New C1XLBook()

        ' step 2: get the sheet that was created by default, give it a name
        Dim sheet As XLSheet = book.Sheets(0)
        sheet.Name = "Hello World"

        ' step 3: create styles for odd and even values
        Dim styleOdd As XLStyle = New XLStyle(book)
        styleOdd.Font = New XLFont("Tahoma", 9, False, True)
        styleOdd.ForeColor = Color.Blue
        Dim styleEven As XLStyle = New XLStyle(book)
        styleEven.Font = New XLFont("Tahoma", 9, True, False)
        styleEven.ForeColor = Color.Red

        ' step 3: write content and format into some cells
        Dim i As Integer
        For i = 0 To 99

            Dim cell As XLCell = sheet(i, 0)
            cell.Value = i + 1
            cell.Style = IIf(((i + 1) Mod 2 = 0), styleEven, styleOdd)
        Next

        ' step 4: save the file
        Dim fileName As String = Application.StartupPath + "\hello.xls"
        book.Save(fileName)
        System.Diagnostics.Process.Start(fileName)

    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click

        ' create book (will have a single sheet by default)
        Dim book As C1XLBook = New C1XLBook()

        MessageBox.Show(String.Format("The book has {0} sheet", book.Sheets.Count))

        ' add three blank sheets
        Dim i As Integer
        For i = 0 To 2
            book.Sheets.Add()
        Next

        MessageBox.Show(String.Format("The book now has {0} sheets", book.Sheets.Count))

    End Sub
End Class
