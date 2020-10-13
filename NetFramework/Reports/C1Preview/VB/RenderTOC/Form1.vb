Imports C1.C1Preview
Imports System.Text

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakeDoc1(C1PrintDocument1)
        C1PrintDocument1.Generate()
    End Sub

    Private Sub MakeDoc1(ByVal doc As C1PrintDocument)
        ' create the document title
        Dim docTitle As New RenderParagraph()
        docTitle.Content.AddText("This document demonstates the use of ")
        docTitle.Content.AddText("RenderToc", Color.Blue)
        docTitle.Content.AddText(" object to create the table of content.")
        doc.Body.Children.Add(docTitle)

        ' in this cycle we generate the document chapters, each chapter
        ' has some parts, each chapter and part has an entry in the RenderToc object
        Dim chapterCount As Integer = 10 ' chapter count
        Dim partCount As Integer = 5     ' parts count

        ' generate sample text that will serve as introduction to chapter
        Dim chapterIntroduction As New StringBuilder("Introduction")
        Dim i As Integer
        For i = 0 To 40
            chapterIntroduction.Append(" introduction")
        Next i
        chapterIntroduction.Append(vbNewLine)

        ' generate sample text that will be displayed as content of part of chapter
        Dim partContent As New StringBuilder("Content of part")
        For i = 0 To 80
            partContent.Append(" content of part")
        Next i
        partContent.Append("." & vbNewLine)

        ' create an instance of RenderToc object
        Dim toc As New C1.C1Preview.RenderToc
        toc.BreakAfter = BreakEnum.Page

        ' Create styles for chaprters and parts
        Dim chapterTitleStyle As Style = doc.Style.Children.Add()
        chapterTitleStyle.Font = New Font("Verdana", 15, FontStyle.Bold)
        chapterTitleStyle.BackColor = Color.LightSteelBlue
        chapterTitleStyle.Spacing.Bottom = "5mm"
        Dim partTitleStyle As Style = doc.Style.Children.Add()
        partTitleStyle.Font = New Font("Tahoma", 13)
        partTitleStyle.Spacing.Top = "3mm"
        partTitleStyle.Spacing.Bottom = "1mm"

        ' loop over chapters
        Dim c As Integer
        For c = 1 To chapterCount
            ' each chapter will be represented as a RenderArea object
            Dim chapter As New RenderArea()
            If (c < chapterCount - 1) Then
                chapter.BreakAfter = BreakEnum.Page
            End If

            Dim chapterTitle = New RenderText(String.Format("Chapter {0}", c), chapterTitleStyle)
            chapter.Children.Add(chapterTitle)
            chapter.Children.Add(New RenderText(chapterIntroduction.ToString(), AlignHorzEnum.Justify))

            ' add item for the chapter to the RenderToc
            toc.AddItem(chapterTitle.Text, chapterTitle, 1)

            ' loop over the current chapter's parts
            Dim p As Integer
            For p = 1 To partCount
                Dim partTitle As New RenderText(String.Format("Chapter {0} part {1}", c, p), partTitleStyle)
                chapter.Children.Add(partTitle)
                chapter.Children.Add(New RenderText(partContent.ToString(), AlignHorzEnum.Justify))

                ' add item for the chapter part to the RenderToc
                toc.AddItem(String.Format("Part {0}", p), partTitle, 2)
            Next p
            ' add the chapter to the document
            doc.Body.Children.Add(chapter)
        Next c

        ' insert the RenderToc into the document immediatedly after the title
        doc.Body.Children.Insert(1, toc)
    End Sub
End Class
