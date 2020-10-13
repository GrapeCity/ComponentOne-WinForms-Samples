Imports C1.C1Preview
Imports C1.C1Preview.DataBinding
Imports System.Collections.Generic

Public Class Form1

    Public Class Customer
        Private _id As Integer
        Private _name As String

        Public Sub New(ByVal id As Integer, ByVal name As String)
            _id = id
            _name = name
        End Sub

        Public ReadOnly Property Id() As Integer
            Get
                Return _id
            End Get
        End Property

        Public ReadOnly Property Name() As String
            Get
                Return _name
            End Get
        End Property
    End Class



    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        ' build sample list of customers
        Dim i As Integer = 0
        Dim customers As List(Of Customer) = New List(Of Customer)()
        For i = 1 To 100
            customers.Add(New Customer(i, "Customer " + i.ToString))
        Next

        doc.Clear()
        doc.Style.Font = New Font("Verdana", 16)

        ' generate document
        doc.Body.Children.Add(New RenderText("List of Customer objects"))
        doc.Body.Children.Add(New RenderEmpty("5mm"))

        ' this object will be repeated for each element in the customers list
        Dim rt As RenderText = New RenderText
        rt.Text = "Id: [Fields!Id.Value]" & Microsoft.VisualBasic.Chr(13) & "Name: [Fields!Name.Value]"
        rt.Style.Borders.All = LineDef.DefaultBold
        rt.SplitVertBehavior = SplitBehaviorEnum.SplitIfLarge
        ' bind object with customers list
        rt.DataBinding.DataSource = customers
        doc.Body.Children.Add(rt)

        doc.Generate()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        button1_Click(Nothing, EventArgs.Empty)
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        doc.Clear()
        doc.Style.Font = New Font("Verdana", 20)

        doc.Body.Children.Add(New RenderText("The following RenderText object is bound to an empty list so it is not displayed.", AlignHorzEnum.Center))
        doc.Body.Children.Add(New RenderEmpty("5mm"))

        Dim rt As RenderText = New RenderText("This RenderText object has data binding with empty recordset")
        ' bind object with empty list
        rt.DataBinding.DataSource = New Integer(0) {}
        rt.Style.Borders.All = New LineDef("1mm", Color.Blue)
        rt.Style.BackColor = Color.YellowGreen
        doc.Body.Children.Add(rt)

        doc.Generate()
    End Sub

    Friend Function CreateDemoDataSource() As DataSource
        Dim result As DataSource = New DataSource
        result.ConnectionProperties.DataProvider = DataProviderEnum.OLEDB
        result.ConnectionProperties.ConnectString = _
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & _
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common" & _
                "\C1NWind.mdb"
        Return result
    End Function

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        doc.Clear()
        doc.Style.Font = New Font("Verdana", 16)

        ' define data schema
        Dim ds As DataSource = CreateDemoDataSource()
        Dim dsCities As DataSet = New DataSet(ds, "select * from Cities")
        doc.DataSchema.DataSources.Add(ds)
        doc.DataSchema.DataSets.Add(dsCities)

        ' title of document
        Dim rt As RenderText = New RenderText
        rt.Text = String.Format("ConnectString = {0}" & Microsoft.VisualBasic.Chr(13) & "CommandText={1}", ds.ConnectionProperties.ConnectString, dsCities.Query.CommandText)
        rt.Style.BackColor = Color.LightBlue
        rt.Style.Borders.All = New LineDef("1mm", Color.Blue)
        rt.Style.Spacing.Bottom = "1cm"
        doc.Body.Children.Add(rt)

        rt = New RenderText
        rt.DataBinding.DataSource = dsCities
        rt.Text = "Id = [Fields!ID.Value] Name = [Fields!City.Value]"
        rt.Style.Borders.Bottom = LineDef.Default
        doc.Body.Children.Add(rt)

        doc.Generate()
    End Sub

    Private Function CreateAggregate1(ByVal caption As String, ByVal aggregateName As String, ByVal captionStyle As Style, ByVal aggregateStyle As Style) As RenderObject
        Dim result As RenderParagraph = New RenderParagraph
        Dim pt As ParagraphText = New ParagraphText(caption + "" & Microsoft.VisualBasic.Chr(13) & "")
        pt.Style.Parents = captionStyle
        result.Content.Add(pt)
        pt = New ParagraphText("[Aggregates!" + aggregateName + ".Value]")
        pt.Style.Parents = aggregateStyle
        result.Content.Add(pt)

        Return result
    End Function

    Private Sub button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button4.Click
        doc.Clear()
        doc.Style.Font = New Font("Verdana", 12)

        ' initialize styles
        Dim boldFontStyle As Style = doc.Style.Children.Add
        boldFontStyle.Font = New Font("Verdana", 12, FontStyle.Bold)
        Dim smallFontStyle As Style = doc.Style.Children.Add
        smallFontStyle.Font = New Font("Verdana", 7)
        Dim detailCaptionStyle As Style = doc.Style.Children.Add
        detailCaptionStyle.TextAlignHorz = AlignHorzEnum.Center
        detailCaptionStyle.TextAlignVert = AlignVertEnum.Center
        detailCaptionStyle.Font = New Font("Verdana", 12, FontStyle.Underline)
        Dim detailStyle As Style = doc.Style.Children.Add
        detailStyle.Font = New Font("Verdana", 11)
        Dim dateStyle As Style = detailStyle.Children.Add
        dateStyle.TextAlignHorz = AlignHorzEnum.Center
        Dim timeStyle As Style = detailStyle.Children.Add
        timeStyle.TextAlignHorz = AlignHorzEnum.Center
        Dim paymentAmountStyle As Style = detailStyle.Children.Add
        paymentAmountStyle.TextAlignHorz = AlignHorzEnum.Right
        Dim quantityStyle As Style = detailStyle.Children.Add
        quantityStyle.TextAlignHorz = AlignHorzEnum.Right
        Dim descriptionStyle As Style = detailStyle.Children.Add
        descriptionStyle.TextAlignHorz = AlignHorzEnum.Left

        ' define data schema
        Dim ds As DataSource = CreateDemoDataSource()
        Dim dsCities As DataSet = New DataSet(ds, "SELECT Customer_demo.Company, [Order].* FROM (Customer_demo INNER JOIN [Order] ON Customer_demo.ID = [Order].CustomerID) ORDER BY Customer_demo.Company, [Order].PaymentType")
        doc.DataSchema.DataSources.Add(ds)
        doc.DataSchema.DataSets.Add(dsCities)

        Dim txt As RenderText = New RenderText
        txt.Text = "List of orders grouped by customers and payment type"
        txt.Style.Font = New Font("Tahoma", 16, FontStyle.Bold)
        doc.Body.Children.Add(txt)

        Dim rt As RenderTable = New RenderTable
        rt.Style.GridLines.All = LineDef.Default

        ' info about Company
        rt.Cells(0, 0).Text = "Company:"
        rt.Cells(0, 1).SpanCols = 3
        rt.Cells(0, 1).Text = "[Fields!Company.Value]"
        rt.Cells(0, 1).Style.Parents = boldFontStyle
        rt.Cells(0, 1).Style.BackColor = Color.LightCyan
        rt.Cells(0, 4).RenderObject = CreateAggregate1("Sum:", "CompanySum", smallFontStyle, boldFontStyle)
        rt.Cells(0, 4).Style.BackColor = Color.LightGray

        ' info about PaymentType
        rt.Cells(1, 0).Text = "Payment type:"
        rt.Cells(1, 1).Text = "[Fields!PaymentType.Value]"
        rt.Cells(1, 1).Style.Parents = boldFontStyle
        rt.Cells(1, 2).RenderObject = CreateAggregate1("Sum amount:", "PaymentTypeSum", smallFontStyle, boldFontStyle)
        rt.Cells(1, 2).Style.BackColor = Color.LightGray
        rt.Cells(1, 3).RenderObject = CreateAggregate1("Sum quantity:", "PaymentTypeQuantity", smallFontStyle, boldFontStyle)
        rt.Cells(1, 3).Style.BackColor = Color.LightGray
        rt.Cells(1, 4).RenderObject = CreateAggregate1("Item count:", "PaymentTypeCount", smallFontStyle, boldFontStyle)
        rt.Cells(1, 4).Style.BackColor = Color.LightGray

        ' captions of details
        rt.Cells(2, 0).Text = "Date"
        rt.Cells(2, 0).Style.Parents = detailCaptionStyle
        rt.Cells(2, 1).Text = "Time"
        rt.Cells(2, 1).Style.Parents = detailCaptionStyle
        rt.Cells(2, 2).Text = "Amount"
        rt.Cells(2, 2).Style.Parents = detailCaptionStyle
        rt.Cells(2, 3).Text = "Quantity"
        rt.Cells(2, 3).Style.Parents = detailCaptionStyle
        rt.Cells(2, 4).Text = "Description"
        rt.Cells(2, 4).Style.Parents = detailCaptionStyle

        ' details
        rt.Cells(3, 0).Text = "[FormatDateTime(Fields!PurchaseDate.Value, DateFormat.ShortDate)]"
        rt.Cells(3, 0).Style.Parents = dateStyle
        rt.Cells(3, 1).Text = "[FormatDateTime(Fields!Time.Value, DateFormat.ShortTime)]"
        rt.Cells(3, 1).Style.Parents = timeStyle
        rt.Cells(3, 2).Text = "[Fields!PaymentAmount.Value]"
        rt.Cells(3, 2).Style.Parents = paymentAmountStyle
        rt.Cells(3, 3).Text = "[Fields!Quantity.Value]"
        rt.Cells(3, 3).Style.Parents = quantityStyle
        rt.Cells(3, 4).Text = "[Fields!Description.Value]"
        rt.Cells(3, 4).Style.Parents = descriptionStyle

        ' summary by Payment type
        rt.Cells(4, 0).SpanCols = 2
        rt.Cells(4, 2).Text = "[Aggregates!PaymentTypeSum.Value]"
        rt.Cells(4, 3).SpanCols = 2

        ' summary by Company
        rt.Cells(5, 0).SpanCols = 4
        rt.Cells(5, 0).Text = "Sum for company [Fields!Company.Value]:"
        rt.Cells(5, 0).Style.TextAlignHorz = AlignHorzEnum.Right
        rt.Cells(5, 4).Text = "[Aggregates!CompanySum.Value]"

        ' itogo
        rt.Cells(6, 0).SpanCols = 4
        rt.Cells(6, 0).Text = "Summary:"
        rt.Cells(6, 0).Style.TextAlignHorz = AlignHorzEnum.Right
        rt.Cells(6, 4).Text = "[Aggregates!Sum.Value]"

        ' define databinding within table
        Dim g As TableVectorGroup = rt.RowGroups(0, 6)
        g.DataBinding.DataSource = dsCities
        g.DataBinding.Grouping.Expressions.Add("Fields!Company.Value")
        g.SplitBehavior = SplitBehaviorEnum.SplitIfNeeded
        doc.DataSchema.Aggregates.Add(New Aggregate("CompanySum", "Fields!PaymentAmount.Value", g.DataBinding, RunningEnum.Group, AggregateFuncEnum.Sum))
        doc.DataSchema.Aggregates.Add(New Aggregate("Sum", "Fields!PaymentAmount.Value", g.DataBinding, RunningEnum.Document, AggregateFuncEnum.Sum))

        g = rt.RowGroups(1, 4)
        g.DataBinding.DataSource = dsCities
        g.DataBinding.Grouping.Expressions.Add("Fields!PaymentType.Value")
        g.SplitBehavior = SplitBehaviorEnum.SplitIfNeeded
        doc.DataSchema.Aggregates.Add(New Aggregate("PaymentTypeCount", "Fields!PaymentAmount.Value", g.DataBinding, RunningEnum.Group, AggregateFuncEnum.Count))
        doc.DataSchema.Aggregates.Add(New Aggregate("PaymentTypeSum", "Fields!PaymentAmount.Value", g.DataBinding, RunningEnum.Group, AggregateFuncEnum.Sum))
        doc.DataSchema.Aggregates.Add(New Aggregate("PaymentTypeQuantity", "Fields!Quantity.Value", g.DataBinding, RunningEnum.Group, AggregateFuncEnum.Sum))

        g = rt.RowGroups(3, 1)
        g.DataBinding.DataSource = dsCities
        doc.Body.Children.Add(rt)
        doc.Generate()
    End Sub

End Class
