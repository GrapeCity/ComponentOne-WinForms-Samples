Public Class Form1

    Dim _dataItemList As New List(Of DataItem)
    Dim _htmlPatternList As New List(Of String)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' create images 150x150 px size
        CreateBitmap("red.png", Color.Red)
        CreateBitmap("green.png", Color.Green)
        CreateBitmap("blue.png", Color.Blue)

        ' add items data
        AddDataItem("Red square", "Some description text", "red", "red.png")
        AddDataItem("Green square", "Description for green square", "green", "green.png")
        AddDataItem("Blue square", "Description for blue square", "blue", "blue.png")
        AddDataItem("Red sphere", "Description for red sphere", "sphere", "sphere.png")
        AddDataItem("The Cone", "A lot of description for cone figure", "cone", "cone.png")
        AddDataItem("Just a cube for sample", "Description for cube", "cube", "cube.png")

        ' set data source
        cbxResult.DataSource = _dataItemList
        cbxResult.ItemsDataSource = _dataItemList
        cbxResult.ItemsDisplayMember = "Title"
        cbxResult.ItemsValueMember = "Title"

        ' set other properties
        cbxResult.ItemsImageList = _imageList
        cbxResult.ItemMode = C1.Win.C1Input.ComboItemMode.HtmlPattern

        ' sample 1 data
        cbxSelectSample.Items.Add("Sample 1: image + title")

        _htmlPatternList.Add(
            "<table style='background:#D6EAF8;border:1px solid #AEB6BF;width:278px'>" & Environment.NewLine &
            "<tr style='padding:3px;border:0'>" & Environment.NewLine &
            "<td style='width:32px'><img src='{ImageFile}' width='24' height='24'></td>" & Environment.NewLine &
            "<td style='padding-left:5px;font-weight:bold'>{Title}</td>" & Environment.NewLine &
            "</tr>" & Environment.NewLine &
            "</table>")

        ' sample 2 data
        cbxSelectSample.Items.Add("Sample 2: image + title + description")

        _htmlPatternList.Add(
            "<table style='background:#D6EAF8;border:0;width:278px'>" & Environment.NewLine &
            "<tr>" & Environment.NewLine &
            "<td style='width:24px'><img src='{ImageFile}' width='24' height='24'></td>" & Environment.NewLine &
            "<td style='border:1px solid #85929E;background:#AED6F1;font-weight:bold;padding:3px'>{Title}</td>" & Environment.NewLine &
            "</tr>" & Environment.NewLine &
            "<tr>" & Environment.NewLine &
            "<td></td>" & Environment.NewLine &
            "<td style='padding:3px'>{Description}</td>" & Environment.NewLine &
            "</tr>" & Environment.NewLine &
            "</table>")

        ' sample 3 data
        cbxSelectSample.Items.Add("Sample 3: image + title + description")

        _htmlPatternList.Add(
            "<div style='background:#D6EAF8;border:1px solid #85929E'>" & Environment.NewLine &
            "<div style='background:#AED6F1;padding:3px'>" & Environment.NewLine &
            "<img src='{ImageFile}' width='24' height='24'>" & Environment.NewLine &
            "<span style='height:25px;font:14px;font-weight:bold;margin-left:3px'>{Title}</span>" & Environment.NewLine &
            "</div>" & Environment.NewLine &
            "<div style='padding:3px'>{Description}</div>" & Environment.NewLine &
            "</div>")

        ' sample 4 data
        cbxSelectSample.Items.Add("Sample 4: title + large image + description")

        _htmlPatternList.Add(
            String.Format("<table style='background:#D6EAF8;border-collapse:collapse;border:1px solid #AEB6BF;text-align:center;width:242px;margin-left:-{0}px'>",
            SystemInformation.VerticalScrollBarWidth) & Environment.NewLine &
            "<tr>" & Environment.NewLine &
            "<td style='background:#AED6F1;border:0;height:25px;font:14px;font-weight:bold'>{Title}</td>" & Environment.NewLine &
            "</tr>" & Environment.NewLine &
            "<tr>" & Environment.NewLine &
            "<td style='border:0'><img style='padding:5px' src='{ImageFile}' width='150px' height='150px'></td>" & Environment.NewLine &
            "</tr>" & Environment.NewLine &
            "<tr>" & Environment.NewLine &
            "<td style='border:0;color:#17202A'>{Description}</td>" & Environment.NewLine &
            "</tr>" & Environment.NewLine &
            "</table>")

        ' select first sample by default
        cbxSelectSample.SelectedIndex = 0
    End Sub

    Private Sub AddDataItem(ByVal title As String, ByVal description As String, ByVal imageKey As String, ByVal imageFile As String)
        _dataItemList.Add(New DataItem(title, description, imageKey, imageFile))

        ' add image if key And file assigned
        If Not (String.IsNullOrEmpty(imageKey) Or String.IsNullOrEmpty(imageFile)) Then
            _imageList.Images.Add(imageKey, Image.FromFile(imageFile))
        End If
    End Sub

    Public Shared Sub CreateBitmap(ByVal fileName As String, ByVal color As Color)
        Dim width = 150
        Dim height = 150

        ' create bitmap with specified color
        Dim bitmap = New Bitmap(width, height)

        Using g As Graphics = Graphics.FromImage(bitmap)
            Using brush As SolidBrush = New SolidBrush(color)
                g.FillRectangle(brush, 0, 0, width, height)
            End Using
        End Using

        bitmap.Save(fileName)
    End Sub

    Private Sub cbxSelectSample_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSelectSample.SelectedIndexChanged
        If cbxSelectSample.SelectedIndex = -1 Then
            Return
        End If

        Dim pattern = _htmlPatternList(cbxSelectSample.SelectedIndex)
        cbxResult.HtmlPattern = pattern
        tbxHtmlPattern.Text = pattern
    End Sub


    Public Class DataItem
        Public Sub New()
        End Sub

        Public Sub New(ByVal title As String, ByVal description As String, ByVal imageKey As String, ByVal imageFile As String)
            Me.Title = title
            Me.Description = description
            Me.ImageKey = imageKey
            Me.ImageFile = imageFile
        End Sub

        Public Property Title As String
        Public Property Description As String
        Public Property ImageKey As String
        Public Property ImageFile As String
    End Class

End Class