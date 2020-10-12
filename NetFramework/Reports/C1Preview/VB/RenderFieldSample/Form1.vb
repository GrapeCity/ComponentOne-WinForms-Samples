Imports C1.C1Preview
Imports C1.C1Preview.Import

Public Class Form1

    Private Sub CreateDoc()
        Dim rf As RenderField

        doc.Body.Children.Add(New RenderText("Simple RenderField object with text:"))
        doc.Body.Children.Add(New RenderEmpty("5mm"))
        rf = New RenderField()
        rf.Text = "Simple RenderField object"
        rf.Style.Font = New Font("Tahoma", 20)
        rf.Style.BackColor = Color.LightBlue
        doc.Body.Children.Add(rf)

        doc.Body.Children.Add(New RenderEmpty("5mm"))
        doc.Body.Children.Add(New RenderText("RenderField contains an expression and its Calculated property is true:"))
        doc.Body.Children.Add(New RenderEmpty("5mm"))
        rf = New RenderField()
        rf.Text = """Object contains expressions and Calculated is true."" + vbCrLf  +  ""Page = "" + PageNo.ToString() + vbCrLf + ""PageCount = "" + PageCount.ToString()"
        rf.Calculated = True
        rf.Style.Font = New Font("Tahoma", 20)
        rf.Style.Borders.All = LineDef.DefaultBold
        doc.Body.Children.Add(rf)

        doc.Body.Children.Add(New RenderEmpty("5mm"))
        doc.Body.Children.Add(New RenderText("Using of CheckBox property:"))
        doc.Body.Children.Add(New RenderEmpty("5mm"))
        rf = New RenderField()
        rf.Text = "1"
        ' content of RenderField will be represented as check box, state of checkbox
        ' will be determinated on the base of Text property, if it is:
        ' "1", "true" then checkbox will be checked
        rf.CheckBox = C1.C1Report.CheckBoxEnum.CheckBox
        doc.Body.Children.Add(rf)
        rf = New RenderField()
        rf.Text = "false"
        rf.CheckBox = C1.C1Report.CheckBoxEnum.RadioButton
        doc.Body.Children.Add(rf)

        doc.Body.Children.Add(New RenderEmpty("5mm"))
        doc.Body.Children.Add(New RenderText("RenderField renders an image defined as Image object:"))
        doc.Body.Children.Add(New RenderEmpty("5mm"))
        rf = New RenderField()
        rf.Picture = Image.FromFile("..\..\c1logo.gif")
        doc.Body.Children.Add(rf)

        doc.Body.Children.Add(New RenderEmpty("5mm"))
        doc.Body.Children.Add(New RenderText("RenderField renders an image defined name of file with image:"))
        doc.Body.Children.Add(New RenderEmpty("5mm"))
        rf = New RenderField()
        rf.Picture = "..\..\c1logo.gif"
        doc.Body.Children.Add(rf)

        doc.Body.Children.Add(New RenderEmpty("5mm"))
        doc.Body.Children.Add(New RenderText("RenderField renders an RTF text:"))
        doc.Body.Children.Add(New RenderEmpty("5mm"))
        rf = New RenderField()
        rf.RTF = True
        rf.Text = "{\rtf1\ansi\ansicpg1251\deff0\deflang1049{\fonttbl{\f0\fswiss\fcharset0 Arial;}{\f1\fswiss\fcharset204{\*\fname Arial;}Arial CYR;}}" & _
"{\colortbl ;\red255\green0\blue255;\red0\green255\blue0;\red0\green255\blue255;}" & _
"{\*\generator Msftedit 5.41.21.2500;}\viewkind4\uc1\pard\cf1\lang1033\f0\fs48 R\cf2 T\cf3 F\cf0  text\par" & _
"\b\fs28 RTF text\lang1049\b0\f1\fs20\par}"
        rf.BreakAfter = BreakEnum.Page
        doc.Body.Children.Add(rf)

        doc.Body.Children.Add(New RenderEmpty("5mm"))
        doc.Body.Children.Add(New RenderText("CanGrow property is false, so RenderField can't display all text (6 lines):"))
        doc.Body.Children.Add(New RenderEmpty("5mm"))
        rf = New RenderField()
        rf.Text = "Line1" + vbCrLf + "Line2" + vbCrLf + "Line3" + vbCrLf + "Line4" + vbCrLf + "Line5" + vbCrLf + "Line6"
        rf.Style.Borders.All = New LineDef("1mm", Color.Aquamarine)
        rf.CanGrow = False
        rf.Height = "10mm"
        rf.Style.Font = New Font("Tahoma", 14)
        doc.Body.Children.Add(rf)

        doc.Generate()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateDoc()
    End Sub
End Class
