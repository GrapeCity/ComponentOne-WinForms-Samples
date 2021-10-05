Imports System.IO
Imports System.Text.RegularExpressions
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Themes
Imports C1.Win.Ribbon

Partial Public Class MainForm
    Inherits C1RibbonForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitThemes()
        SetupC1FlexGrid()
    End Sub

    Public Sub SetBandsColumnsRelation(ByVal bandsColumnsRelation As BandsColumnsRelation)
        c1FlexGridBandedView1.BeginUpdate()
        c1FlexGridBandedView1.BandsColumnsRelation = bandsColumnsRelation
        c1FlexGridBandedView1.EndUpdate()
    End Sub

    Public Sub ClearColumnBands()
        c1FlexGridBandedView1.Bands.Clear()
    End Sub

    Public Sub CreateBands()
        c1FlexGridBandedView1.BeginUpdate()
        ClearColumnBands()
        Dim bands = c1FlexGridBandedView1.Bands
        bands.Add("ID")
        Dim band1 As IBand = bands.Add("Car")
        band1.CollapseTo = "Model"
        Dim band2 As IBand = band1.Children.Add("Model")
        band2.CollapseTo = "Model"
        band2.Children.Add("Brand")
        band2.Children.Add("Model")
        band1.Children.Add("Category")
        c1FlexGridBandedView1.EndUpdate()
    End Sub

    Private Sub SetupC1FlexGrid()
        C1FlexGrid1.BeginUpdate()
        CarsTableAdapter1.Connection.ConnectionString = GetConnectionString()
        Me.CarsTableAdapter1.Fill(Me.C1NWindDataSet.Cars)
        Dim cars = C1NWindDataSet.Cars.AsEnumerable().ToList()
        cars.ForEach(Function(x)
                         Dim descr = Regex.Replace(x("Description").ToString(), "\r\n\s*\r\n", Environment.NewLine)
                         descr = Regex.Replace(descr, "(.{" & 77 & "})", "$1" & Environment.NewLine)
                         x("Description") = descr.Substring(0, Math.Min(descr.Length, 333))
                     End Function)
        LoadImages()
        C1FlexGrid1.AutoSizeCols()
        C1FlexGrid1.AutoSizeRows()
        C1FlexGrid1.Cols("Description").Width = 388

        For Each col As RowCol In C1FlexGrid1.Cols
            col.TextAlign = TextAlignEnum.CenterCenter
        Next

        C1FlexGrid1.Cols("Description").TextAlign = TextAlignEnum.LeftCenter
        C1FlexGrid1.EndUpdate()
    End Sub

    Private Sub LoadImages()
        Dim cars = C1NWindDataSet.Cars.AsEnumerable().ToList()
        Dim images = New Dictionary(Of Byte(), Image)()
        cars.ForEach(Function(x)
                         images.Add(CType(x("Picture"), Byte()), GetImage(x))
                     End Function)
        C1FlexGrid1.Cols("Picture").ImageMap = images
        C1FlexGrid1.Cols("Picture").Visible = True
        C1FlexGrid1.Cols("Picture").ImageAndText = False
    End Sub

    Private Function GetImage(ByVal row As DataRow) As Image
        If row Is Nothing Then Throw New ArgumentNullException()
        Dim imgBytes = CType(row("Picture"), Byte())
        Dim result = Image.FromStream(New MemoryStream(imgBytes))
        Return result
    End Function

    Private Shared Function GetConnectionString() As String
        Dim path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
        Dim conn = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
    Private Sub cmbTheme_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        C1ThemeController1.Theme = cmbThemes.SelectedItem.Text
        C1ThemeController1.SetTheme(C1FlexGrid1, C1ThemeController1.Theme)
    End Sub

    Private Sub rbCreateBands_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rbCreateBands.Click
        CreateBands()
    End Sub

    Private Sub rbClearBands_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rbClearBands.Click
        ClearColumnBands()
    End Sub

    Private Sub rbBandsColumnsRelation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbBandsColumnsRelation.SelectedIndexChanged
        Try
            Dim value = CType([Enum].Parse(GetType(BandsColumnsRelation), rbBandsColumnsRelation.Text), BandsColumnsRelation)
            SetBandsColumnsRelation(value)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#Region "Themes"

    Private Sub CmbThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbThemes.SelectedIndexChanged
        C1ThemeController1.Theme = cmbThemes.SelectedItem.Text
        C1ThemeController1.SetTheme(C1FlexGrid1, C1ThemeController1.Theme)
    End Sub

    Private Sub InitThemes()
        Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office2016"))

        For Each theme In themes
            cmbThemes.Items.Add(theme)
        Next

        cmbThemes.SelectedIndex = 3
    End Sub

#End Region

End Class
